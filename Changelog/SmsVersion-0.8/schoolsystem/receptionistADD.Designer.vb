<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class receptionistADD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(receptionistADD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_patientid = New System.Windows.Forms.TextBox()
        Me.text_patientlastname = New System.Windows.Forms.TextBox()
        Me.text_patientfirstname = New System.Windows.Forms.TextBox()
        Me.text_patientsex = New System.Windows.Forms.TextBox()
        Me.text_patientDob = New System.Windows.Forms.TextBox()
        Me.text_patientadress = New System.Windows.Forms.TextBox()
        Me.text_patientcontact = New System.Windows.Forms.TextBox()
        Me.text_patientpassword = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DataGridPatient = New System.Windows.Forms.DataGridView()
        Me.ButtonPatient = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.TextBoxmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxtitle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5ddj = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Last Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 505)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student First Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Student ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 561)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Student Sex :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 625)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Student Dob :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 677)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Student Address :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 728)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Student Contact :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(283, 876)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Student Password :"
        '
        'text_patientid
        '
        Me.text_patientid.Location = New System.Drawing.Point(426, 387)
        Me.text_patientid.Name = "text_patientid"
        Me.text_patientid.Size = New System.Drawing.Size(189, 22)
        Me.text_patientid.TabIndex = 1
        '
        'text_patientlastname
        '
        Me.text_patientlastname.Location = New System.Drawing.Point(426, 445)
        Me.text_patientlastname.Name = "text_patientlastname"
        Me.text_patientlastname.Size = New System.Drawing.Size(189, 22)
        Me.text_patientlastname.TabIndex = 1
        '
        'text_patientfirstname
        '
        Me.text_patientfirstname.Location = New System.Drawing.Point(426, 502)
        Me.text_patientfirstname.Name = "text_patientfirstname"
        Me.text_patientfirstname.Size = New System.Drawing.Size(189, 22)
        Me.text_patientfirstname.TabIndex = 1
        '
        'text_patientsex
        '
        Me.text_patientsex.Location = New System.Drawing.Point(426, 556)
        Me.text_patientsex.Name = "text_patientsex"
        Me.text_patientsex.Size = New System.Drawing.Size(189, 22)
        Me.text_patientsex.TabIndex = 1
        '
        'text_patientDob
        '
        Me.text_patientDob.Location = New System.Drawing.Point(426, 620)
        Me.text_patientDob.Name = "text_patientDob"
        Me.text_patientDob.Size = New System.Drawing.Size(189, 22)
        Me.text_patientDob.TabIndex = 1
        '
        'text_patientadress
        '
        Me.text_patientadress.Location = New System.Drawing.Point(426, 672)
        Me.text_patientadress.Name = "text_patientadress"
        Me.text_patientadress.Size = New System.Drawing.Size(336, 22)
        Me.text_patientadress.TabIndex = 1
        '
        'text_patientcontact
        '
        Me.text_patientcontact.Location = New System.Drawing.Point(426, 723)
        Me.text_patientcontact.Name = "text_patientcontact"
        Me.text_patientcontact.Size = New System.Drawing.Size(189, 22)
        Me.text_patientcontact.TabIndex = 1
        '
        'text_patientpassword
        '
        Me.text_patientpassword.Location = New System.Drawing.Point(426, 871)
        Me.text_patientpassword.Name = "text_patientpassword"
        Me.text_patientpassword.Size = New System.Drawing.Size(189, 22)
        Me.text_patientpassword.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Location = New System.Drawing.Point(541, 974)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 37)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.loginButton.Location = New System.Drawing.Point(334, 974)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(107, 37)
        Me.loginButton.TabIndex = 15
        Me.loginButton.Text = "Enter"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.Location = New System.Drawing.Point(1782, 1010)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 37)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DataGridPatient
        '
        Me.DataGridPatient.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridPatient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPatient.Location = New System.Drawing.Point(951, 386)
        Me.DataGridPatient.Name = "DataGridPatient"
        Me.DataGridPatient.RowTemplate.Height = 24
        Me.DataGridPatient.Size = New System.Drawing.Size(219, 582)
        Me.DataGridPatient.TabIndex = 18
        '
        'ButtonPatient
        '
        Me.ButtonPatient.BackColor = System.Drawing.Color.Crimson
        Me.ButtonPatient.ForeColor = System.Drawing.Color.Black
        Me.ButtonPatient.Location = New System.Drawing.Point(1271, 476)
        Me.ButtonPatient.Name = "ButtonPatient"
        Me.ButtonPatient.Size = New System.Drawing.Size(140, 37)
        Me.ButtonPatient.TabIndex = 19
        Me.ButtonPatient.Text = "Update Student"
        Me.ButtonPatient.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Location = New System.Drawing.Point(982, 974)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 37)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Refresh student list"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbxItems
        '
        Me.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(1271, 412)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(189, 24)
        Me.cbxItems.TabIndex = 23
        '
        'TextBoxmail
        '
        Me.TextBoxmail.Location = New System.Drawing.Point(426, 770)
        Me.TextBoxmail.Name = "TextBoxmail"
        Me.TextBoxmail.Size = New System.Drawing.Size(189, 22)
        Me.TextBoxmail.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(283, 775)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "student Email :"
        '
        'TextBoxtitle
        '
        Me.TextBoxtitle.Location = New System.Drawing.Point(426, 822)
        Me.TextBoxtitle.Name = "TextBoxtitle"
        Me.TextBoxtitle.Size = New System.Drawing.Size(189, 22)
        Me.TextBoxtitle.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(283, 827)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Student Title :"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(372, 256)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(1739, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 21)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Welcome"
        '
        'Label5ddj
        '
        Me.Label5ddj.AutoSize = True
        Me.Label5ddj.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5ddj.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5ddj.Location = New System.Drawing.Point(1707, 225)
        Me.Label5ddj.Name = "Label5ddj"
        Me.Label5ddj.Size = New System.Drawing.Size(0, 32)
        Me.Label5ddj.TabIndex = 39
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox6.Location = New System.Drawing.Point(1679, 44)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(206, 141)
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(1466, 415)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 17)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Select Detail to Update"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1271, 448)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 22)
        Me.TextBox1.TabIndex = 42
        '
        'receptionistADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1932, 1092)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5ddj)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TextBoxtitle)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPatient)
        Me.Controls.Add(Me.DataGridPatient)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.text_patientpassword)
        Me.Controls.Add(Me.text_patientcontact)
        Me.Controls.Add(Me.text_patientadress)
        Me.Controls.Add(Me.text_patientDob)
        Me.Controls.Add(Me.text_patientsex)
        Me.Controls.Add(Me.text_patientfirstname)
        Me.Controls.Add(Me.text_patientlastname)
        Me.Controls.Add(Me.text_patientid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "receptionistADD"
        Me.Text = "receptionistADD"
        CType(Me.DataGridPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents text_patientid As TextBox
    Friend WithEvents text_patientlastname As TextBox
    Friend WithEvents text_patientfirstname As TextBox
    Friend WithEvents text_patientsex As TextBox
    Friend WithEvents text_patientDob As TextBox
    Friend WithEvents text_patientadress As TextBox
    Friend WithEvents text_patientcontact As TextBox
    Friend WithEvents text_patientpassword As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents loginButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DataGridPatient As DataGridView
    Friend WithEvents ButtonPatient As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents TextBoxmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxtitle As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5ddj As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
