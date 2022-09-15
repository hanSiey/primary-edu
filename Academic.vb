' *****************************************************************
' Team Number: 62
' Team Member 1 Details: Taumamng H (220102466)
' Team Member 2 Details: Mbuyisa, N (222052245)
' Team Member 3 Details: Muchichwa,PR (221133122)
' Team Member 4 Details:
' Practical: Team Project
' Class name: Academic
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off
Public Class Academic
    Protected Shared _SchoolDays As Integer 'total school days in a year
    Protected _AbsentDays As Integer
    Protected _Name As String
    Protected _Surname As String
    Protected _work As Integer

    Public Sub New(ByVal name As String, ByVal surname As String, ByVal work As Integer, ByVal absentdays As Integer)
        _SchoolDays = 200
        _AbsentDays = absentdays
        _Name = name
        _Surname = surname
        _work = work

    End Sub

    Protected Function PresentDays() As Integer
        Return _SchoolDays - _AbsentDays   ' Number of days present
    End Function
    Public Overridable Function WorkDone() As Double
        Return _work - PresentDays()
    End Function

End Class
