
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace opentokRTC.Models
    Public Class connections
        Public Shared ConnectionsList As New List(Of String)()

        Public Sub Add(ConnectionId As String)
            ConnectionsList.Add(ConnectionId)
        End Sub
        Public Sub Remove(ConnectionId As String)
            ConnectionsList.Remove(ConnectionId)
        End Sub


        Public Function AllExcept(ParamArray ConnectionIds As String()) As List(Of String)
            Dim connections = ConnectionsList.Except(ConnectionIds).ToList()
            Return connections
        End Function


    End Class
End Namespace

