<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gradereport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gradereport))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridPatientx = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Labelle42FF = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtSearch100s = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        CType(Me.DataGridPatientx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SpringGreen
        Me.Button2.Location = New System.Drawing.Point(177, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "All Course Grade"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridPatientx
        '
        Me.DataGridPatientx.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridPatientx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPatientx.Location = New System.Drawing.Point(353, 392)
        Me.DataGridPatientx.Name = "DataGridPatientx"
        Me.DataGridPatientx.RowTemplate.Height = 24
        Me.DataGridPatientx.Size = New System.Drawing.Size(1340, 567)
        Me.DataGridPatientx.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(965, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 30)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "My Grades"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.Location = New System.Drawing.Point(1755, 1021)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(109, 37)
        Me.Button7.TabIndex = 64
        Me.Button7.Text = "EXIT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(418, 256)
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(1753, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 21)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Welcome"
        '
        'Labelle42FF
        '
        Me.Labelle42FF.AutoSize = True
        Me.Labelle42FF.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelle42FF.ForeColor = System.Drawing.Color.DarkBlue
        Me.Labelle42FF.Location = New System.Drawing.Point(1709, 220)
        Me.Labelle42FF.Name = "Labelle42FF"
        Me.Labelle42FF.Size = New System.Drawing.Size(0, 32)
        Me.Labelle42FF.TabIndex = 67
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(1690, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 127)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.Location = New System.Drawing.Point(177, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 37)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Grade By Course"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtSearch100s
        '
        Me.TxtSearch100s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch100s.Location = New System.Drawing.Point(361, 363)
        Me.TxtSearch100s.Name = "TxtSearch100s"
        Me.TxtSearch100s.Size = New System.Drawing.Size(173, 22)
        Me.TxtSearch100s.TabIndex = 81
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(555, 363)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(104, 23)
        Me.cmdSearch.TabIndex = 80
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'gradereport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1932, 1092)
        Me.Controls.Add(Me.TxtSearch100s)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Labelle42FF)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridPatientx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gradereport"
        Me.Text = "gradereport"
        CType(Me.DataGridPatientx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridPatientx As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Labelle42FF As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtSearch100s As TextBox
    Friend WithEvents cmdSearch As Button
End Class
