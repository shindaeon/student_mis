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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(55, 44)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(74, 20)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "Student ID:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(82, 80)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(48, 20)
        Me.lbName.TabIndex = 1
        Me.lbName.Text = "Name:"
        '
        'lbCollege
        '
        Me.lbCollege.AutoSize = True
        Me.lbCollege.Location = New System.Drawing.Point(69, 249)
        Me.lbCollege.Name = "lbCollege"
        Me.lbCollege.Size = New System.Drawing.Size(60, 20)
        Me.lbCollege.TabIndex = 2
        Me.lbCollege.Text = "College:"
        '
        'lbCourse
        '
        Me.lbCourse.AutoSize = True
        Me.lbCourse.Location = New System.Drawing.Point(73, 281)
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
        Me.cboCollege.Location = New System.Drawing.Point(135, 246)
        Me.cboCollege.Name = "cboCollege"
        Me.cboCollege.Size = New System.Drawing.Size(293, 28)
        Me.cboCollege.TabIndex = 4
        '
        'cboCourse
        '
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(135, 278)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(293, 28)
        Me.cboCourse.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(135, 41)
        Me.txtID.MaxLength = 9
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(293, 26)
        Me.txtID.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(136, 77)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 26)
        Me.txtName.TabIndex = 7
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(298, 321)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 34)
        Me.cmdSubmit.TabIndex = 8
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(379, 321)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 34)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(91, 115)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 20)
        Me.lblAge.TabIndex = 10
        Me.lblAge.Text = "Age:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(26, 153)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(103, 20)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Phone Number:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(66, 190)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 20)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(285, 115)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(58, 20)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "Gender:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(135, 109)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(132, 26)
        Me.txtAge.TabIndex = 14
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(350, 109)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(78, 28)
        Me.cboGender.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(136, 153)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(292, 26)
        Me.txtPhone.TabIndex = 16
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(135, 187)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(291, 50)
        Me.txtAddress.TabIndex = 17
        '
        'frmAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 367)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAge)
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
    Friend WithEvents lblAge As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
End Class
