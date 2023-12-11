Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmMain
    Dim da As New MySqlDataAdapter

    Public Sub loadData()
        Dim dt As New DataTable
        DBConnect()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM tblstudent;"
        cmd.ExecuteNonQuery()

        da = New MySqlDataAdapter(cmd)
        dt.Clear()

        da.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        'hide the id of the student to the screen
        DataGridView1.Columns.Item(0).Visible = False

        If DataGridView1.Rows.Count = 0 Then
            cmdDelete.Enabled = False
        End If

        cmd.Parameters.Clear()
        cmd.Dispose()
        da.Dispose()
        DBClose()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub checkSelectedCell()
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please Select A Row First", "Select A Row", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEdit.Hide()

        ElseIf DataGridView1.SelectedRows.Count = 1 Then
            frmEdit.ShowDialog()

        ElseIf DataGridView1.SelectedRows.Count > 1 Then
            MessageBox.Show("Selected More Than One Rows " & vbCrLf & "Please Select Only One Row.", "Too Many Rows", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEdit.Hide()
        End If
    End Sub

    Public Sub loadSearchData()
        Dim dt As New DataTable
        DBConnect()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM tblstudent WHERE student_id LIKE '%" &
            txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%' OR age LIKE '%" &
            txtSearch.Text & "%' OR gender LIKE '%" & txtSearch.Text & "%' OR phone_number LIKE '%" &
            txtSearch.Text & "%' OR address LIKE '%" & txtSearch.Text & "%' OR college LIKE '%" &
            txtSearch.Text & "%' OR course LIKE '%" & txtSearch.Text & "%';"
        cmd.ExecuteNonQuery()

        da = New MySqlDataAdapter(cmd)
        dt.Clear()

        da.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        'hide the id of the student to the screen
        DataGridView1.Columns.Item(0).Visible = False
        DataGridView1.ClearSelection()
        cmd.Parameters.Clear()
        cmd.Dispose()
        da.Dispose()
        DBClose()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Dispose()
        DBClose()
        loadData()
        frmEdit.addCombo()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        frmAddStudent.ShowDialog()
        loadData()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        frmPrint.ShowDialog()
        frmPrint.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        checkSelectedCell()
        loadData()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim answer As Integer
        answer = MsgBox("DO YOU WANT TO DELETE THE RECORD OF: " & vbCrLf &
                        vbTab & frmEdit.txtEditID.Text & vbCrLf &
                        vbTab & frmEdit.txtEditName.Text & vbCrLf &
                        vbTab & frmEdit.cboEditCollege.Text & vbCrLf &
                        vbTab & frmEdit.cboEditCourse.Text, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Record")
        Try
            If answer = vbYes Then
                DBConnect()
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM tblstudent WHERE student_id = '" & frmEdit.txtEditID.Text & "';"
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                DBClose()
                MessageBox.Show("Successfully Deleted Record", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cancelled", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        loadData()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Try
            loadSearchData()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        frmEdit.txtEditID.Text = DataGridView1.Item("Column1", DataGridView1.CurrentRow.Index).Value
        frmEdit.txtEditName.Text = DataGridView1.Item("Column2", DataGridView1.CurrentRow.Index).Value
        frmEdit.txtEditAge.Text = DataGridView1.Item("Column3", DataGridView1.CurrentRow.Index).Value
        frmEdit.cboEditGender.Text = DataGridView1.Item("Column4", DataGridView1.CurrentRow.Index).Value
        frmEdit.txtEditPhone.Text = DataGridView1.Item("Column5", DataGridView1.CurrentRow.Index).Value
        frmEdit.txtEditAddress.Text = DataGridView1.Item("Column6", DataGridView1.CurrentRow.Index).Value
        frmEdit.cboEditCollege.Text = DataGridView1.Item("Column7", DataGridView1.CurrentRow.Index).Value
        frmEdit.cboEditCourse.Text = DataGridView1.Item("Column8", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtSearch.Text = "" Then
                loadData()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class