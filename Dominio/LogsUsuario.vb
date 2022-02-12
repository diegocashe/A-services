Imports AccesoDatos
Imports Comun
Public Class LogsUsuario
    ReadOnly EnviarDatosLogin As New Logs
    ReadOnly RecibirDatosBD As New RecibirDatos
    Public Function LogIn(user As String, pass As String) As Boolean
        Return EnviarDatosLogin.Ingresar(user, pass)
    End Function

    Public Async Function Datos() As Task
        Dim resp As Task(Of Boolean) = Task.Run(Function()
                                                    Return RecibirDatosBD.AgregarDatosUsuarioClienteACache(Usuario, Rol)
                                                End Function)
        Await resp
    End Function

End Class
