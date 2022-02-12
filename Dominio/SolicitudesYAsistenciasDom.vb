Imports AccesoDatos
Public Class SolicitudesYAsistenciasDom
    Dim AD As New SolicitudesYAsistencias

    Public Function InsertarSolicitudDom(idEmpleado As String, tipofalla As String, descripcion As String) As Integer
        Return AD.InsertarSolicitud(idEmpleado, tipofalla, descripcion)
    End Function

    Public Function InsertarAsistenciaDom(tipo As String, accion As String, idsolicitud As String, IdTecnico As String, servicio As String, descripcion As String) As Integer
        Return AD.InsertarAsistencia(tipo, accion, idsolicitud, IdTecnico, servicio, descripcion)
    End Function
End Class
