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

    Private _name As String
    <Display(Name:="Name")>
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
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
   
    Private _civilStatus As String
    <Display(Name:="Civil Status")>
    Public Property civilStatus() As String
        Get
            Return _civilStatus
        End Get
        Set(ByVal value As String)
            _civilStatus = value
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

    Private _ethnicityId As Integer
    <Display(Name:="Ethnicity")>
    Public Property ethnicityId() As Integer
        Get
            Return _ethnicityId
        End Get
        Set(ByVal value As Integer)
            _ethnicityId = value
        End Set
    End Property

    Private _height As String
    <Display(Name:="Height")>
    Public Property height() As String
        Get
            Return _height
        End Get
        Set(ByVal value As String)
            _height = value
        End Set
    End Property

    Private _weight As String
    <Display(Name:="Weight")>
    Public Property weight() As String
        Get
            Return _weight
        End Get
        Set(ByVal value As String)
            _weight = value
        End Set
    End Property

    Private _bmi As String
    <Display(Name:="BMI")>
    Public Property bmi() As String
        Get
            Return _bmi
        End Get
        Set(ByVal value As String)
            _bmi = value
        End Set
    End Property

    Private _diet As String
    <Display(Name:="Diet")>
    Public Property diet() As String
        Get
            Return _diet
        End Get
        Set(ByVal value As String)
            _diet = value
        End Set
    End Property

    Private _alcohol As String
    <Display(Name:="Alcohol")>
    Public Property alcohol() As String
        Get
            Return _alcohol
        End Get
        Set(ByVal value As String)
            _alcohol = value
        End Set
    End Property

    Private _tobacco As String
    <Display(Name:="Tobacco")>
    Public Property tobacco() As String
        Get
            Return _tobacco
        End Get
        Set(ByVal value As String)
            _tobacco = value
        End Set
    End Property

    Private _sexual As String
    <Display(Name:="Sexually Active")>
    Public Property sexual() As String
        Get
            Return _sexual
        End Get
        Set(ByVal value As String)
            _sexual = value
        End Set
    End Property

    Private _recreationalDrugs As String
    <Display(Name:="Recreational Drugs")>
    Public Property recreationalDrugs() As String
        Get
            Return _recreationalDrugs
        End Get
        Set(ByVal value As String)
            _recreationalDrugs = value
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

    Private _location As String
    <Display(Name:="Location")>
    Public Property location() As String
        Get
            Return _location
        End Get
        Set(ByVal value As String)
            _location = value
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

    Private _address2 As String
    Public Property address2() As String
        Get
            Return _address2
        End Get
        Set(ByVal value As String)
            _address2 = value
        End Set
    End Property

    Private _city As String
    Public Property city() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    Private _state As String
    Public Property state() As String
        Get
            Return _state
        End Get
        Set(ByVal value As String)
            _state = value
        End Set
    End Property

    Private _country As String
    Public Property country() As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property

    Private _zip As String
    Public Property zip() As String
        Get
            Return _zip
        End Get
        Set(ByVal value As String)
            _zip = value
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

    Private _isPublic As Boolean
    Public Property isPublic() As Boolean
        Get
            Return _isPublic
        End Get
        Set(ByVal value As Boolean)
            _isPublic = value
        End Set
    End Property

    Private _practiceClinics As List(Of Clinics)
    Public Property NewProperty() As List(Of Clinics)
        Get
            Return _practiceClinics
        End Get
        Set(ByVal value As List(Of Clinics))
            _practiceClinics = value
        End Set
    End Property

    Public Overridable Property applicationUser() As ApplicationUser

End Class
