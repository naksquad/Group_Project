Imports System.Data.SqlClient
Public Class receptionistADD

    Public SQL As New SQLControl
    Public MyUserNo As String
    Public passlesfistname As String
    Public passlesuserlastname As String
    Public passlesuserID As String
    Public lespacer As String = " "
    'Public UserNo As String
    Public Sub New(ByVal lesfistname, leslastname, userName)

        InitializeComponent()
        Me.Label5ddj.Text = lesfistname + lespacer + leslastname
        'Me.Label6.Text = leslastname

        passlesfistname = lesfistname
        passlesuserlastname = leslastname
        passlesuserID = userName

        'receptionistADD.MyUserNo = lesfistname
    End Sub

    Public Sub LaodGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT user_id AS Student_ID FROM user_table;")
        Else
            SQL.ExecQuery(Query)
        End If

        'catch error
        If Sql.HasException(True) Then Exit Sub
        DataGridPatient.DataSource = SQL.DBDT
    End Sub


    Private Sub receptionistADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        cbxItems.Items.Clear()
        cbxItems.Items.Add("StudentID")
        cbxItems.Items.Add("First Name")
        cbxItems.Items.Add("Last Name")
        cbxItems.Items.Add("Gender")
        cbxItems.Items.Add("DOB")
        cbxItems.Items.Add("Contact")
        cbxItems.Items.Add("Address")
        cbxItems.Items.Add("Title")
        cbxItems.Items.Add("Email")

    End Sub


    Private Sub enterPatient()


        Dim query As String = String.Empty
        query &= "INSERT INTO user_table (user_id, user_FName, user_LName, user_Sex, user_Dob, user_contact, user_Address, user_password, user_title, user_email)"
        query &= "VALUES (@ID, @FirstName, @LastName, @Sex, @Dob, @Contact, @Address, @Password, @TITRE, @EMAIL)"

        Using conn As New SqlConnection("Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=lecole;Trusted_Connection=True;")
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID", text_patientid.Text)
                    .Parameters.AddWithValue("@FirstName", text_patientlastname.Text)
                    .Parameters.AddWithValue("@LastName", text_patientfirstname.Text)
                    .Parameters.AddWithValue("@Sex", text_patientsex.Text)
                    .Parameters.AddWithValue("@Dob", text_patientDob.Text)
                    .Parameters.AddWithValue("@Address", text_patientadress.Text)
                    .Parameters.AddWithValue("@Contact", text_patientcontact.Text)
                    .Parameters.AddWithValue("@Password", text_patientpassword.Text)
                    .Parameters.AddWithValue("@TITRE", TextBoxtitle.Text)
                    .Parameters.AddWithValue("@EMAIL", TextBoxmail.Text)


                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        text_patientid.Text = ""
        text_patientlastname.Text = ""
        text_patientfirstname.Text = ""
        text_patientsex.Text = ""
        text_patientDob.Text = ""
        text_patientadress.Text = ""
        text_patientcontact.Text = ""
        text_patientpassword.Text = ""
        TextBoxtitle.Text = ""
        TextBoxmail.Text = ""

    End Sub


    'combobox
    Private Sub LoadCBX()
        'clear combo box first
        cbxItems.Items.Clear()
        SQL.ExecQuery("SELECT patient_id FROM Patient;")

        If SQL.HasException(True) Then Exit Sub
        'loop the row and add to combo box
        For Each r As DataRow In SQL.DBDT.Rows
            cbxItems.Items.Add(r("patient_id").ToString)

        Next
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        enterPatient()

        LaodGrid()
    End Sub

    Private Sub ButtonPatient_Click(sender As Object, e As EventArgs) Handles ButtonPatient.Click
        LaodGrid()
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        ' Dim myreceptionistForms As New Form2(MyUserNo)
        ' myreceptionistForms.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        text_patientid.Text = ""
        text_patientlastname.Text = ""
        text_patientfirstname.Text = ""
        text_patientsex.Text = ""
        text_patientDob.Text = ""
        text_patientadress.Text = ""
        text_patientcontact.Text = ""
        text_patientpassword.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LaodGrid()
    End Sub
End Class

