Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Education
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Private _educationId As Integer
    Public Property educationId() As Integer
        Get
            Return _educationId
        End Get
        Set(ByVal value As Integer)
            _educationId = value
        End Set
    End Property

    Private _schoolName As String
    Public Property schoolName() As String
        Get
            Return _schoolName
        End Get
        Set(ByVal value As String)
            _schoolName = value
        End Set
    End Property

    <DataType(DataType.DateTime)>
    Private _yearGraduated As DateTime
    Public Property yearGraduated() As DateTime
        Get
            Return _yearGraduated
        End Get
        Set(ByVal value As DateTime)
            _yearGraduated = value
        End Set
    End Property

    Private _degreeId As String
    Public Property degreeId() As String
        Get
            Return _degreeId
        End Get
        Set(ByVal value As String)
            _degreeId = value
        End Set
    End Property

    Private _userId As String
    Public Property userId() As String
        Get
            Return _userId
        End Get
        Set(ByVal value As String)
            _userId = value
        End Set
    End Property

    Public Overridable Property AppUser() As AppUsers



End Class
