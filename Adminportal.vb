Public Class Adminportal


    Public passlesfistname As String
    Public passlesuserlastname As String
    Public passlesuserID As String
    Public lespacer As String = " "
    'Public UserNo As String
    Public Sub New(ByVal lesfistname, leslastname, userName)

        InitializeComponent()
        Me.Label5dd.Text = lesfistname + lespacer + leslastname
        'Me.Label6.Text = leslastname

        passlesfistname = lesfistname
        passlesuserlastname = leslastname
        passlesuserID = userName

        'receptionistADD.MyUserNo = lesfistname
    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        intro_form.Show()
    End Sub

    Private Sub Adminportal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim receptionistADD As New receptionistADD(passlesfistname, passlesuserlastname, passlesuserID)
        receptionistADD.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim studentadDetails As New studentadDetails(passlesfistname, passlesuserlastname, passlesuserID)
        studentadDetails.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim addgrade As New addgrade(passlesfistname, passlesuserlastname, passlesuserID)
        addgrade.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim schooldetail As New schooldetail(passlesfistname, passlesuserlastname, passlesuserID)
        schooldetail.Show()
    End Sub
End Class