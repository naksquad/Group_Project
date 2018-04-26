Imports System.Data.SqlClient

Public Class intro_form

    Private Sub intro_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    'Login Button

    Private Sub loginButton_Click(sender As System.Object, e As System.EventArgs) Handles loginButton.Click

        ConnectToSQL()

    End Sub

    'Connect to SQL method

    Private Sub ConnectToSQL()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim userName As String
        Dim leTrite As String
        Dim lesuserName As String
        Dim lesuserlastname As String


        Try

            con.ConnectionString = "Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=lecole;Trusted_Connection=True;"
            con.Open()

                cmd.Connection = con
            cmd.CommandText = " SELECT user_id, user_password, user_title, user_FName, user_LName FROM user_table WHERE (user_id = '" & txtUser.Text & "' ) AND (user_password = '" & txtpassword.Text & "')"




            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()

                    Password = lrd("user_password").ToString()
                    userName = lrd("user_id").ToString()
                    leTrite = lrd("user_title").ToString()
                    lesuserName = lrd("user_FName").ToString()
                    lesuserlastname = lrd("user_LName").ToString()






                    If String.Compare(Password, txtpassword.Text, StringComparison.InvariantCultureIgnoreCase) = 0 And String.Compare(userName, txtUser.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then

                        MessageBox.Show("Logged in successfully as " & lesuserName, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'student
                        If String.Compare(leTrite, "student", StringComparison.InvariantCultureIgnoreCase) = 0 Then

                            Dim Form2 As New Form2(lesuserName, lesuserlastname, userName)
                            Form2.Show()
                            Me.Hide()

                            'Clear all fields
                            txtpassword.Text = ""
                            txtUser.Text = ""

                        End If
                        'manager
                        If String.Compare(leTrite, "teacher", StringComparison.InvariantCultureIgnoreCase) = 0 Then
                            Dim Adminportal As New Adminportal(lesuserName, lesuserlastname, userName)
                            Adminportal.Show()
                            Me.Hide()

                            'Clear all fields
                            txtpassword.Text = ""
                            txtUser.Text = ""

                        End If
                    End If
                End While

            Else
                    MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Clear all fields
                    txtpassword.Text = ""
                    txtUser.Text = ""
                End If



        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

        Finally
            con.Close() 'Whether there is error or not. Close the connection.

        End Try



    End Sub


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click


        txtUser.Text = ""


        txtpassword.Text = ""


        txtUser.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        homepage.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class

