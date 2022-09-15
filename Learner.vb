' *****************************************************************
' Team Number: 62
' Team Member 1 Details: Taumamng H (220102466)
' Team Member 2 Details: Mbuyisa, N (222052245)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details:
' Practical: Team Project
' Class name: Learner
' *****************************************************************

Option Strict On
Option Infer Off
Option Explicit On
Public Class Learner
    Inherits Academic

    Private _mark As Integer
    Private _taskscompleted As Integer

    Public Sub New(ByVal name As String, ByVal surname As String, ByVal work As Integer, ByVal absentdays As Integer, ByVal mark As Integer, ByVal taskscompleted As Integer)
        MyBase.New(name, surname, work, absentdays)
        _mark = mark
        _taskscompleted = taskscompleted
    End Sub

    Public Property mark As Integer
        Get
            Return _mark
        End Get
        Set(value As Integer)
            _mark = value
        End Set
    End Property

    Public Property taskscompleted As Integer
        Get
            Return _taskscompleted
        End Get
        Set(value As Integer)
            _taskscompleted = value
        End Set
    End Property

    Public Shared ReadOnly Property Schooldays As Integer
        Get
            Return _SchoolDays
        End Get
    End Property

    Public Property name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Surname As String
        Get
            Return _Surname
        End Get
        Set(value As String)
            _Surname = value
        End Set
    End Property

    Public Overrides Function WorkDone() As Double
        Return (_taskscompleted / _work) * 100   'Calculates the percentage of the work done by a learner
    End Function
End Class

