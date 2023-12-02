Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim da As New MySqlDataAdapter

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
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("List of Students", New Font("Arial", 20, FontStyle.Bold),
                              Brushes.Black, New Point(400, 20), format)

    End Sub
End Class