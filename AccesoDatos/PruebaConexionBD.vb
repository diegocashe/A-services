Public Class PruebaConexionBD
    Inherits ClienteMySQL
    Public Function Pineo() As Boolean
        Using conexion = obtenerConexion("server=127.0.0.1;database=test;user id=root;password=;") 'My.Settings.CadenaConexionPrueba
            Try
                conexion.open()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function
End Class
