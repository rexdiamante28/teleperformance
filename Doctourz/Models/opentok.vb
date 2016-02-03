
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports OpenTokApi.Core
Imports System.Configuration

Namespace opentokRTC.Models

    Public Class openTok
        Public Property ApiKey() As String
            Get
                Return m_ApiKey
            End Get
            Set(value As String)
                m_ApiKey = value
            End Set
        End Property
        Private m_ApiKey As String
        Public Property SessionId() As String
            Get
                Return m_SessionId
            End Get
            Set(value As String)
                m_SessionId = value
            End Set
        End Property
        Private m_SessionId As String
        Public Property Token() As String
            Get
                Return m_Token
            End Get
            Set(value As String)
                m_Token = value
            End Set
        End Property
        Private m_Token As String
        Public Sub New(REMOTE_ADDR As String)
            Dim ot As New OpenTokApi.Core.OpenTok
            Dim options As New Dictionary(Of String, Object)()
            options.Add(SessionProperties.P2PPreference, "enabled")
            Me.SessionId = ot.CreateSession(REMOTE_ADDR, options)
            Me.Token = ot.GenerateToken(Me.SessionId)
            Me.ApiKey = ConfigurationManager.AppSettings("opentok.key")
        End Sub
    End Class

End Namespace
