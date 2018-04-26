<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coursedetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(coursedetails))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Labelle42dd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridStudentview = New System.Windows.Forms.DataGridView()
        Me.ButtonPatient = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridStudentview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(372, 256)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(1759, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 21)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Welcome"
        '
        'Labelle42dd
        '
        Me.Labelle42dd.AutoSize = True
        Me.Labelle42dd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelle42dd.ForeColor = System.Drawing.Color.DarkBlue
        Me.Labelle42dd.Location = New System.Drawing.Point(1715, 179)
        Me.Labelle42dd.Name = "Labelle42dd"
        Me.Labelle42dd.Size = New System.Drawing.Size(0, 32)
        Me.Labelle42dd.TabIndex = 67
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(1696, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 127)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(1763, 976)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 37)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridStudentview
        '
        Me.DataGridStudentview.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridStudentview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridStudentview.Location = New System.Drawing.Point(490, 179)
        Me.DataGridStudentview.Name = "DataGridStudentview"
        Me.DataGridStudentview.RowTemplate.Height = 24
        Me.DataGridStudentview.Size = New System.Drawing.Size(1088, 414)
        Me.DataGridStudentview.TabIndex = 70
        '
        'ButtonPatient
        '
        Me.ButtonPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonPatient.Location = New System.Drawing.Point(1438, 599)
        Me.ButtonPatient.Name = "ButtonPatient"
        Me.ButtonPatient.Size = New System.Drawing.Size(140, 37)
        Me.ButtonPatient.TabIndex = 71
        Me.ButtonPatient.Text = "Refresh schedule"
        Me.ButtonPatient.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightBlue
        Me.Button2.Location = New System.Drawing.Point(244, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 37)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Buy Book"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightBlue
        Me.Button3.Location = New System.Drawing.Point(244, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 37)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "Course Syllabus"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'coursedetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1914, 1045)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonPatient)
        Me.Controls.Add(Me.DataGridStudentview)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Labelle42dd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "coursedetails"
        Me.Text = "studentGrading"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridStudentview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Labelle42dd As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridStudentview As DataGridView
    Friend WithEvents ButtonPatient As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
