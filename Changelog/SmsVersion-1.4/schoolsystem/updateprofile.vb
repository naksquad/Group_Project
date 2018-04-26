
Imports System.Data.SqlClient

Public Class updateprofile
    Public lespacer As String = " "

    Private Sub updateprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToSQL()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Dim passlesuserID1 As String
    Public Sub New(ByVal lesfistname, leslastname, passlesuserID)

        InitializeComponent()
        Me.Label21.Text = lesfistname + lespacer + leslastname
        ' Me.Label8.Text = passlesuserID
        passlesuserID1 = passlesuserID
        'receptionistADD.MyUserNo = lesfistname
    End Sub

    Dim userIdNmuber As String
    Dim userFirstName As String
    Dim userLastName As String
    Dim userAddress As String
    Dim userContact As String
    Dim userPass As String


    Private Sub ConnectToSQL()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim Password As String
        'Dim userName As String
        'Dim leTrite As String
        'Dim lesuserName As String
        'Dim lesuserlastname As String
        'Dim lesmail As String
        'Dim lescontact As String
        'Dim lespacerDob As String
        'Dim lesadress As String
        'Dim lessex As String



        Try

            con.ConnectionString = "Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=lecole;Trusted_Connection=True;"
            con.Open()

            cmd.Connection = con
            cmd.CommandText = " SELECT user_address, user_email, user_title, user_password, user_Contact, user_Dob, user_Sex, user_id, user_title, user_FName, user_LName FROM user_table WHERE (user_id = '" & passlesuserID1 & "' )"


            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()

                    Me.Label20.Text = lrd("user_password").ToString()
                    Me.Label8.Text = lrd("user_id").ToString()
                    '   leTrite = lrd("user_title").ToString()
                    Me.Label10.Text = lrd("user_FName").ToString()
                    Me.Label17.Text = lrd("user_LName").ToString()
                    Me.Label11.Text = lrd("user_email").ToString()
                    Me.Label18.Text = lrd("user_Contact").ToString()
                    Me.Label12.Text = lrd("user_address").ToString()
                    Me.Label14.Text = lrd("user_Dob").ToString()
                    Me.Label15.Text = lrd("user_Sex").ToString()

                    userIdNmuber = lrd("user_id").ToString()
                    userFirstName = lrd("user_FName").ToString()
                    userLastName = lrd("user_LName").ToString()
                    userAddress = lrd("user_address").ToString()
                    userContact = lrd("user_email").ToString()
                    userPass = lrd("user_password").ToString()
                End While

            Else
                MessageBox.Show("error..", "wrond id", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Clear all fields
                ' txtpassword.Text = ""
                ' txtUser.Text = ""
            End If



        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

        Finally
            con.Close() 'Whether there is error or not. Close the connection.

        End Try
    End Sub


    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim updatemailingadress As New updatemailingadress(userIdNmuber, userFirstName, userLastName, userAddress)
        updatemailingadress.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim updatecontact As New updatecontact(userIdNmuber, userFirstName, userLastName, userContact)
        updatecontact.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updatepassword As New updatepassword(userIdNmuber, userFirstName, userLastName, userPass)
        updatepassword.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

End Class