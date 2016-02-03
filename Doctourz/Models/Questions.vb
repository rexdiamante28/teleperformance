Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Questions
    Private _questionId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property questionId() As Integer
        Get
            Return _questionId
        End Get
        Set(ByVal value As Integer)
            _questionId = value
        End Set
    End Property

    Private _question As String
    Public Property question() As String
        Get
            Return _question
        End Get
        Set(ByVal value As String)
            _question = value
        End Set
    End Property

    Private _isNegative As Boolean
    Public Property isNegative() As Boolean
        Get
            Return _isNegative
        End Get
        Set(ByVal value As Boolean)
            _isNegative = value
        End Set
    End Property

    Private _traitId As Integer
    Public Property traitId() As String
        Get
            Return _traitId
        End Get
        Set(ByVal value As String)
            _traitId = value
        End Set
    End Property
    Public Overridable Property traits As Traits

End Class
