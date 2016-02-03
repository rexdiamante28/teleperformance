Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Traits
    Private _traitId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property traitId() As Integer
        Get
            Return _traitId
        End Get
        Set(ByVal value As Integer)
            _traitId = value
        End Set
    End Property

    Private _trait As String
    Public Property trait() As String
        Get
            Return _trait
        End Get
        Set(ByVal value As String)
            _trait = value
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


    Private _color As String
    Public Property color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property

    Private _questions As List(Of Questions)
    Public Property questions() As List(Of Questions)
        Get
            Return _questions
        End Get
        Set(ByVal value As List(Of Questions))
            _questions = value
        End Set
    End Property

End Class
