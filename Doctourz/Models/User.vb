
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace opentokRTC.Models
    Public Class User
        Public Property ConnectionId() As String
            Get
                Return m_ConnectionId
            End Get
            Set(value As String)
                m_ConnectionId = Value
            End Set
        End Property
        Private m_ConnectionId As String
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
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

        Public Property DateAndTime() As String
            Get
                Return m_DateAndTime
            End Get
            Set(value As String)
                m_DateAndTime = value
            End Set
        End Property

        Private m_DateAndTime As String


        Public Property CurrentRoom() As String
            Get
                Return m_CurrentRoom
            End Get
            Set(value As String)
                m_CurrentRoom = value
            End Set
        End Property
        Private m_CurrentRoom As String

        Public Property UserId() As String
            Get
                Return m_userId
            End Get
            Set(value As String)
                m_userId = value
            End Set
        End Property
        Private m_userId As String


        Public Property level() As String
            Get
                Return m_level
            End Get
            Set(value As String)
                m_level = value
            End Set
        End Property
        Private m_level As String


        Public Property Opentok() As oTok
            Get
                Return m_Opentok
            End Get
            Set(value As oTok)
                m_Opentok = value
            End Set
        End Property
        Private m_Opentok As oTok
        Public Sub New()
            Me.Name = ""
            Me.Avatar = ""
        End Sub
        Public Sub New(name As String, connectionId As String, opentok As oTok, avatar As String, roomName As String, dateTime As Date, level As String, userId As String)
            Me.Name = name

            Me.Avatar = avatar

            Me.ConnectionId = connectionId

            Me.Opentok = opentok

            Me.CurrentRoom = roomName

            Me.DateAndTime = dateTime

            Me.level = level

            Me.UserId = userId
        End Sub
    End Class

End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
