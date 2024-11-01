Imports MySql.Data.MySqlClient

Public Class Database
    Private ConnectionString As String = "Server=localhost;Database=biblioteca;Uid=root;Pwd=admin;"

    Public Function ExecuteQuery(query As String, params As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                For Each param As KeyValuePair(Of String, Object) In params
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function
End Class
