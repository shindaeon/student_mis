Imports MySql.Data.MySqlClient
Module ModGlobal
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable

    Public Function Connect(ByVal Host As String, ByVal Port As String, ByVal User As String, ByVal Password As String, ByVal Database As String) As String
        Return "Server = '" & Host & "'; port ='" & Port & "'; user id ='" & User & "'; password ='" & Password & "'; database ='" & Database & "';"

    End Function

    Public Sub DBConnect()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening the connection.")
        End Try
    End Sub

    Public Sub DBClose()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error closing the connection.")
        End Try
    End Sub
End Module
