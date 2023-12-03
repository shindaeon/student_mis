Public Class frmEdit
    Public Sub addCombo()
        'add item for college
        cboEditCollege.Items.Add("College of Agriculture")
        cboEditCollege.Items.Add("College of Arts and Sciences")

        'add item for course
        cboEditCourse.Items.Add("Bachelor of Science in Information Technology")
        cboEditCourse.Items.Add("Bachelor of Science in Computer Science")

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            DBConnect()
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "UPDATE tblstudent SET student_id = '" & txtEditID.Text.ToString & "', name = '" & txtEditName.Text.ToString & "', college = '" & cboEditCollege.Text.ToString & "', course = '" & cboEditCourse.Text.ToString & "' WHERE student_id = '" & txtEditID.Text.ToString & "';"
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
End Class