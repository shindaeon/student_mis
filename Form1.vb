Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBClose()
            conn.ConnectionString = Connect(My.Settings.dbHost, My.Settings.dbPort, My.Settings.dbUsername, My.Settings.dbPassword, My.Settings.dbName)
            conn.Open()
            'MessageBox.Show("Connection Success!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error connecting to server.")
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmdLogIn_Click(sender As Object, e As EventArgs) Handles cmdLogIn.Click
        cmd.Connection = conn
        DBConnect()
        cmd.CommandText = $"SELECT userlogin('{tbUsername.Text.Trim}' , '{tbPassword.Text.Trim}');"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If dr(0).ToString = "YES" Then
                    MessageBox.Show("Welcome, " + tbUsername.Text.Trim, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmMain.Show()
                    Me.Hide()
                    Exit Sub
                Else
                    MessageBox.Show("Invalid username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End While
        Else
            MessageBox.Show("Invalid username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        dr.Close()
        cmd.Dispose()
        DBClose()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        End
    End Sub
End Class