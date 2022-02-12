Imports MySql.Data.MySqlClient
Public MustInherit Class ClienteMySQL
    Protected Function obtenerConexion(CadenaConexion As String) As MySqlConnection
        Return _
            New MySqlConnection(CadenaConexion)
    End Function
End Class
