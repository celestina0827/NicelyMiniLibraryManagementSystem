Imports MySql.Data.MySqlClient

Module DBConnection
    Public ConnectionString As String = "server=localhost;user id=root;password=;database=nicelymini"
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module