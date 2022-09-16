' *****************************************************************
' Team Number: 62
' Team Member 1 Details: Taumamng H (220102466)
' Team Member 2 Details: Mbuyisa, N (222052245)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details:
' Practical: Team Project
' Class name: Primary School
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class PrimarySchool
    Private _Name As String
    Private _Members() As Academic 'Both Teachers and Learners
    Private _WorkingHours As Integer

    Private _nStudents As Integer
    Private _nTeachers As Integer
    Private _TotMember As Integer

    Private _TaskToDo As Integer


    Public Sub New(ByVal name As String, ByVal number_of_students As Integer, ByVal number_of_teachers As Integer, ByVal working_hours As Integer, ByVal tasks_to_do As Integer)
        _Name = name
        ReDim _Members(number_of_students + number_of_teachers) 'resize to the total number of both learners and teachers
        _WorkingHours = working_hours

        _nStudents = number_of_students
        _nTeachers = number_of_teachers
        _TotMember = _nStudents + _nTeachers

        _TaskToDo = tasks_to_do

    End Sub

    Public Property name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property members As Academic()
        Get
            Return _Members
        End Get
        Set(value As Academic())
            _Members = value
        End Set
    End Property

    Public Property tasks As Integer
        Get
            Return _TaskToDo
        End Get
        Set(value As Integer)
            _TaskToDo = value
        End Set
    End Property

    Public Property teaching_hours As Integer
        Get
            Return _WorkingHours
        End Get
        Set(value As Integer)
            _WorkingHours = value
        End Set
    End Property

    Public Function DetermineStatus(ByVal mark As Double) As String
        'Determines the state of the school
        Dim status As String = "None"
        Select Case mark
            Case 1 To 40
                status = "Critical"
            Case 41 To 59
                status = "Danger Zone"
            Case 60 To 95
                status = "Stable"
            Case > 95
                status = "Good Condition"
        End Select

        Return status
    End Function

    Public Function CalcAvgPassRate() As Double
        Dim TotalMarks As Integer

        For m As Integer = 0 To _TotMember - 1
            If TypeOf _Members(m) Is Learner Then
                Dim sLearner As Learner = DirectCast(_Members(m), Learner) 'downcasting
                TotalMarks += sLearner.mark 'calculates the total marks for all students
            End If
        Next

        Return TotalMarks / _nStudents 'Calculates the average pass mark
    End Function

    Public Function CalcWorkDone() As Double
        'Determines the total work done by both teachers and learners in the school as a percentage
        Dim TotalWorkDone As Double = 0
        For m As Integer = 0 To _TotMember - 1
            TotalWorkDone += _Members(m).WorkDone() 'polymorphism
        Next
        Return (TotalWorkDone / (_TotMember * 100)) * 100
    End Function
End Class

