Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class SubSpecializations
    Private _subSpecId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property subSpecId() As Integer
        Get
            Return _subSpecId
        End Get
        Set(ByVal value As Integer)
            _subSpecId = value
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

    Private _specializationId As Integer
    Public Property specializationId() As Integer
        Get
            Return _specializationId
        End Get
        Set(ByVal value As Integer)
            _specializationId = value
        End Set
    End Property

    Public Overridable Property Specialization() As Specializations
End Class
