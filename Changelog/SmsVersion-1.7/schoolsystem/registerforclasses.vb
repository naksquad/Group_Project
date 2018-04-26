
Imports System.Data.SqlClient
Public Class registerforclasses

    Public lespacer As String = " "
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ' Form2.Show()
    End Sub
    Dim passlesuserID1 As String
    Public Sub New(ByVal lesfistname, leslastname, passlesuserID)

        InitializeComponent()
        Me.Labelle42.Text = lesfistname + lespacer + leslastname
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
            SQL.ExecQuery("SELECT course_ID FROM enroll_table WHERE user_id = @THEID;")

        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridView1235.DataSource = SQL.DBDT
    End Sub
    'combobox

    Public Sub LaodGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM course_tables;")
        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridStudent.DataSource = SQL.DBDT
    End Sub


    Private Sub Finditem()
        'wild card test
        SQL.AddParam("@item", "%" & TxtSearch100.Text & "%")
        LaodGrid("SELECT * FROM course_tables WHERE course_ID LIKE @item OR cousre_Name LIKE @item;")

        'to select only last name 
        ' LaodGrid("SELECT student_last_name FROM student_table WHERE studentID LIKE @item OR student_full_name LIKE @item;")


    End Sub

    Private Sub enterPatient()


        Dim query As String = String.Empty
        query &= "INSERT INTO enroll_table (user_id, course_ID)"
        query &= "VALUES (@USERID, @COURSEID)"

        Using conn As New SqlConnection("Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=lecole;Trusted_Connection=True;")
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@USERID", passlesuserID1)
                    .Parameters.AddWithValue("@COURSEID", TextBox2445.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        TextBox2445.Text = ""


    End Sub


    Private Sub DataGridPatient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStudent.CellContentClick

    End Sub

    Private Sub registerforclasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonPatient_Click(sender As Object, e As EventArgs) Handles ButtonPatient.Click

        LaodGrid()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Finditem()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        enterPatient()
        LaodGridstudent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LaodGridstudent()
    End Sub

    Public Sub dropclasse(Optional Query As String = "")

        SQL.AddParam("@THEID", passlesuserID1)
            SQL.AddParam("@THECOURSE", TextBox2445.Text)
            SQL.ExecQuery("DELETE FROM enroll_table  WHERE user_id = @THEID AND course_ID = @THECOURSE;")
        SQL.ExecQuery(Query)
        TextBox2445.Text = ""
        ' DataGridView1235.DataSource = SQL.DBDT
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dropclasse()
        LaodGridstudent()
    End Sub

End Class