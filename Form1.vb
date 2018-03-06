Public Class Form1
    Private Sub miStudent_Click(sender As Object, e As EventArgs) Handles miStudent.Click
        student.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        intro_form.Show()

    End Sub
End Class
