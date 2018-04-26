Imports System.Data.SqlClient
Public Class addcourse
    Public SQL As New SQLControl
    Public passlesfistname As String
    Public passlesuserlastname As String
    Public passlesuserID As String
    Public lespacer As String = " "
    'Public UserNo As String
    Public Sub New(ByVal lesfistname, leslastname, userName)

        InitializeComponent()
        Me.TxtSearch100ss.Text = lesfistname + lespacer + leslastname
        'Me.Label6.Text = leslastname

        passlesfistname = lesfistname
        passlesuserlastname = leslastname
        passlesuserID = userName

        'receptionistADD.MyUserNo = lesfistname
    End Sub

    Public Sub LaodGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM course_tables;")
        Else
            Sql.ExecQuery(Query)
        End If

        'catch error
        If Sql.HasException(True) Then Exit Sub
        DataGridPatientddfs.DataSource = SQL.DBDT
    End Sub

    Private Sub Finditem()
        'wild card test
        SQL.AddParam("@item", "%" & TxtSearch100ss.Text & "%")
        LaodGrid("SELECT * FROM course_tables WHERE course_ID LIKE @item OR cousre_Name LIKE @item OR course_type LIKE @item;")

        'to select only last name 
        ' LaodGrid("SELECT student_last_name FROM student_table WHERE studentID LIKE @item OR student_full_name LIKE @item;")


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub addcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LaodGrid()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Finditem()
    End Sub
End Class