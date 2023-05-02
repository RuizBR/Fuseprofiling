Imports System.Data.OleDb

Module dbconnection
    'if the provider is not register on local machine try to chage the provide into Microsoft.ACE.OLEDB.12.0 or Microsoft.Jet.OLEDB.4.0
    Public Class DatabaseConnection
        Public Shared Function GetConnection() As OleDbConnection
            ' database connection and setting up
            Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\fusedata.accdb"
            Dim conn As New OleDbConnection(connStr)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
            Return conn
        End Function
    End Class
End Module