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
        Me.lbCourse = New System.Windows.Forms.Label()
        Me.lbCollege = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cboEditCollege = New System.Windows.Forms.ComboBox()
        Me.cboEditCourse = New System.Windows.Forms.ComboBox()
        Me.txtEditAddress = New System.Windows.Forms.TextBox()
        Me.txtEditPhone = New System.Windows.Forms.TextBox()
        Me.cboEditGender = New System.Windows.Forms.ComboBox()
        Me.txtEditAge = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtEditID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(336, 324)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 34)
        Me.cmdCancel.TabIndex = 19
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(255, 324)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 34)
        Me.cmdUpdate.TabIndex = 18
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'txtEditName
        '
        Me.txtEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditName.Location = New System.Drawing.Point(118, 64)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(292, 26)
        Me.txtEditName.TabIndex = 17
        '
        'lbCourse
        '
        Me.lbCourse.AutoSize = True
        Me.lbCourse.Location = New System.Drawing.Point(56, 267)
        Me.lbCourse.Name = "lbCourse"
        Me.lbCourse.Size = New System.Drawing.Size(56, 20)
        Me.lbCourse.TabIndex = 13
        Me.lbCourse.Text = "Course:"
        '
        'lbCollege
        '
        Me.lbCollege.AutoSize = True
        Me.lbCollege.Location = New System.Drawing.Point(52, 235)
        Me.lbCollege.Name = "lbCollege"
        Me.lbCollege.Size = New System.Drawing.Size(60, 20)
        Me.lbCollege.TabIndex = 12
        Me.lbCollege.Text = "College:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(64, 67)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(48, 20)
        Me.lbName.TabIndex = 11
        Me.lbName.Text = "Name:"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(37, 31)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(74, 20)
        Me.lbID.TabIndex = 10
        Me.lbID.Text = "Student ID:"
        '
        'cboEditCollege
        '
        Me.cboEditCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditCollege.FormattingEnabled = True
        Me.cboEditCollege.Location = New System.Drawing.Point(118, 233)
        Me.cboEditCollege.Name = "cboEditCollege"
        Me.cboEditCollege.Size = New System.Drawing.Size(293, 28)
        Me.cboEditCollege.TabIndex = 20
        '
        'cboEditCourse
        '
        Me.cboEditCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditCourse.FormattingEnabled = True
        Me.cboEditCourse.Location = New System.Drawing.Point(118, 264)
        Me.cboEditCourse.Name = "cboEditCourse"
        Me.cboEditCourse.Size = New System.Drawing.Size(293, 28)
        Me.cboEditCourse.TabIndex = 21
        '
        'txtEditAddress
        '
        Me.txtEditAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditAddress.Location = New System.Drawing.Point(116, 177)
        Me.txtEditAddress.Multiline = True
        Me.txtEditAddress.Name = "txtEditAddress"
        Me.txtEditAddress.Size = New System.Drawing.Size(291, 50)
        Me.txtEditAddress.TabIndex = 29
        '
        'txtEditPhone
        '
        Me.txtEditPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditPhone.Location = New System.Drawing.Point(117, 143)
        Me.txtEditPhone.MaxLength = 11
        Me.txtEditPhone.Name = "txtEditPhone"
        Me.txtEditPhone.Size = New System.Drawing.Size(292, 26)
        Me.txtEditPhone.TabIndex = 28
        '
        'cboEditGender
        '
        Me.cboEditGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditGender.FormattingEnabled = True
        Me.cboEditGender.Location = New System.Drawing.Point(331, 99)
        Me.cboEditGender.Name = "cboEditGender"
        Me.cboEditGender.Size = New System.Drawing.Size(78, 28)
        Me.cboEditGender.TabIndex = 27
        '
        'txtEditAge
        '
        Me.txtEditAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditAge.Location = New System.Drawing.Point(116, 99)
        Me.txtEditAge.MaxLength = 3
        Me.txtEditAge.Name = "txtEditAge"
        Me.txtEditAge.Size = New System.Drawing.Size(132, 26)
        Me.txtEditAge.TabIndex = 26
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(266, 105)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(58, 20)
        Me.lblGender.TabIndex = 25
        Me.lblGender.Text = "Gender:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(47, 180)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 20)
        Me.lblAddress.TabIndex = 24
        Me.lblAddress.Text = "Address:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(7, 143)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(103, 20)
        Me.lblPhone.TabIndex = 23
        Me.lblPhone.Text = "Phone Number:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(72, 105)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 20)
        Me.lblAge.TabIndex = 22
        Me.lblAge.Text = "Age:"
        '
        'txtEditID
        '
        Me.txtEditID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditID.Location = New System.Drawing.Point(118, 31)
        Me.txtEditID.MaxLength = 16
        Me.txtEditID.Name = "txtEditID"
        Me.txtEditID.Size = New System.Drawing.Size(289, 26)
        Me.txtEditID.TabIndex = 30
        '
        'frmEdit
        '
        Me.AcceptButton = Me.cmdUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(425, 376)
        Me.Controls.Add(Me.txtEditID)
        Me.Controls.Add(Me.txtEditAddress)
        Me.Controls.Add(Me.txtEditPhone)
        Me.Controls.Add(Me.cboEditGender)
        Me.Controls.Add(Me.txtEditAge)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.cboEditCourse)
        Me.Controls.Add(Me.cboEditCollege)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtEditName)
        Me.Controls.Add(Me.lbCourse)
        Me.Controls.Add(Me.lbCollege)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbID)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEdit"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents lbCourse As Label
    Friend WithEvents lbCollege As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbID As Label
    Friend WithEvents cboEditCollege As ComboBox
    Friend WithEvents cboEditCourse As ComboBox
    Friend WithEvents txtEditAddress As TextBox
    Friend WithEvents txtEditPhone As TextBox
    Friend WithEvents cboEditGender As ComboBox
    Friend WithEvents txtEditAge As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtEditID As TextBox
End Class
