Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Public Class Procedures
    Private _proceduresId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property proceduresId() As Integer
        Get
            Return _proceduresId
        End Get
        Set(ByVal value As Integer)
            _proceduresId = value
        End Set
    End Property

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
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
