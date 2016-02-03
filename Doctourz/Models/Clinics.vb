Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Clinics
    Private _clinicId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property clinicId() As Integer
        Get
            Return _clinicId
        End Get
        Set(ByVal value As Integer)
            _clinicId = value
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

    Private _address As String
    Public Property address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Private _mobile As String
    Public Property mobile() As String
        Get
            Return _mobile
        End Get
        Set(ByVal value As String)
            _mobile = value
        End Set
    End Property

    Private _landline As String
    Public Property landline() As String
        Get
            Return _landline
        End Get
        Set(ByVal value As String)
            _landline = value
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

    Private _writeUp As String
    Public Property writeUp() As String
        Get
            Return _writeUp
        End Get
        Set(ByVal value As String)
            _writeUp = value
        End Set
    End Property

    Private _history As String
    Public Property history() As String
        Get
            Return _history
        End Get
        Set(ByVal value As String)
            _history = value
        End Set
    End Property

End Class
