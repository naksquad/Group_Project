<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrolledcourse
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DataGridPatient = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.Location = New System.Drawing.Point(1799, 984)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 37)
        Me.ExitButton.TabIndex = 25
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DataGridPatient
        '
        Me.DataGridPatient.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPatient.Location = New System.Drawing.Point(302, 12)
        Me.DataGridPatient.Name = "DataGridPatient"
        Me.DataGridPatient.RowTemplate.Height = 24
        Me.DataGridPatient.Size = New System.Drawing.Size(1088, 414)
        Me.DataGridPatient.TabIndex = 30
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SpringGreen
        Me.Button2.Location = New System.Drawing.Point(469, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 37)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "View Course list"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.Location = New System.Drawing.Point(292, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 37)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "View Course list"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'enrolledcourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1914, 1045)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridPatient)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "enrolledcourse"
        Me.Text = "enrolledcourse"
        CType(Me.DataGridPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents DataGridPatient As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
