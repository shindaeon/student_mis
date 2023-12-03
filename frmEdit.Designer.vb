<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.txtEditID = New System.Windows.Forms.TextBox()
        Me.lbCourse = New System.Windows.Forms.Label()
        Me.lbCollege = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cboEditCollege = New System.Windows.Forms.ComboBox()
        Me.cboEditCourse = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(322, 192)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 34)
        Me.cmdCancel.TabIndex = 19
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(241, 192)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 34)
        Me.cmdUpdate.TabIndex = 18
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'txtEditName
        '
        Me.txtEditName.Location = New System.Drawing.Point(105, 67)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(292, 26)
        Me.txtEditName.TabIndex = 17
        '
        'txtEditID
        '
        Me.txtEditID.Location = New System.Drawing.Point(104, 31)
        Me.txtEditID.Name = "txtEditID"
        Me.txtEditID.Size = New System.Drawing.Size(293, 26)
        Me.txtEditID.TabIndex = 16
        '
        'lbCourse
        '
        Me.lbCourse.AutoSize = True
        Me.lbCourse.Location = New System.Drawing.Point(42, 135)
        Me.lbCourse.Name = "lbCourse"
        Me.lbCourse.Size = New System.Drawing.Size(56, 20)
        Me.lbCourse.TabIndex = 13
        Me.lbCourse.Text = "Course:"
        '
        'lbCollege
        '
        Me.lbCollege.AutoSize = True
        Me.lbCollege.Location = New System.Drawing.Point(38, 103)
        Me.lbCollege.Name = "lbCollege"
        Me.lbCollege.Size = New System.Drawing.Size(60, 20)
        Me.lbCollege.TabIndex = 12
        Me.lbCollege.Text = "College:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(51, 70)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(48, 20)
        Me.lbName.TabIndex = 11
        Me.lbName.Text = "Name:"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(24, 34)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(74, 20)
        Me.lbID.TabIndex = 10
        Me.lbID.Text = "Student ID:"
        '
        'cboEditCollege
        '
        Me.cboEditCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditCollege.FormattingEnabled = True
        Me.cboEditCollege.Location = New System.Drawing.Point(104, 101)
        Me.cboEditCollege.Name = "cboEditCollege"
        Me.cboEditCollege.Size = New System.Drawing.Size(293, 28)
        Me.cboEditCollege.TabIndex = 20
        '
        'cboEditCourse
        '
        Me.cboEditCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditCourse.FormattingEnabled = True
        Me.cboEditCourse.Location = New System.Drawing.Point(104, 132)
        Me.cboEditCourse.Name = "cboEditCourse"
        Me.cboEditCourse.Size = New System.Drawing.Size(293, 28)
        Me.cboEditCourse.TabIndex = 21
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 243)
        Me.Controls.Add(Me.cboEditCourse)
        Me.Controls.Add(Me.cboEditCollege)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtEditName)
        Me.Controls.Add(Me.txtEditID)
        Me.Controls.Add(Me.lbCourse)
        Me.Controls.Add(Me.lbCollege)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbID)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEdit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents txtEditID As TextBox
    Friend WithEvents lbCourse As Label
    Friend WithEvents lbCollege As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbID As Label
    Friend WithEvents cboEditCollege As ComboBox
    Friend WithEvents cboEditCourse As ComboBox
End Class
