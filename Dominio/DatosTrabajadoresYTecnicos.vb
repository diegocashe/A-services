Imports Dominio
Public Class DatosTrabajadoresYTecnicos
    ReadOnly TYT As New AccesoDatos.TrabajadoresYTecnicos
    Public Function InsertPers(pnombre As String, snombre As String, papellido As String, sapellido As String, Cedula As String, genero As String, correo As String, telefono As String, direccion As String, NivelEstudio As String, FechaNacimiento As String, FechaContrato As String) As Integer
        Return TYT.InsertarPersonal(pnombre, snombre, papellido, sapellido, Cedula, genero, correo, telefono, direccion, NivelEstudio, FechaNacimiento, FechaContrato)
    End Function
    Public Function InsertarEmpCli(IDPersonal As String, IDClientedepartamento As String) As Integer
        Return TYT.InsertarEmpleadoCliente(IDPersonal, IDClientedepartamento)
    End Function
    Public Function InsertarTrabajador(IdPersonaRegistrada As String) As Integer
        Return TYT.InsertarTrabajador(IdPersonaRegistrada)
    End Function
    Public Function InsertarTec(idTrabajador As String, especialidad As String) As Integer
        Return TYT.InsertarTecnico(idTrabajador, especialidad)
    End Function
    Public Function InCuentaUsuario(user As String, pass As String, idpropietario As String, permiso As String) As Integer
        Return TYT.InsertarCuentaDeUsuario(user, pass, idpropietario, permiso)
    End Function





End Class
