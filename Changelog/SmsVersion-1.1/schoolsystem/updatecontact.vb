Imports System.Data.SqlClient
Public Class updatecontact
    Dim lespacer As String = " "
    Dim passlesuserID1 As String
    Dim passlesusermail As String
    Dim lFist As String
    Dim llast As String


    Public Sub New(ByVal userIdNmuber, userFirstName, userLastName, userAddress)

        InitializeComponent()
        Me.Label21.Text = userFirstName + lespacer + userLastName
        ' Me.Label8.Text = passlesuserID
        passlesuserID1 = userIdNmuber
        lFist = userFirstName
        llast = userLastName
        ' Me.Label45.Text = userAddress
        'receptionistADD.MyUserNo = lesfistname
    End Sub



    Private Sub enterPatient()


        Dim query As String = String.Empty
        query &= "UPDATE user_table SET user_email = @Address WHERE user_id = @id"
        '  query &= "VALUES (@Address)"
        '  query &= "WHERE (user_id = )"

        Using conn As New SqlConnection("Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=lecole;Trusted_Connection=True;")
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@Address", TextBox2.Text)
                    .Parameters.AddWithValue("@id", passlesuserID1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        TextBox2.Text = ""


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim updateprofile As New updateprofile(lFist, llast, passlesuserID1)
        updateprofile.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub updatecontact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        enterPatient()
    End Sub
End Class