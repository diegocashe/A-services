Imports MySql.Data.MySqlClient

Public Class SolicitudesYAsistencias
    Inherits ClienteMySQL
    Public Function InsertarSolicitud(idEmpleado As String, tipofalla As String, descripcion As String) As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `solicitudes` (`ID_SOLICITUD`, `USUARIO_ID`, `FECHA_EMISION`, `TIPO_FALLA`, `DESCRIPCION`) VALUES (NULL, '" & idEmpleado & "', now(), '" & tipofalla & "', '" & descripcion & "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function InsertarAsistencia(tipo As String, accion As String, idsolicitud As String, IdTecnico As String, servicio As String, descripcion As String) As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `asistencias` (`ID_ASISTENCIAS`, `FECHA_ASISTENCIA`, `TIPO`, `ACCION`, `ID_SOLICITUD`, `ID_TECNICO`, `SERVICIO`, `DESCRIPCION`) VALUES (NULL, now(), '" & tipo & "', '" & accion & "', '" & idsolicitud & "', '" & IdTecnico & "', '" & servicio & "', '" & descripcion & "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function

End Class
