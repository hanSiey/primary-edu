' *****************************************************************
' Team Number: 62
' Team Member 1 Details: Taumamng H (220102466)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Muchichwa,PR (221133122)
' Team Member 4 Details:
' Practical: Team Project
' Class name: Teacher
' *****************************************************************
Public Class Teacher

    Inherits Academic

    Private _TaskstoMark As Integer
    Private _MarkingCompleted As Integer
    Private Shared _WorkingHours As Integer


    'Constructor
    Public Sub New(ByVal name As String, ByVal surname As String, ByVal work As Integer, ByVal absentdays As Integer, ByVal workinghours As Integer, ByVal markingcompleted As Integer, ByVal taskstomark As Integer)
        MyBase.New(name, surname, work, absentdays)
        _TaskstoMark = taskstomark
        _MarkingCompleted = markingcompleted
        _WorkingHours = workinghours
    End Sub

    'Property methods
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Surname() As String
        Get
            Return _Surname
        End Get
        Set(value As String)
            _Surname = value
        End Set
    End Property

    Public Property work() As Integer
        Get
            Return _work
        End Get
        Set(value As Integer)
            _work = value
        End Set
    End Property

    Public Property absentdays As Integer
        Get
            Return _AbsentDays
        End Get
        Set(value As Integer)
            _AbsentDays = value
        End Set
    End Property

    Public Shared ReadOnly Property WorkingHours() As Integer
        Get
            Return _WorkingHours
        End Get
    End Property
    Public Property Marking() As Integer
        Get
            Return _MarkingCompleted
        End Get
        Set(value As Integer)
            _MarkingCompleted = value
        End Set
    End Property

    Public Property TaskstoMark() As Integer
        Get
            Return _TaskstoMark
        End Get
        Set(value As Integer)
            _TaskstoMark = value
        End Set
    End Property

    'Helper function toconvert to hours
    Private Function ConvertToHours(ByVal days As Integer) As Integer
        Return days * 7
    End Function

    'Function to cAlculate workdone
    Public Overrides Function Workdone() As Double
        Dim workcompleted As Integer

        _work = _TaskstoMark + _WorkingHours
        workcompleted = _MarkingCompleted + ConvertToHours(PresentDays())

        Return (workcompleted / _work) * 100
    End Function


End Class
