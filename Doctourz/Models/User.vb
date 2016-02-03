
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
        Public Sub New(name As String, connectionId As String, opentok As oTok, avatar As String)
            Me.Name = name

            Me.Avatar = avatar

            Me.ConnectionId = connectionId

            Me.Opentok = opentok
        End Sub
    End Class

End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
