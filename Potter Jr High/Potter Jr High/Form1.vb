Option Infer Off
Option Strict On
Option Explicit On

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstGrades.Items.Add("G")
        Dim inFile As IO.StreamReader
        Dim lines As String() = IO.File.ReadAllLines("Grades.txt")

        If IO.File.Exists("Grades.txt") Then
            inFile = IO.File.OpenText("Grades.txt")

            For intSub As Integer = 0 To lines.Length
                If lstGrades.Items.Count <= 0 Then
                    lstGrades.Items.Add(inFile.ReadLine)
                ElseIf lstGrades.ToString.Length Then
                Else
                    lstGrades.Items.Add(inFile.ReadLine)
                End If
            Next

        End If
    End Sub
End Class
