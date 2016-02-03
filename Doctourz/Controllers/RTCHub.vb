
Imports Microsoft.AspNet.SignalR
Imports Doctourz.opentokRTC.Models
Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Web

Namespace opentokRTC.Controllers
    <Hubs.HubName("rTCHub")>
    Public Class RTCHub
        Inherits Hub

        Public Shared Users As New ConcurrentDictionary(Of String, User)()
        Public Shared OnlineRooms As New ConcurrentDictionary(Of String, Rooms)()
        Public Shared connections As New connections()


        Public Sub Send(ByVal name As String, ByVal message As String, ByVal senderAvatar As String)
            Clients.All.addNewMessageToPage(name, message, senderAvatar)
        End Sub

        Public Sub sendMessage(ByVal name As String, ByVal message As String, ByVal senderAvatar As String, sessionId As String)
            Dim myClients As New List(Of String)()

            For Each u In Users
                If u.Value.Opentok.SessionId = sessionId Then
                    myClients.Add(u.Value.ConnectionId)
                End If
            Next

            Clients.Clients(myClients).addNewMessageToPage(name, message, senderAvatar)

        End Sub

        Public Function GetConnected(username As String, avatar As String, Remote_Address As String, roomName As String) As User
            If roomName <> "" Then
                Dim sessionId As String = ""
                For Each r In OnlineRooms
                    If roomName = r.Value.roomName Then
                        sessionId = r.Value.session
                    End If
                Next

                Dim user As User
                connections.Add(Context.ConnectionId)
                Dim ot = New oTok(Remote_Address, sessionId)

                user = New User(username, Context.ConnectionId, ot, avatar)

                If sessionId = "" Then
                    Dim room As Rooms
                    room = New Rooms(roomName, user.Opentok.SessionId)

                    OnlineRooms.TryAdd(Context.ConnectionId, room)
                End If


                Dim onlineUsers As New ConcurrentDictionary(Of String, User)()
                Dim onlineConnections As New List(Of String)()

                For Each u In Users
                    If u.Value.Opentok.SessionId = sessionId Then
                        If Not u.Value.ConnectionId = user.ConnectionId Then
                            onlineUsers.TryAdd(u.Key, u.Value)
                            onlineConnections.Add(u.Value.ConnectionId)
                        End If
                    End If
                Next

                Users.TryAdd(Context.ConnectionId, user)
                Clients.Clients(onlineConnections).getNewOnlineUser(user)
                Clients.Client(Context.ConnectionId).getOnlineUsers(onlineUsers)

                Return user
            End If

            Return Nothing
        End Function


        Public Sub BeginCall(toConnectionId As String)

            Dim touser = Users(toConnectionId)
            Dim caller = Users(Context.ConnectionId)
            Dim users__1 As New List(Of User)()

            Clients.Client(toConnectionId).notifybeginCall(touser, caller)


        End Sub

        Public Sub CallRejectedSignal(CallerConnectionId As String)

            Dim self = Users(Context.ConnectionId)

            Clients.Client(CallerConnectionId).notifyCallrejected("Call rejected by : " + self.Name)
        End Sub



        Public Sub EndCall(CallerConnectionId As String)
            Try


                Dim caller As New User()
                Dim self As New User()
                If Users.ContainsKey(Context.ConnectionId) Then
                    self = Users(Context.ConnectionId)
                    caller = Users(CallerConnectionId)

                    Clients.Client(CallerConnectionId).notifyCallend(caller, self)
                End If
            Catch exp As Exception
            End Try
        End Sub


        Private Sub GetDisConnected(ConnectionId As String)
            If Users.ContainsKey(ConnectionId) = True Then
                Dim user As User
                Dim currentuser As User = Users(ConnectionId)

                Users.TryRemove(ConnectionId.ToString(), user)
                connections.Remove(ConnectionId)
                Clients.Clients(connections.AllExcept(ConnectionId)).disconnected(user)


                Try
                    Dim room As Rooms
                    Dim newRoom = OnlineRooms(ConnectionId)
                    Dim newOwner = Users.Where(Function(x) x.Value.Opentok.SessionId = newRoom.session).First
                    If OnlineRooms.TryRemove(ConnectionId.ToString(), room) Then
                        room = New Rooms(newRoom.roomName, newRoom.session)

                        OnlineRooms.TryAdd(newOwner.Value.ConnectionId, room)
                    End If
                Catch
                    Dim room As Rooms
                    OnlineRooms.TryRemove(ConnectionId.ToString(), room)
                End Try
            End If

        End Sub

        Public Sub GetDisConnected()
            GetDisConnected(Context.ConnectionId)
        End Sub

        Public Overrides Function OnDisconnected(stopcalled As Boolean) As Task
            GetDisConnected(Context.ConnectionId)

            Return MyBase.OnDisconnected(stopcalled)
        End Function


    End Class
End Namespace


