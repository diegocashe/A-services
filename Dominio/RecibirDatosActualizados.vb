Public Class RecibirDatosActualizados
    Dim ABD As New AccesoDatos.ActualizarDatos

    Public Function ActualizarTrabajadoresDom(id As String, PNombre As String, SNombre As String, PApellido As String, SApellido As String,
                                      correo As String, telefono As String, direccion As String,
                                       nivelestudio As String, usuario As String, pass As String) As Integer


        Return ABD.ActualizarPersonalRegistrado(id, PNombre, SNombre, PApellido, SApellido, correo, telefono, direccion,
                                       nivelestudio, usuario, pass)
    End Function

End Class
