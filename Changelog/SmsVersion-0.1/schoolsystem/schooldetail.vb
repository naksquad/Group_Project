Imports System.Data.SqlClient
Public Class schooldetail

    Public passlesfistname As String
    Public passlesuserlastname As String
    Public passlesuserID As String
    Public lespacer As String = " "

    Dim passlesuserID1 As String
    Public Sub New(ByVal lesfistname, leslastname, passlesuserID)

        InitializeComponent()
        Me.Label5dds.Text = lesfistname + lespacer + leslastname
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


    Public SQL As New SQLControl


    Private Sub schooldetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim addcourse As New addcourse(passlesfistname, passlesuserlastname, passlesuserID)
        addcourse.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim addroom As New addroom(passlesfistname, passlesuserlastname, passlesuserID)
        addroom.Show()
    End Sub
End Class