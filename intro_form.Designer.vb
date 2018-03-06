<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class intro_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(intro_form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.loginButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Location = New System.Drawing.Point(618, 423)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(117, 200)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(105, 36)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "USERNAME"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(117, 153)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(346, 22)
        Me.txtpassword.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(117, 76)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(346, 22)
        Me.txtUser.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(32, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(523, 154)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'intro_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1775, 790)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "intro_form"
        Me.Text = "intro_form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
