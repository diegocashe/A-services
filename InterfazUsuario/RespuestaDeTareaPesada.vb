Imports System.ComponentModel
Public Class RespuestaDeTareaPesada
    Private Mensaje As String

    Public Sub Proceso(ByVal msg As String)
        Me.Mensaje = msg
    End Sub

    Public ReadOnly Property MensajeGet
        Get
            Return Mensaje
        End Get
    End Property
End Class
