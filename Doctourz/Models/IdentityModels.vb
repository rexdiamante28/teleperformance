Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports System.Data.Entity

' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
Public Class ApplicationUser
    Inherits IdentityUser
    Public Async Function GenerateUserIdentityAsync(manager As UserManager(Of ApplicationUser)) As Task(Of ClaimsIdentity)
        ' Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        Dim userIdentity = Await manager.CreateIdentityAsync(Me, DefaultAuthenticationTypes.ApplicationCookie)
        ' Add custom user claims here
        Return userIdentity
    End Function
End Class

Public Class ApplicationDbContext
    Inherits IdentityDbContext(Of ApplicationUser)
    Public Sub New()
        MyBase.New("DefaultConnection", throwIfV1Schema:=False)
        'Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of ApplicationDbContext, Migrations.Configuration)())
    End Sub

    Public Shared Function Create() As ApplicationDbContext
        Return New ApplicationDbContext()
    End Function

    Private _AppUsers As DbSet(Of AppUsers)
    Public Property AppUsers() As DbSet(Of AppUsers)
        Get
            Return _AppUsers
        End Get
        Set(ByVal value As DbSet(Of AppUsers))
            _AppUsers = value
        End Set
    End Property

    Private _Questions As DbSet(Of Questions)
    Public Property Questions() As DbSet(Of Questions)
        Get
            Return _Questions
        End Get
        Set(ByVal value As DbSet(Of Questions))
            _Questions = value
        End Set
    End Property

    Private _Ratings As DbSet(Of Ratings)
    Public Property Ratings() As DbSet(Of Ratings)
        Get
            Return _Ratings
        End Get
        Set(ByVal value As DbSet(Of Ratings))
            _Ratings = value
        End Set
    End Property

    Private _Traits As DbSet(Of Traits)
    Public Property Traits() As DbSet(Of Traits)
        Get
            Return _Traits
        End Get
        Set(ByVal value As DbSet(Of Traits))
            _Traits = value
        End Set
    End Property

    Private _Affiliations As DbSet(Of Affiliations)
    Public Property Affiliations() As DbSet(Of Affiliations)
        Get
            Return _Affiliations
        End Get
        Set(ByVal value As DbSet(Of Affiliations))
            _Affiliations = value
        End Set
    End Property

    Private _Education As DbSet(Of Education)
    Public Property Education() As DbSet(Of Education)
        Get
            Return _Education
        End Get
        Set(ByVal value As DbSet(Of Education))
            _Education = value
        End Set
    End Property

    Private _Procedures As DbSet(Of Procedures)
    Public Property Procedures() As DbSet(Of Procedures)
        Get
            Return _Procedures
        End Get
        Set(ByVal value As DbSet(Of Procedures))
            _Procedures = value
        End Set
    End Property

    'Private _Questions As DbSet(Of Questions)
    'Public Property Questions() As DbSet(Of Questions)
    '    Get
    '        Return _Questions
    '    End Get
    '    Set(ByVal value As DbSet(Of Questions))
    '        _Questions = value
    '    End Set
    'End Property

    Private _Specializations As DbSet(Of Specializations)
    Public Property Specializations() As DbSet(Of Specializations)
        Get
            Return _Specializations
        End Get
        Set(ByVal value As DbSet(Of Specializations))
            _Specializations = value
        End Set
    End Property

    Private _SubSpecializations As DbSet(Of SubSpecializations)
    Public Property SubSpecializations() As DbSet(Of SubSpecializations)
        Get
            Return _SubSpecializations
        End Get
        Set(ByVal value As DbSet(Of SubSpecializations))
            _SubSpecializations = value
        End Set
    End Property

    Private _Trainings As DbSet(Of Trainings)
    Public Property Trainings() As DbSet(Of Trainings)
        Get
            Return _Trainings
        End Get
        Set(ByVal value As DbSet(Of Trainings))
            _Trainings = value
        End Set
    End Property

    Private _SpecializationCategory As DbSet(Of SpecializationCategory)
    Public Property SpecializationCategory() As DbSet(Of SpecializationCategory)
        Get
            Return _SpecializationCategory
        End Get
        Set(ByVal value As DbSet(Of SpecializationCategory))
            _SpecializationCategory = value
        End Set
    End Property

    Private _Degree As DbSet(Of Degree)
    Public Property Degree() As DbSet(Of Degree)
        Get
            Return _Degree
        End Get
        Set(ByVal value As DbSet(Of Degree))
            _Degree = value
        End Set
    End Property

    Public _Ethnicities As DbSet(Of Ethnicities)

    Public Property Ethnicities As DbSet(Of Ethnicities)
        Get
            Return _Ethnicities
        End Get
        Set(value As DbSet(Of Ethnicities))
            _Ethnicities = value
        End Set
    End Property

    Private _History1 As DbSet(Of History1)
    Public Property History1() As DbSet(Of History1)
        Get
            Return _History1
        End Get
        Set(ByVal value As DbSet(Of History1))
            _History1 = value
        End Set
    End Property

End Class
