
Imports System.Data.SqlClient
Public Class Adminstudentdetails
    Public lespacer As String = " "
    Private Sub Adminstudentdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Dim passlesuserID1 As String
    Public Sub New(ByVal lesfistname, leslastname, passlesuserID)

        InitializeComponent()
        Me.Label5ddj12.Text = lesfistname + lespacer + leslastname
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
            SQL.ExecQuery("SELECT * FROM exam_table;")

        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridStudentSS.DataSource = SQL.DBDT
    End Sub


    Private Sub enterPatient()


        Dim query As String = String.Empty
        query &= "INSERT INTO exam_table (user_id, course_id, exam_desc, exam_grade)"
        query &= "VALUES (@USERID, @COURSEID, @EXAMDESC, @EXAMGRADE)"

        Using conn As New SqlConnection("Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=lecole;Trusted_Connection=True;")
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@USERID", TextBox2445D.Text)
                    .Parameters.AddWithValue("@COURSEID", TextBox1SD.Text)
                    .Parameters.AddWithValue("@EXAMDESC", TextBox2RF.Text)
                    .Parameters.AddWithValue("@EXAMGRADE", TextBox3XX.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        TextBox2445D.Text = ""


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        enterPatient()
    End Sub
End Class