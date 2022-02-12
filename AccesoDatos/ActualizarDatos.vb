Imports MySql.Data.MySqlClient

Public Class ActualizarDatos
    Inherits ClienteMySQL

    Public Function ActualizarPersonalRegistrado(id As String, PNombre As String, SNombre As String, PApellido As String, SApellido As String, correo As String, telefono As String, direccion As String, nivelestudio As String, usuario As String, pass As String) As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.Connection = conexion
                comandoMySql.CommandText = "UPDATE `personalregistrado` SET `P_NOMBRE` = '" & PNombre & "', `S_NOMBRE` = '" & SNombre & "', `P_APELLIDO` = '" & PApellido & "', `S_APELLIDO` = '" & SApellido & "',  `CORREO` = '" & correo & "', `TELEFONO` = '" & telefono & "', `NIVEL_ESTUDIO` = '" & nivelestudio & "', `DIRECCION` = ('" & direccion & "') WHERE `personalregistrado`.`ID` = " & id
                ' comandoMySql.CommandText = "UPDATE `personalregistrado` SET `P_NOMBRE` = 'Juan', `S_NOMBRE` = 'DOSPALOTE.', `P_APELLIDO` = 'SUBEYBAJA.', `S_APELLIDO` = 'YYOTELOROZO.', `CI` = '" & ci & "', `GENERO` = 'FEMENINO', `CORREO` = '" & correo & "', `TELEFONO` = '" & telefono & "', `DIRECCION` = '2', `NIVEL_ESTUDIO` = '" & nivelestudio & "' WHERE `personalregistrado`.`ID` =" & id
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.ExecuteNonQuery()
            End Using
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "UPDATE `cuentas` SET `usuario` = '" & usuario & "', `password` = '" & pass & "' WHERE `cuentas`.`id_propietario` = " & id & ";"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.ExecuteNonQuery()
            End Using
        End Using
        Return 0
    End Function




End Class
