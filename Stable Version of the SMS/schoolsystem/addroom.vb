Imports System.Data.SqlClient
Public Class addroom
    Public SQL As New SQLControl
    Public passlesfistname As String
    Public passlesuserlastname As String
    Public passlesuserID As String
    Public lespacer As String = " "
    'Public UserNo As String
    Public Sub New(ByVal lesfistname, leslastname, userName)

        InitializeComponent()
        Me.Label5ddsdFF.Text = lesfistname + lespacer + leslastname
        'Me.Label6.Text = leslastname

        passlesfistname = lesfistname
        passlesuserlastname = leslastname
        passlesuserID = userName

        'receptionistADD.MyUserNo = lesfistname
    End Sub

    Public Sub LaodGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM room_table;")
        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DataGridPatientddfs.DataSource = SQL.DBDT
    End Sub

    Private Sub Finditem()
        'wild card test
        SQL.AddParam("@item", "%" & TxtSearch100ss.Text & "%")
        LaodGrid("SELECT * FROM room_table WHERE room_id LIKE @item;")

        'to select only last name 
        ' LaodGrid("SELECT student_last_name FROM student_table WHERE studentID LIKE @item OR student_full_name LIKE @item;")


    End Sub


    Private Sub enterPatient()


        Dim query As String = String.Empty
        query &= "INSERT INTO room_table (room_id)"
        query &= "VALUES (@ID)"

        Using conn As New SqlConnection("Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=lecole;Trusted_Connection=True;")
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID", TextBox1cc.Text)


                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        TextBox1cc.Text = ""
    End Sub

    Public Sub dropclasse(Optional Query As String = "")

        SQL.AddParam("@THEROOM", TextBox1cc.Text)
        SQL.ExecQuery("DELETE FROM room_table  WHERE room_id = @THEROOM;")
        SQL.ExecQuery(Query)
        TextBox1cc.Text = ""
        ' DataGridView1235.DataSource = SQL.DBDT
    End Sub


    Private Sub addroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        enterPatient()
        LaodGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LaodGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dropclasse()
        LaodGrid()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Finditem()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class