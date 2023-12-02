Public Class frmAddStudent
    Private Sub addCombo()
        'add item for college
        cboCollege.Items.Add("College of Agriculture")
        cboCollege.Items.Add("College of Arts and Sciences")

        cboCollege.SelectedIndex = 0

        'add item for course
        cboCourse.Items.Add("Bachelor of Science in Information Technology")
        cboCourse.Items.Add("Bachelor of Science in Computer Science")

        cboCourse.SelectedIndex = 0

    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill combo boxes / load
        addCombo()
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        DBConnect()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO tblstudent (student_id, name, college, course) VALUES (@p1, @p2, @p3, @p4);"
        cmd.Parameters.AddWithValue("@p1", txtID.Text.ToString)
        cmd.Parameters.AddWithValue("@p2", txtName.Text.ToString)
        cmd.Parameters.AddWithValue("@p3", cboCollege.Text.ToString)
        cmd.Parameters.AddWithValue("@p4", cboCourse.Text.ToString)

        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd.Dispose()
        DBClose()

        MessageBox.Show("Successfully Added to Database", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        Me.Dispose()

    End Sub

End Class