Imports AccesoDatos
Public Class PruebaConexionDominio
    ReadOnly AccesoABD As New PruebaConexionBD
    Public Function PineoDom() As Boolean
        Return AccesoABD.Pineo()
    End Function
End Class
