Public Class Form2
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        intro_form.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Public passlesfistname As String
    Public passlesuserlastname As String
    Public passlesuserID As String
    Public lespacer As String = " "
    'Public UserNo As String
    Public Sub New(ByVal lesfistname, leslastname, userName)

        InitializeComponent()
        Me.Label2.Text = lesfistname + lespacer + leslastname
        'Me.Label6.Text = leslastname

        passlesfistname = lesfistname
        passlesuserlastname = leslastname
        passlesuserID = userName

        'receptionistADD.MyUserNo = lesfistname
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim updateprofile As New updateprofile(passlesfistname, passlesuserlastname, passlesuserID)
        updateprofile.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim registerforclasses As New registerforclasses(passlesfistname, passlesuserlastname, passlesuserID)
        registerforclasses.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim coursedetails As New coursedetails(passlesfistname, passlesuserlastname, passlesuserID)
        coursedetails.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim gradereport As New gradereport(passlesfistname, passlesuserlastname, passlesuserID)
        gradereport.Show()

    End Sub
End Class