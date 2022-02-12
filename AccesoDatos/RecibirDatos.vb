Imports Comun
Imports MySql.Data.MySqlClient
Public Class RecibirDatos
    Inherits ClienteMySQL
    Public Function AgregarDatosUsuarioClienteACache(user As String, rol As String) As Boolean
        Using conexionPrueba = obtenerConexion(My.Settings.CadenaConexionPrincipal)
            conexionPrueba.open()
            Using comandoMySql As New MySqlCommand
                comandoMySql.Connection = conexionPrueba
                Select Case rol
                    Case "CLIENTES"
                        comandoMySql.CommandText = "SELECT ci,FULLNAME,DEPENDENCYIA,PERMISO,IFNULL(max(FECHASOLICITUD),'NUNCA HA SOLICITADO'), IFNULL(max(FECHAASISTENCIA),'NUNCA SE LE HA ASISTIDO'),ID FROM `relaciondatossolicitudyasistencia` WHERE USER like '" + user + "'"
                        comandoMySql.CommandType = CommandType.Text
                        Dim lector = comandoMySql.ExecuteReader()
                        If lector.HasRows Then
                            While lector.Read()
                                Try
                                    With lector
                                        ci = .GetString(0)
                                        Nombre = .GetString(1)
                                        Empresa = .GetString(2)
                                        rol = .GetString(3)
                                        Try
                                            fechaUltimaSolicitud = .GetString(4)
                                        Catch ex As Exception
                                            fechaUltimaSolicitud = "No ha hecho"
                                        End Try
                                        Try
                                            fechaUltimaRevision = .GetString(5)
                                        Catch ex As Exception
                                            fechaUltimaRevision = "No ha hecho"
                                        End Try

                                        id = .GetString(6)
                                    End With
                                Catch ex As Exception
                                    Return False
                                End Try
                            End While
                            Return True
                        Else
                            Return False
                        End If

                        Exit Select
                    Case "ADMINISTRADOR"
                        comandoMySql.CommandText = "SELECT  CEDULA,Trabajador, USUARIO, ROl FROM administradores WHERE Usuario LIKE '" + user + "'"
                        comandoMySql.CommandType = CommandType.Text
                        Dim lector = comandoMySql.ExecuteReader()
                        If lector.HasRows Then
                            While lector.Read()
                                Try
                                    With lector
                                        ci = .GetString(0)
                                        Nombre = .GetString(1)
                                        Empresa = "A Services Group"
                                    End With

                                Catch ex As Exception
                                    Return False
                                End Try
                            End While
                            Return True
                        Else
                            Return False
                        End If
                        Exit Select
                    Case "TECNICO"
                        comandoMySql.CommandText = "SELECT NOMBRE, CEDULA, ESPECIALIDAD, CALIFICACION, IFNULL(max(Asistencia),'No ha hecho nuca una Asistencia'),idtecnico FROM datostecnicos WHERE USUARIO like '" + user + "'"
                        comandoMySql.CommandType = CommandType.Text
                        Dim lector = comandoMySql.ExecuteReader()
                        If lector.HasRows Then
                            While lector.Read()
                                Try
                                    With lector
                                        ci = .GetString(1)
                                        Nombre = .GetString(0)
                                        Empresa = "A Services Group"
                                        Especialidad = .GetString(2)
                                        Rating = .GetInt32(3)
                                        fechaUltimaRevision = .GetString(4)
                                        id = .GetInt32(5)
                                    End With
                                Catch ex As Exception
                                    Return False
                                End Try
                            End While
                            Return True
                        Else
                            Return False
                        End If

                        Exit Select
                    Case "root"
                        ci = "Usuario Raiz Solo Para Pruebas"
                        Nombre = "Usuario Raiz Solo Para Pruebas"
                        Empresa = "Usuario Raiz Solo Para Pruebas"
                        fechaUltimaSolicitud = "Usuario Raiz Solo Para Pruebas"
                        fechaUltimaRevision = "Usuario Raiz Solo Para Pruebas"
                        Return True
                    Case Else
                        Return False
                End Select
            End Using
        End Using
    End Function


    Public Function DatosCompletosClientes(user As String) As DataTable
        Dim TablaVacias As New DataTable
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Using DA As New MySqlDataAdapter("SELECT * FROM `datoscompletosclientes` where usuario like '" + user + "'", conexion)
                    Dim Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        Catch ex As Exception
            Return TablaVacias
        End Try
    End Function


    Public Function DatosCompletosClientesTodos(dst As DataSet) As DataSet
        'Dim dst As DataSet = New DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `datosempresasclientes`"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "datosdeclientes")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function
    Public Function TablasDeDireccion(dst As DataSet) As DataSet
        'Dim dst As DataSet = New DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `pais`;"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "pais")
                    DA.SelectCommand.CommandText = "SELECT * FROM `estados`;"
                    DA.Fill(dst, "estados")
                    DA.SelectCommand.CommandText = "SELECT * FROM `municipios`;"
                    DA.Fill(dst, "municipios")
                    DA.SelectCommand.CommandText = "SELECT * FROM `parroquias`;"
                    DA.Fill(dst, "parroquias")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function
    Public Function TablaDeDepartamentos(dst As DataSet) As DataSet
        'Dim dst As DataSet = New DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `departamento`;"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "departamentos")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function
    Public Function TablaDeDepartamentosDeClientes(dst As DataSet) As DataSet
        'Dim dst As DataSet = New DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `departamentosdeclientes`;"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "departamentosdeclientes")
                    DA.SelectCommand.CommandText = "SELECT * FROM `empresa_cliente`;"
                    DA.Fill(dst, "empresacliente")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function

    Public Function DatosDeTrabajadores(dst As DataSet) As DataSet

        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM datostrabajadores"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "datostrabajadores")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function
    Public Function DatosDeEmpleadosClientes(dst As DataSet) As DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `datoscompletosclientes`"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "datosempleadosclientes")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function

    Public Function RedesClientes(dst As DataSet) As DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = " Select * FROM `redesclientes` "
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "redesclientes")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function

    Public Function DatosParaSolicitudes(dst As DataSet) As DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `datosparasolicitudes`"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "DatosParaSolicitudes")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function

    Public Function PosiblesFallas(dst As DataSet) As DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `fallas_comunes`"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "fallascomunes")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function
    Public Function SolicitudesSinAtender(dst As DataSet) As DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `datoscompletossolicitudes`"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "datoscompletossolicitudes")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function
    Public Function Serviciosdisp(dst As DataSet) As DataSet
        Try
            Using conexion = obtenerConexion(My.Settings.CadenaConexionPrincipal)
                conexion.Open()
                Dim Solicitud As String = "SELECT * FROM `servicios_disponibles`"
                Using DA As New MySqlDataAdapter(Solicitud, conexion)
                    DA.Fill(dst, "servicios")
                End Using
                Return dst
            End Using
        Catch ex As Exception
            Return dst
        End Try
    End Function
End Class
