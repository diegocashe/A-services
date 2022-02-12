Imports MySql.Data.MySqlClient
Imports Comun
Imports AccesoDatos
Public Class InsertarEmpresaCliente
    Inherits ClienteMySQL
    Public Function InsertarEnClientes(nombre As String, rif As String, descripcion As String, tipo As String, direccion As String) As Integer
        Dim IDTemp As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `empresa_cliente` (`ID`, `NOMBRE`, `RIF`, `DESCRIPCION`, `TIPO`, `DIRECCION`) VALUES (NULL, '" + nombre + "', '" + rif + "', '" + descripcion + "', '" + tipo + "', '" + direccion + "')"

                '  comandoMySql.Parameters("?direccion").Value = direccion
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                comandoMySql.ExecuteNonQuery()
                Using SeleccionDeID As New MySqlCommand
                    SeleccionDeID.Connection = conexion
                    SeleccionDeID.CommandText = "SELECT * FROM empresa_cliente WHERE nombre='" + nombre + "'"

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



    Public Function InsertarRedClientes(NombreRed As String, IPV41 As String, IPV42 As String, id_CLIENTE As String) As Integer

        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `red_cliente` (`ID`, `NOMBRE`, `IPV4-1`, `IPV4-2`, `ID_CLIENTE`) VALUES (NULL, '" + NombreRed + "', '" + IPV41 + "', '" + IPV42 + "', '" + id_CLIENTE + "')"

                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text

                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function InsertarDepartamentosCliente(id_CLIENTE As String, IdDepartamento As String) As Integer

        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "INSERT INTO `empresacliente_departamento` (`ID`, `ID_CLIENTE`, `ID_DEPARTAMENTO`) VALUES (NULL, '" + id_CLIENTE + "', '" + IdDepartamento + "')"

                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function ActualizarClientes(IDcliente As String, nombre As String, rif As String, descripcion As String, tipo As String, direccion As String) As Integer
        Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexion.Open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.CommandText = "UPDATE `empresa_cliente` SET `NOMBRE` = '" + nombre + "', `RIF` = '" + rif + "', `DESCRIPCION` = '" + descripcion + "', `TIPO` = '" + tipo + "', `DIRECCION` = '" + direccion + "' WHERE `empresa_cliente`.`ID` = " + IDcliente + ";"
                comandoMySql.Connection = conexion
                comandoMySql.CommandType = CommandType.Text
                Return comandoMySql.ExecuteNonQuery()
            End Using
        End Using
    End Function
End Class
