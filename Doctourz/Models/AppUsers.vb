Imports System.ComponentModel.DataAnnotations

Public Class AppUsers


    Private _userId As String
    <Key>
    Public Property userId() As String
        Get
            Return _userId
        End Get
        Set(ByVal value As String)
            _userId = value
        End Set
    End Property

    Private _userName As String
    <Required>
    <Display(Name:="Username")>
    Public Property userName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property

    Private _name As String
    <Required>
    <Display(Name:="Username")>
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property


    Private _email As String
    <Required>
    <Display(Name:="Email")>
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _level As String
    Public Property level() As String
        Get
            Return _level
        End Get
        Set(ByVal value As String)
            _level = value
        End Set
    End Property

    Private _firstName As String
    <Required>
    <Display(Name:="First Name")>
    Public Property firstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Private _lastName As String
    <Required>
    <Display(Name:="Last Name")>
    Public Property lastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property


    Private _gender As String
    <Display(Name:="Gender")>
    Public Property gender() As String
        Get
            Return _gender
        End Get
        Set(ByVal value As String)
            _gender = value
        End Set
    End Property


    Private _birthDate As DateTime
    <DataType(DataType.DateTime)>
    <Display(Name:="Birth Date")>
    Public Property birthDate() As DateTime
        Get
            Return _birthDate
        End Get
        Set(ByVal value As DateTime)
            _birthDate = value
        End Set
    End Property

    Private _mobile As String
    <Display(Name:="Mobile")>
    Public Property mobile() As String
        Get
            Return _mobile
        End Get
        Set(ByVal value As String)
            _mobile = value
        End Set
    End Property

    Private _telephone As String
    <Display(Name:="Telephone")>
    Public Property telephone() As String
        Get
            Return _telephone
        End Get
        Set(ByVal value As String)
            _telephone = value
        End Set
    End Property

    Private _address1 As String
    Public Property address1() As String
        Get
            Return _address1
        End Get
        Set(ByVal value As String)
            _address1 = value
        End Set
    End Property


    Private _avatar As String
    Public Property avatar() As String
        Get
            Return _avatar
        End Get
        Set(ByVal value As String)
            _avatar = value
        End Set
    End Property

    Private _isActive As Boolean
    Public Property isPublic() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            _isActive = value
        End Set
    End Property


    Public Overridable Property applicationUser() As ApplicationUser

End Class
