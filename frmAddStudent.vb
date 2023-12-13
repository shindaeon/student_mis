Public Class frmAddStudent
    Private Sub addCombo()
        'add item for college
        cboCollege.Items.Add("College of Agriculture")
        cboCollege.Items.Add("College of Arts and Sciences")

        cboCollege.SelectedIndex = -1

        'add item for course
        cboCourse.Items.Add("Bachelor of Science in Information Technology")
        cboCourse.Items.Add("Bachelor of Science in Computer Science")

        cboCourse.SelectedIndex = -1

        'add item for gender

        cboGender.Items.Add("Male")
        cboGender.Items.Add("Female")

        cboGender.SelectedIndex = -1

    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill combo boxes / load
        addCombo()
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        DBConnect()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO tblstudent (student_id, name, age, gender, phone_number, address, college, course) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8);"
        cmd.Parameters.AddWithValue("@p1", txtID.Text.ToString.Trim)
        cmd.Parameters.AddWithValue("@p2", txtName.Text.ToString.Trim)
        cmd.Parameters.AddWithValue("@p3", txtAge.Text.ToString.Trim)
        cmd.Parameters.AddWithValue("@p4", cboGender.Text.ToString.Trim)
        cmd.Parameters.AddWithValue("@p5", txtPhone.Text.ToString.Trim)
        cmd.Parameters.AddWithValue("@p6", txtAddress.Text.ToString.Trim)
        cmd.Parameters.AddWithValue("@p7", cboCollege.Text.ToString.Trim)
        cmd.Parameters.AddWithValue("@p8", cboCourse.Text.ToString.Trim)

        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd.Dispose()
        DBClose()

        MessageBox.Show("Successfully Added to Database", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub frmAddStudent_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        Me.Dispose()
    End Sub
End Class