<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.miStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.msMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miStudent})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1803, 28)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'miStudent
        '
        Me.miStudent.Name = "miStudent"
        Me.miStudent.Size = New System.Drawing.Size(119, 24)
        Me.miStudent.Text = "student Report"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1728, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1803, 766)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.msMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents miStudent As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
