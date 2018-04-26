<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student
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
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(199, 33)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(92, 23)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.Location = New System.Drawing.Point(24, 35)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(154, 22)
        Me.TxtSearch.TabIndex = 1
        '
        'DG1
        '
        Me.DG1.AllowUserToAddRows = False
        Me.DG1.AllowUserToDeleteRows = False
        Me.DG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(7, 89)
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        Me.DG1.RowTemplate.Height = 24
        Me.DG1.Size = New System.Drawing.Size(1776, 753)
        Me.DG1.TabIndex = 2
        '
        'cbxItems
        '
        Me.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(365, 32)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(323, 24)
        Me.cbxItems.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1725, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1795, 854)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "student"
        Me.Text = "student"
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents Button1 As Button
End Class
