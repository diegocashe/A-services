Imports Comun
Public Class FormInfoDatosMaquina
    Private Sub FormCrearArchivozXml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = UsuarioActual.Nombre
        Dim lbs = Me.Controls.OfType(Of Label)
        For Each lb In lbs
            PropiedadesLabel(lb)
        Next
        Me.BackColor = TemaActual.Fondo
    End Sub
End Class