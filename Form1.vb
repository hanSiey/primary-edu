' *****************************************************************
' Team Number: 62
' Team Member 1 Details: Taumamng H (220102466)
' Team Member 2 Details: Mbuyisa, N (222052245)
' Team Member 3 Details: Muchichwa,PR (221133122)
' Team Member 4 Details:
' Practical: Team Project
' Class name: frmEducation
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmEducation
    Private Schools(,) As PrimarySchool
    Private nSchools As Integer
    Private nYears As Integer

    Private nLearners As Integer
    Private nTeachers As Integer

    Private l1, l2 As Integer 'location on the grid

    Private Sub OnGrid(ByVal row As Integer, ByVal col As Integer, ByVal txt As String)
        'Displays On grid
        grdEducation.Row = row
        grdEducation.Col = col
        grdEducation.Text = txt
    End Sub
    Private Sub btnInitialze_Click(sender As Object, e As EventArgs) Handles btnInitialze.Click
        Dim working_hours As Integer
        Dim name As String
        Dim tasks_to_do As Integer

        nSchools = CInt(InputBox("Enter the number of schools", "Schools"))
        nYears = CInt(InputBox("Enter the number of years assessed", "Schools"))

        ReDim Schools(nSchools, nYears) 'Resize 2d array

        'Resize Grid 
        grdEducation.Rows = nSchools + 1
        grdEducation.Cols = nYears + 3

        l1 = grdEducation.Cols - 1
        l2 = grdEducation.Cols - 2

        For s As Integer = 0 To nSchools - 1
            name = InputBox("Enter the name of school " + CStr(s + 1))
            working_hours = CInt(InputBox("Enter the total number of working hours for the teachers in each year"))
            tasks_to_do = CInt(InputBox("Enter the total number of assigments and tasks issued to leaners in each year"))

            For y As Integer = 0 To nYears - 1
                nLearners = CInt(InputBox("Enter the number of learners in " + name + " during year " + CStr(y + 1), "School")) 'Number of students for each year
                nTeachers = CInt(InputBox("Enter the number of teachers in " + name + " during year " + CStr(y + 1), "School")) 'Number of teachers for each year
                Schools(s, y) = New PrimarySchool(name, nLearners, nTeachers, working_hours, tasks_to_do)
                OnGrid(s + 1, 0, name)
                OnGrid(0, y + 1, "Year " + CStr(y + 1))
            Next y
        Next s


        OnGrid(0, l1, "Status")
        OnGrid(0, l2, "Avg Pass Rate")


    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim name As String
        Dim absentdays As Integer
        Dim taskscompleted As Integer
        Dim tasks_to_mark As Integer
        Dim mark As Integer
        Dim markingdone As Integer

        For s As Integer = 0 To nSchools - 1
            For y As Integer = 0 To nYears - 1
                Dim position As Integer = 0
                For l As Integer = position To nLearners - 1
                    name = InputBox("Enter the name and surname of learner " + CStr(l + 1), "School")
                    absentdays = CInt(InputBox("Enter the number of days " + name + " has been asbent out of 200 school days", "School"))
                    taskscompleted = CInt(InputBox("Enter the number of tasks completed by " + name + " out of " + CStr(Schools(s, y).tasks) + " tasks", "Learner"))
                    mark = CInt(InputBox("Enter the final mark for " + name, "Learner"))

                    Schools(s, y).members(l) = New Learner(name, Schools(s, y).tasks, absentdays, mark, taskscompleted)  'Upcasting
                    position += 1

                Next l
                For t As Integer = 0 To nTeachers - 1
                    name = InputBox("Enter the name and surname of Teacher " + CStr(t + 1), "School")
                    absentdays = CInt(InputBox("Enter the number of days " + name + " has been asbent out of 200 school days", "School"))
                    tasks_to_mark = Schools(s, y).tasks 'tasks to be marked are the same as the tasks to be completed
                    markingdone = CInt(InputBox("Enter the number of tasks marked by " + name, "Teacher"))

                    Schools(s, y).members(position) = New Teacher(name, absentdays, Schools(s, y).teaching_hours, markingdone, tasks_to_mark) 'Upcasting
                    position += 1
                Next t
            Next y
        Next s
    End Sub

    Private Sub btnWorkDone_Click(sender As Object, e As EventArgs) Handles btnWorkDone.Click
        Dim work_done As Double
        For s As Integer = 0 To nSchools - 1
            For y As Integer = 0 To nYears - 1
                work_done = Schools(s, y).CalcWorkDone() 'Calculate the total work done for each school each year
                OnGrid(s + 1, y + 1, Format(work_done, "0") + "%")
            Next y
        Next s
    End Sub

    Private Sub btnAvgPassRate_Click(sender As Object, e As EventArgs) Handles btnAvgPassRate.Click
        Dim pass_rate As Double
        For s As Integer = 0 To nSchools - 1
            For y As Integer = 0 To nYears - 1
                pass_rate = Schools(s, y).CalcAvgPassRate()
                OnGrid(s + 1, l2, Format(pass_rate, "0") + "%")
            Next y
        Next s
    End Sub

    Private Sub btnCalcCritical_Click(sender As Object, e As EventArgs) Handles btnCalcCritical.Click
        Dim status As String
        Dim TotCritical As Integer = 0

        For s As Integer = 0 To nSchools - 1
            For y As Integer = 0 To nYears - 1
                status = Schools(s, y).DetermineStatus(Schools(s, y).CalcAvgPassRate())
                If status = "Critical" Then
                    TotCritical += 1
                End If
            Next
        Next

        txtCritical.Text = CStr(TotCritical)
    End Sub

    Private Sub btnCalcDanger_Click(sender As Object, e As EventArgs) Handles btnCalcDanger.Click
        Dim status As String
        Dim TotDanger As Integer = 0

        For s As Integer = 0 To nSchools - 1
            For y As Integer = 0 To nYears - 1
                status = Schools(s, y).DetermineStatus(Schools(s, y).CalcAvgPassRate())
                If status = "Danger Zone" Then
                    TotDanger += 1
                End If
            Next
        Next

        txtDanger.Text = CStr(TotDanger)
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        Dim status As String
        For s As Integer = 0 To nSchools - 1
            For y As Integer = 0 To nYears - 1
                status = Schools(s, y).DetermineStatus(Schools(s, y).CalcAvgPassRate())
                OnGrid(s + 1, l1, status)
            Next y
        Next s
    End Sub

End Class

