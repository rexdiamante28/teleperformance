Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Ethnicities
    Private _ethnicityId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property ethnicityId() As Integer
        Get
            Return _ethnicityId
        End Get
        Set(ByVal value As Integer)
            _ethnicityId = value
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


End Class
