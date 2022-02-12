Imports MySql.Data.MySqlClient
Imports Comun
Imports AccesoDatos
Public Class TrabajadoresYTecnicos
    Inherits ClienteMySQL
    Public Function InsertarPersonal(pnombre As String, snombre As String, papellido As String, sapellido As String, Cedula As String, genero As String, correo As String, telefono As String, direccion As String, NivelEstudio As String, FechaNacimiento As String, FechaContrato As String) As Integer
        Dim IDTemp As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `personalregistrado` (`ID`, `P_NOMBRE`, `S_NOMBRE`, `P_APELLIDO`, `S_APELLIDO`, `CI`, `GENERO`, `CORREO`, `TELEFONO`, `DIRECCION`, `NIVEL_ESTUDIO`, `FECHA_NACIMIENTO`, `FECHA_CONTRATACION`) VALUES (NULL, '" + pnombre + "', '" + snombre + "', '" + papellido + "', '" + sapellido + "', '" + Cedula + "', '" + genero + "', '" + correo + "', '" + telefono + "', " + direccion + ", '" + NivelEstudio + "', '" + FechaNacimiento + "', '" + FechaContrato + "')"
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.Connection = conexion
                comandoMySql.ExecuteNonQuery()
                Using SeleccionDeID As New MySqlCommand
                    SeleccionDeID.Connection = conexion
                    SeleccionDeID.CommandText = "SELECT * FROM `personalregistrado` WHERE CI='" + Cedula + "'"
                    SeleccionDeID.CommandType = CommandType.Text
                    Dim lector = SeleccionDeID.ExecuteReader()
                    If lector.HasRows Then
                        While lector.Read()
                            IDTemp = lector.GetInt32(0)
                        End While
                        Return IDTemp
                    Else
                        Return IDTemp
                    End If
                End Using
                Return IDTemp
            End Using
        End Using
    End Function

    Public Function InsertarEmpleadoCliente(IDPersonal As String, IDClientedepartamento As String) As Integer

        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `empleado_cliente` (`ID`, `ID_PERSONAL`, `ID_CLIENTE_DEPARTAMENTO`) VALUES (NULL, '" + IDPersonal + "', '" + IDClientedepartamento + "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function InsertarTrabajador(IdPersonaRegistrada As String) As Integer
        Dim idtemp As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `trabajador` (`ID_TRABAJADOR`, `ID_PERSONAL`) VALUES (NULL, '" + IdPersonaRegistrada + "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.ExecuteNonQuery()
                Using SeleccionDeID As New MySqlCommand
                    SeleccionDeID.Connection = conexion
                    SeleccionDeID.CommandText = "SELECT * FROM `trabajador` WHERE ID_PERSONAL='" + IdPersonaRegistrada + "'"
                    SeleccionDeID.CommandType = CommandType.Text
                    Dim lector = SeleccionDeID.ExecuteReader()
                    If lector.HasRows Then
                        While lector.Read()
                            idtemp = lector.GetInt32(0)
                        End While
                        Return idtemp
                    Else
                        Return idtemp
                    End If
                End Using
                Return idtemp
            End Using
        End Using
    End Function

    Public Function InsertarTecnico(idTrabajador As String, especialidad As String) As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `tecnico` (`ID_TECNICO`, `ESPECIALIDAD`, `CALIFICACION`, `ID_TRABAJADOR`) VALUES (NULL, '" + especialidad + "', '0', '" + idTrabajador + "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function InsertarCuentaDeUsuario(user As String, pass As String, idpropietario As String, permiso As String) As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `cuentas` (`id_cuenta`, `usuario`, `password`, `ID_PROPIETARIO`, `permiso`) VALUES (NULL, '" + user + "', '" + pass + "', '" + idpropietario + "', '" + permiso + "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function




    Public Function InsertareEquipoEscritorio(nombre As String, DIRMAC As String, DIRXML As String, ipv43 As String, ipv44 As String, idred As String, idpropietario As String) As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            Dim idtemp As Integer
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `equipo_computo` (`ID_EQUIPO`, `NOMBRE`, `TIPO`, `DIRECCION_MAC`, `ESTATUS`, `DIR_XML_DATOS`) VALUES (NULL, '" & nombre & "', 'Escritorio', '" & DIRMAC & "', 'OPERATIVA', '" & DIRXML & "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.ExecuteNonQuery()
                Using SeleccionDeID As New MySqlCommand
                    SeleccionDeID.Connection = conexion
                    SeleccionDeID.CommandText = "SELECT * FROM equipo_computo where direccion_mac ='" & DIRMAC & "'"
                    SeleccionDeID.CommandType = CommandType.Text
                    Dim lector = SeleccionDeID.ExecuteReader()
                    If lector.HasRows Then
                        While lector.Read()
                            idtemp = lector.GetInt32(0)
                        End While
                    End If
                End Using

            End Using
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `red_equipos` (`ID_RED`, `IPV4-3`, `IPV4-4`, `EQUIPO`) VALUES ('" & idred & "', '" & ipv43 & "', '" & ipv44 & "', '" & idtemp & "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.ExecuteNonQuery()
            End Using
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `asignacion_maquinas` (`ID_USUARIO_ASIGNADO`, `ID_MAQUINA`) VALUES ('" & idpropietario & "', '" & idtemp & "')"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.ExecuteNonQuery()
            End Using
        End Using
        Return 0
    End Function


    'Public Function ActualizarClientes(IDcliente As String, nombre As String, rif As String, descripcion As String, tipo As String, direccion As String) As Integer
    '    Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
    '        conexion.Open()
    '        Using comandoMySql As New MySqlCommand
    '            comandoMySql.CommandText = "UPDATE `empresa_cliente` SET `NOMBRE` = '" + nombre + "', `RIF` = '" + rif + "', `DESCRIPCION` = '" + descripcion + "', `TIPO` = '" + tipo + "', `DIRECCION` = '" + direccion + "' WHERE `empresa_cliente`.`ID` = " + IDcliente + ";"
    '            comandoMySql.Connection = conexion
    '            comandoMySql.CommandType = CommandType.Text
    '            Return comandoMySql.ExecuteNonQuery()
    '        End Using
    '    End Using
    'End Function
End Class
