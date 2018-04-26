Imports System.Data.SqlClient
Public Class studentadDetails
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


    Public Sub LaodGridstudent(Optional Query As String = "")
        If Query = "" Then
            SQL.AddParam("@THEID", passlesuserID1)
            SQL.ExecQuery("SELECT * FROM user_table WHERE user_title = 'student';")

        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridStudenta.DataSource = SQL.DBDT
    End Sub

    Private Sub Finditem()
        'wild card test
        SQL.AddParam("@item", "%" & TxtSearch100sd.Text & "%")
        LaodGridstudent("SELECT * FROM user_table WHERE user_id LIKE @item OR user_FName LIKE @item OR user_LName LIKE @item;")

        'to select only last name 
        ' LaodGrid("SELECT student_last_name FROM student_table WHERE studentID LIKE @item OR student_full_name LIKE @item;")


    End Sub



    Private Sub studentadDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LaodGridstudent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Finditem()
    End Sub
End Class