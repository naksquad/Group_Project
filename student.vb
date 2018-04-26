Public Class student

    Public SQL As New SQLControl

    Public Sub LaodGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM student_table;")
            'SQL.ExecQuery("SELECT * FROM course_table;")
            'SQL.ExecQuery("SELECT * FROM room_table;")

        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If SQL.HasException(True) Then Exit Sub
        DG1.DataSource = SQL.DBDT
    End Sub
    'combobox
    Private Sub LoadCBX()
        'clear combo box first
        cbxItems.Items.Clear()
        SQL.ExecQuery("SELECT subjectID FROM course_table;")

        If SQL.HasException(True) Then Exit Sub
        'loop the row and add to combo box
        For Each r As DataRow In SQL.DBDT.Rows
            cbxItems.Items.Add(r("subjectID").ToString)

        Next
    End Sub

    Private Sub Finditem()
        'wild card test
        SQL.AddParam("@item", "%" & TxtSearch.Text & "%")
        LaodGrid("SELECT * FROM student_table WHERE studentID LIKE @item OR student_full_name LIKE @item;")

        'to select only last name 
        ' LaodGrid("SELECT student_last_name FROM student_table WHERE studentID LIKE @item OR student_full_name LIKE @item;")


    End Sub
    'MAIN MACHINE
    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'LODING FIRST FORM WILL ADDD USER PORTAL FIRST
        ' MdiParent = Form1
        'Form1.Show()
        'LOAD THE CHILD
        LaodGrid()
        'LOAD COMBO BOX TEST WITH CLASS ID
        LoadCBX()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Finditem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DG1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG1.CellContentClick

    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged

    End Sub
End Class