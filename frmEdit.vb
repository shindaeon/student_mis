Public Class frmEdit
    Public Sub addCombo()
        'add item for college
        cboEditCollege.Items.Add("College of Agriculture")
        cboEditCollege.Items.Add("College of Arts and Sciences")

        'add item for course
        cboEditCourse.Items.Add("Bachelor of Science in Information Technology")
        cboEditCourse.Items.Add("Bachelor of Science in Computer Science")

        'add item for gender
        cboEditGender.Items.Add("Male")
        cboEditGender.Items.Add("Female")

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            DBConnect()
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "UPDATE tblstudent SET student_id = '" & txtEditID.Text.ToString & "', name = '" & txtEditName.Text.ToString & "', college = '" & cboEditCollege.Text.ToString & "', course = '" & cboEditCourse.Text.ToString & "', age = '" & txtEditAge.Text.ToString & "', gender = '" & cboEditGender.Text.ToString & "', phone_number = '" & txtEditPhone.Text.ToString & "', address = '" & txtEditAddress.Text.ToString & "' WHERE student_id = '" & txtEditID.Text.ToString & "';"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            DBClose()
            MessageBox.Show("Successfully Updated Record", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmMain.loadData()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class