Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Specializations
    Private _specializationId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property specializationId() As Integer
        Get
            Return _specializationId
        End Get
        Set(ByVal value As Integer)
            _specializationId = value
        End Set
    End Property

    Private _categoryId As String
    Public Property categoryId() As String
        Get
            Return _categoryId
        End Get
        Set(ByVal value As String)
            _categoryId = value
        End Set
    End Property

    Private _description As String
    Public Property description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
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
