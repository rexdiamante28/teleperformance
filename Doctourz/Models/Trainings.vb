Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Trainings
    Private _trainingId As Integer
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property training() As Integer
        Get
            Return _trainingId
        End Get
        Set(ByVal value As Integer)
            _trainingId = value
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

    Private _dateAttended As DateTime
    <DataType(DataType.DateTime)>
    Public Property dateAttended() As DateTime
        Get
            Return _dateAttended
        End Get
        Set(ByVal value As DateTime)
            _dateAttended = value
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
