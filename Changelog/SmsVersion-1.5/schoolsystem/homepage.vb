Public Class homepage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intro_form.Show()
        Me.Hide()

    End Sub

    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class