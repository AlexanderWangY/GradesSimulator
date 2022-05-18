Public Class Form2
    Private Sub lblSubmit_Click(sender As Object, e As EventArgs) Handles lblSubmit.Click
        Dim name As String = txtbName.Text
        Dim grade As String = txtbGrade.Text

        If Module1.add = False Then
            remove(name)
            Form1.Show()
            Me.Close()
        Else


        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Module1.add = False Then
            lblGrade.Hide()
            txtbGrade.Hide()
        End If
    End Sub

    Public Sub remove(name As String)
        Dim student As String = name.ToUpper
        Dim gradesFile As IO.StreamReader
        Dim studentsFile As IO.StreamReader

        Dim index As Integer = -1

        If IO.File.Exists("Grades.txt") And IO.File.Exists("Students.txt") Then
            gradesFile = IO.File.OpenText("Grades.txt")
            studentsFile = IO.File.OpenText("Students.txt")
            Dim gLines As List(Of String) = IO.File.ReadAllLines("Grades.txt").ToList
            Dim sLines As List(Of String) = IO.File.ReadAllLines("Students.txt").ToList

            For x As Integer = 0 To sLines.Count - 1
                If sLines(x).ToUpper.Equals(student) Then
                    index = x
                End If
            Next

            If index = -1 Then
                MsgBox("Student Not Found")
                gradesFile.Close()
                studentsFile.Close()

            Else
                gLines.RemoveAt(index)
                sLines.RemoveAt(index)

                gradesFile.Close()
                studentsFile.Close()

                System.IO.File.WriteAllLines("Grades.txt", gLines)
                System.IO.File.WriteAllLines("Students.txt", sLines)
            End If
        End If


    End Sub

    Public Sub add(name As String, grade As String)
        Dim gradesFile As IO.StreamReader
        Dim studentsFile As IO.StreamReader

        gradesFile = IO.File.OpenText("Grades.txt")
        studentsFile = IO.File.OpenText("Students.txt")
        Dim gLines As List(Of String) = IO.File.ReadAllLines("Grades.txt").ToList
        Dim sLines As List(Of String) = IO.File.ReadAllLines("Students.txt").ToList

        If IO.File.Exists("Grades.txt") And IO.File.Exists("Students.txt") Then

        End If
    End Sub
End Class