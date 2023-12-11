Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmPrint
    Public Function getDataTable(ByVal sql As String) As DataTable
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            DBConnect()
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DBClose()
            Return dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            DBClose()
        End Try
        Return (Nothing)
    End Function

    Public Sub printData()
        DBConnect()
        Me.ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"

        Dim dtClass As DataTable = getDataTable("SELECT student_id, name, age, gender, phone_number, address, college, course FROM `tblstudent`;")

        Dim dataSource As ReportDataSource = New ReportDataSource("DataSet1", dtClass)
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(dataSource)
        DBClose()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.RefreshReport()
    End Sub

    Public Sub printFilteredData()
        DBConnect()
        Me.ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"

        Dim dtClass As DataTable = getDataTable("SELECT * FROM tblstudent WHERE student_id LIKE '%" &
            txtFilter.Text & "%' OR name LIKE '%" & txtFilter.Text & "%' OR age LIKE '%" &
            txtFilter.Text & "%' OR gender LIKE '%" & txtFilter.Text & "%' OR phone_number LIKE '%" &
            txtFilter.Text & "%' OR address LIKE '%" & txtFilter.Text & "%' OR college LIKE '%" &
            txtFilter.Text & "%' OR course LIKE '%" & txtFilter.Text & "%';")

        Dim dataSource As ReportDataSource = New ReportDataSource("DataSet1", dtClass)
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(dataSource)
        DBClose()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printData()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdFilter_Click(sender As Object, e As EventArgs) Handles cmdFilter.Click
        printFilteredData()
    End Sub
End Class