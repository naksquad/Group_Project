Imports System.Data.SqlClient
Public Class coursedetails
    Public lespacer As String = " "
    Dim passlesuserID1 As String
    Public Sub New(ByVal lesfistname, leslastname, passlesuserID)

        InitializeComponent()
        Me.Labelle42dd.Text = lesfistname + lespacer + leslastname
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
            SQL.ExecQuery("SELECT enroll_table.course_ID, course_tables.cousre_Name, course_tables.course_Date, course_tables.course_Time, course_tables.course_credit, course_tables.room_id, course_tables.course_type FROM enroll_table JOIN course_tables ON course_tables.course_ID=enroll_table.course_ID  WHERE user_id = @THEID;")

        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridStudentview.DataSource = SQL.DBDT
    End Sub




    Private Sub coursedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LaodGridstudent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ButtonPatient_Click(sender As Object, e As EventArgs) Handles ButtonPatient.Click
        LaodGridstudent()
    End Sub
End Class