Public Class DoctorList
    Public Property docId() As String
        Get
            Return m_docId
        End Get
        Set(value As String)
            m_docId = value
        End Set
    End Property
    Private m_docId As String

    Public Property docName() As String
        Get
            Return m_docName
        End Get
        Set(value As String)
            m_docName = value
        End Set
    End Property
    Private m_docName As String

    Public Property docSpecializationId() As String
        Get
            Return m_docSpecializationId
        End Get
        Set(value As String)
            m_docSpecializationId = value
        End Set
    End Property
    Private m_docSpecializationId As String

    Public Property docSpecialization() As String
        Get
            Return m_docSpecialization
        End Get
        Set(value As String)
            m_docSpecialization = value
        End Set
    End Property
    Private m_docSpecialization As String

    Public Property docLocation() As String
        Get
            Return m_docLocation
        End Get
        Set(value As String)
            m_docLocation = value
        End Set
    End Property
    Private m_docLocation As String

    Public Property docGender() As String
        Get
            Return m_docGender
        End Get
        Set(value As String)
            m_docGender = value
        End Set
    End Property
    Private m_docGender As String

    Public Property docDegree() As String
        Get
            Return m_docDegree
        End Get
        Set(value As String)
            m_docDegree = value
        End Set
    End Property
    Private m_docDegree As String

    Public Property docAvatar() As String
        Get
            Return m_docAvatar
        End Get
        Set(value As String)
            m_docAvatar = value
        End Set
    End Property
    Private m_docAvatar As String
End Class
