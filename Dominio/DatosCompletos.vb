Imports AccesoDatos
Imports MySql.Data.MySqlClient
Public Class DatosCompletos
    Private ReadOnly RecibirDatos As New RecibirDatos
    Public Function DatosCompletosCliente(user As String) As DataTable
        Return RecibirDatos.DatosCompletosClientes(user)
    End Function
    Public Function DatosCompletosClienteTodos(dst As DataSet) As DataSet
        Return RecibirDatos.DatosCompletosClientesTodos(dst)
    End Function
    Public Function SolicitarDirecciones(dst As DataSet) As DataSet
        Return RecibirDatos.TablasDeDireccion(dst)
    End Function
    Public Function SolicitarDepartamentos(dst As DataSet) As DataSet
        Return RecibirDatos.TablaDeDepartamentos(dst)
    End Function
    Public Function SolicitarDepartamentosDeCliente(dst As DataSet) As DataSet
        Return RecibirDatos.TablaDeDepartamentosDeClientes(dst)
    End Function
    Public Function SolicitarDatosDeTrabajadores(dst As DataSet) As DataSet
        Return RecibirDatos.DatosDeTrabajadores(dst)
    End Function
    Public Function SolicitarDatosDeEmpleadosClientes(dst As DataSet) As DataSet
        Return RecibirDatos.DatosDeEmpleadosClientes(dst)
    End Function
    Public Function SolicitarRedesClientes(dst As DataSet) As DataSet
        Return RecibirDatos.RedesClientes(dst)
    End Function
    Public Function SolicitarDatosParaSolicitudes(dst As DataSet) As DataSet
        Return RecibirDatos.DatosParaSolicitudes(dst)
    End Function
    Public Function SolicitarFallasComunes(dst As DataSet) As DataSet
        Return RecibirDatos.PosiblesFallas(dst)
    End Function
    Public Function SolicitarSolicitudesSinAtender(dst As DataSet) As DataSet
        Return RecibirDatos.SolicitudesSinAtender(dst)
    End Function
    Public Function SolicitarServicios(dst As DataSet) As DataSet
        Return RecibirDatos.Serviciosdisp(dst)
    End Function
End Class
