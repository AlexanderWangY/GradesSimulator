Option Infer Off
Option Strict On
Option Explicit On

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim inFile As IO.StreamReader
        lstGrades.Items.Clear()
        If IO.File.Exists("Grades.txt") Then
            inFile = IO.File.OpenText("Grades.txt")
            Dim lines As String() = IO.File.ReadAllLines("Grades.txt")
            For Each x As String In lines
                If lstGrades.Items.Contains(x) Then
                Else
                    lstGrades.Items.Add(x)
                End If
            Next


            inFile.Close()

        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstStudents.Items.Clear()
        Dim selectedGrade As String = lstGrades.SelectedItem.ToString
        Dim gradesFile As IO.StreamReader
        Dim studentsFile As IO.StreamReader
        If IO.File.Exists("Grades.txt") And IO.File.Exists("Students.txt") Then
            gradesFile = IO.File.OpenText("Grades.txt")
            studentsFile = IO.File.OpenText("Students.txt")
            Dim gLines As String() = IO.File.ReadAllLines("Grades.txt")
            Dim sLines As String() = IO.File.ReadAllLines("Students.txt")

            For x As Integer = 0 To gLines.Length - 1
                If gLines(x) = selectedGrade Then
                    lstStudents.Items.Add(sLines(x))
                End If
            Next

            gradesFile.Close()
            studentsFile.Close()
        End If

        lblNumber.Text = lstStudents.Items.Count.ToString


    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        Module1.add = True
        Form2.Show()
        Me.Hide()
    End Sub

    Public Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Module1.add = False
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim inFile As IO.StreamReader
        lstGrades.Items.Clear()

        If IO.File.Exists("Grades.txt") Then
            inFile = IO.File.OpenText("Grades.txt")
            Dim lines As String() = IO.File.ReadAllLines("Grades.txt")
            For Each x As String In lines
                If lstGrades.Items.Contains(x) Then
                Else
                    lstGrades.Items.Add(x)
                End If
            Next


            inFile.Close()

        End If
    End Sub
End Class
