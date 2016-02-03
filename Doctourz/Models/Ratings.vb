Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Ratings
    Private _ratingsId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property ratingsId() As Integer
        Get
            Return _ratingsId
        End Get
        Set(ByVal value As Integer)
            _ratingsId = value
        End Set
    End Property


    Private _score As Integer
    Public Property score() As Integer
        Get
            Return _score
        End Get
        Set(ByVal value As Integer)
            _score = value
        End Set
    End Property

    Private _traitId As Integer
    Public Property traitId() As Integer
        Get
            Return _traitId
        End Get
        Set(ByVal value As Integer)
            _traitId = value
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
    Public Overridable Property applicationUser() As ApplicationUser


End Class
