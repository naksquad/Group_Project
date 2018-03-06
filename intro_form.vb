Imports System.Data.SqlClient
Public Class intro_form

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim Connnection As New SqlConnection("Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=schoolsystem;Trusted_Connection=True;")
        Dim Command As New SqlCommand("SELECT * FROM administrator_table WHERE admin_username= @username and admin_password=@password", Connnection)
        Command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUser.Text
        Command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("User Name Or Pawword Invalid")
        Else
            MessageBox.Show("welcome login succefull")
            Form1.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub intro_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        homepage.Show()
    End Sub
End Class