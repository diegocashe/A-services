Imports MySql.Data.MySqlClient
Imports Comun
Imports AccesoDatos
Public Class Logs
    Inherits ClienteMySQL
    Public Function Ingresar(user As String, pass As String) As Boolean
        Using conexionPrueba = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexionPrueba.open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.Connection = conexionPrueba
                comandoMySql.CommandText = "SELECT * FROM `cuentasconrol` WHERE USER = '" + user + "' AND PASSWORD = '" + pass + "'"
                comandoMySql.CommandType = CommandType.Text
                Dim lector = comandoMySql.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        'agregar los datos que necesito del usuario y enviarlos al modulo UruarioActual
                        Usuario = lector.GetString(0)
                        Rol = lector.GetString(2)
                    End While
                    '' el otro using para mas datos
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function




End Class
