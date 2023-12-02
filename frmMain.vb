Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim da As New MySqlDataAdapter
    Private mRow As Integer = 0
    Private newPage As Boolean = True

    Private Sub loadData()
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
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Paper Size Name", 936, 612)
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("List of Students", New Font("Arial", 20, FontStyle.Bold),
                              Brushes.Black, New Point(468, 20), format)
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter

        Dim y As Integer = 100
        Dim x As Integer = 150
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow

        If newPage Then
            row = DataGridView1.Rows(mRow)
            x = 1
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        newPage = False
        Dim displayNow As Integer
        For displayNow = mRow To DataGridView1.RowCount - 1
            row = DataGridView1.Rows(displayNow)
            x = 150
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                          DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        Next
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        frmEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        frmEdit.txtEditID.Text = DataGridView1.Item("Column1", DataGridView1.CurrentRow.Index).Value
        frmEdit.txtEditName.Text = DataGridView1.Item("Column2", DataGridView1.CurrentRow.Index).Value
        frmEdit.cboEditCollege.Text = DataGridView1.Item("Column3", DataGridView1.CurrentRow.Index).Value
        frmEdit.cboEditCourse.Text = DataGridView1.Item("Column4", DataGridView1.CurrentRow.Index).Value

    End Sub
End Class