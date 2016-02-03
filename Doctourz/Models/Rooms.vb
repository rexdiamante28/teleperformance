Public Class Rooms
    Private _roomName As String
    Public Property roomName() As String
        Get
            Return _roomName
        End Get
        Set(ByVal value As String)
            _roomName = value
        End Set
    End Property

    Private _session As String
    Public Property session() As String
        Get
            Return _session
        End Get
        Set(ByVal value As String)
            _session = value
        End Set
    End Property


    Private _token As String

    Public Sub New(roomName As String, session As String)
        Me.roomName = roomName

        Me.session = session

    End Sub

End Class
