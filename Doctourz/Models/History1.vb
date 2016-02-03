Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class History1
    Private _historyId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property historyId() As Integer
        Get
            Return _historyId
        End Get
        Set(ByVal value As Integer)
            _historyId = value
        End Set
    End Property

    Private _symptom As String
    Public Property symptom() As String
        Get
            Return _symptom
        End Get
        Set(ByVal value As String)
            _symptom = value
        End Set
    End Property

    Private _whoHadIt As String
    Public Property whoHadIt() As String
        Get
            Return _whoHadIt
        End Get
        Set(ByVal value As String)
            _whoHadIt = value
        End Set
    End Property

    Private _age As String
    Public Property age() As String
        Get
            Return _age
        End Get
        Set(ByVal value As String)
            _age = value
        End Set
    End Property
    Private _type As String
    Public Property type() As String
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
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
