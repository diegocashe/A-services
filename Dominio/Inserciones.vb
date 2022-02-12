Imports AccesoDatos
Public Class Inserciones
    Dim ad As New TrabajadoresYTecnicos
    Public Function InsertareEquipoEscritorioDom(nombre As String, DIRMAC As String, DIRXML As String, ipv43 As String, ipv44 As String, idred As String, idpropietario As String) As Integer


        Return ad.InsertareEquipoEscritorio(nombre, DIRMAC, DIRXML, ipv43, ipv44, idred, idpropietario)
    End Function
End Class
