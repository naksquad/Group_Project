Imports System.Data.SqlClient
Public Class gradereport
    Public lespacer As String = " "

    Dim passlesuserID1 As String
    Public Sub New(ByVal lesfistname, leslastname, passlesuserID)

        InitializeComponent()
        Me.Labelle42FF.Text = lesfistname + lespacer + leslastname
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
            SQL.ExecQuery("SELECT course_id AS COURSE_ID, SUM(exam_grade)/COUNT(course_id) AS GRADE FROM exam_table WHERE user_id = @THEID GROUP BY course_id;")

        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridPatientx.DataSource = SQL.DBDT
    End Sub
    'combobox

    Public Sub LaodGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.AddParam("@THEID", passlesuserID1)
            SQL.ExecQuery("SELECT * FROM exam_table WHERE user_id = @THEID ORDER BY course_id ASC;")
        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridPatientx.DataSource = SQL.DBDT
    End Sub


    Private Sub Finditem()
        'wild card test\
        SQL.AddParam("@THEID", passlesuserID1)
        SQL.AddParam("@item", "%" & TxtSearch100s.Text & "%")
        LaodGrid("SELECT * FROM exam_table WHERE user_id = @THEID AND course_ID LIKE @item OR exam_desc LIKE @item;")

        'to select only last name 
        ' LaodGrid("SELECT student_last_name FROM student_table WHERE studentID LIKE @item OR student_full_name LIKE @item;")


    End Sub



    Private Sub gradereport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LaodGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LaodGridstudent()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Finditem()
    End Sub
End Class