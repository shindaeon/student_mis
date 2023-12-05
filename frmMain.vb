Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim da As New MySqlDataAdapter
    Private mRow As Integer = 0
    Private newPage As Boolean = True

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

        cmd.Parameters.Clear()
        cmd.Dispose()
        da.Dispose()
        DBClose()
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
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Letter (Landscape 150Dpi)", 1648, 1276)
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 0.75
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        e.Graphics.DrawString("List Of Students", New Font("Arial", 20, FontStyle.Bold), Brushes.Black, New Point(721, 20))
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 20, 70)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        frmEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim answer As Integer
        answer = MsgBox("Do YOU WANT To DELETE THE RECORD Of: " & vbCrLf &
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

        End Try
    End Sub
End Class