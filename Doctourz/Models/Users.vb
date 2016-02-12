
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace opentokRTC.Models
    Public Class Users
        Public Property ConnectionId() As String
            Get
                Return m_ConnectionId
            End Get
            Set(value As String)
                m_ConnectionId = value
            End Set
        End Property
        Private m_ConnectionId As String
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = value
            End Set
        End Property
        Private m_Name As String

        Public Property Avatar() As String
            Get
                Return m_Avatar
            End Get
            Set(value As String)
                m_Avatar = value
            End Set
        End Property
        Private m_Avatar As String

        Public Property CurrentRoom() As String
            Get
                Return m_CurrentRoom
            End Get
            Set(value As String)
                m_CurrentRoom = value
            End Set
        End Property
        Private m_CurrentRoom As String

        Public Property Opentok() As openTok
            Get
                Return m_Opentok
            End Get
            Set(value As openTok)
                m_Opentok = value
            End Set
        End Property
        Private m_Opentok As openTok
        Public Sub New()
            Me.Name = ""
            Me.Avatar = ""
        End Sub
        Public Sub New(name As String, connectionId As String, opentok As openTok, avatar As String, roomName As String)
            Me.Name = name

            Me.Avatar = avatar

            Me.ConnectionId = connectionId

            Me.Opentok = opentok

            Me.CurrentRoom = roomName

        End Sub
    End Class

End Namespace

