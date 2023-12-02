<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbCollege = New System.Windows.Forms.Label()
        Me.lbCourse = New System.Windows.Forms.Label()
        Me.cboCollege = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(19, 34)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(74, 20)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "Student ID:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(46, 70)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(48, 20)
        Me.lbName.TabIndex = 1
        Me.lbName.Text = "Name:"
        '
        'lbCollege
        '
        Me.lbCollege.AutoSize = True
        Me.lbCollege.Location = New System.Drawing.Point(33, 103)
        Me.lbCollege.Name = "lbCollege"
        Me.lbCollege.Size = New System.Drawing.Size(60, 20)
        Me.lbCollege.TabIndex = 2
        Me.lbCollege.Text = "College:"
        '
        'lbCourse
        '
        Me.lbCourse.AutoSize = True
        Me.lbCourse.Location = New System.Drawing.Point(37, 135)
        Me.lbCourse.Name = "lbCourse"
        Me.lbCourse.Size = New System.Drawing.Size(56, 20)
        Me.lbCourse.TabIndex = 3
        Me.lbCourse.Text = "Course:"
        '
        'cboCollege
        '
        Me.cboCollege.BackColor = System.Drawing.SystemColors.Window
        Me.cboCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCollege.FormattingEnabled = True
        Me.cboCollege.Location = New System.Drawing.Point(99, 100)
        Me.cboCollege.Name = "cboCollege"
        Me.cboCollege.Size = New System.Drawing.Size(293, 28)
        Me.cboCollege.TabIndex = 4
        '
        'cboCourse
        '
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(99, 132)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(293, 28)
        Me.cboCourse.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(99, 31)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(293, 26)
        Me.txtID.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(100, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 26)
        Me.txtName.TabIndex = 7
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(236, 192)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 34)
        Me.cmdSubmit.TabIndex = 8
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(317, 192)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 34)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 245)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.cboCollege)
        Me.Controls.Add(Me.lbCourse)
        Me.Controls.Add(Me.lbCollege)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbID)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbID As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbCollege As Label
    Friend WithEvents lbCourse As Label
    Friend WithEvents cboCollege As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents cmdCancel As Button
End Class
