Imports AccesoDatos
Public Class InsertarCliente
    Dim insert As New InsertarEmpresaCliente
    Public Function InsertarEnClientes(nombre As String, rif As String, descripcion As String, tipo As String, direccion As String) As Integer
        Return insert.InsertarEnClientes(nombre, rif, descripcion, tipo, direccion)
    End Function
    Public Function InsertarRedClientes(NombreRed As String, IPV41 As String, IPV42 As String, id_CLIENTE As String) As Integer
        Return insert.InsertarRedClientes(NombreRed, IPV41, IPV42, id_CLIENTE)
    End Function

    Public Function InsertarDepartamentosCliente(id_CLIENTE As String, IdDepartamento As String) As Integer
        Return insert.InsertarDepartamentosCliente(id_CLIENTE, IdDepartamento)
    End Function

    Public Function ActualizarCliente(IDcliente As String, nombre As String, rif As String, descripcion As String, tipo As String, direccion As String)
        Return insert.ActualizarClientes(IDcliente, nombre, rif, descripcion, tipo, direccion)
    End Function
End Class
