Imports Dominio
Imports Comun
Public Class FormPresentacion
    Dim ConexionDominio As New PruebaConexionDominio 'dim cambiado por ReadOnly
    Private Tiempo As Integer = 3
    Private Cuenta As Integer = 0
    Private Sub FormPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RetornarColores(My.Settings.Tema) ''My.Settings.Tema)
        AsignarColores()
        Me.Show()
        cargarEnMemoria()
    End Sub
    Private Sub TimerPineo_Tick(sender As Object, e As EventArgs) Handles TimerPin.Tick
        If Tiempo = 3 Then
            cargarEnMemoria()
        End If

        If Tiempo > 0 Then
            'LabelContador.Text = Tiempo.ToString()
            If Tiempo = 2 Then
                Try
                    For i = 0 To ProgressBarPin.Maximum
                        If ConexionDominio.PineoDom() = True Then
                            Try
                                ProgressBarPin.Value = Cuenta
                                ProgressBarPin.Update()
                            Catch ex2 As Exception
                            End Try
                            Application.DoEvents()
                            Cuenta += 1
                        Else
                            Exit For
                        End If
                    Next
                Catch ex1 As Exception
                End Try
            End If
            Tiempo -= 1
        Else
            If ProgressBarPin.Value = 1000 Then
                TimerPin.Enabled = False
                FormLogin.Show()
                Me.Close()
            Else
                TimerPin.Enabled = False
                MessageBox.Show("No hay buena conexion con el servidor o esta no existe se cerrara la aplicacion")
                Application.Exit()
            End If
        End If
    End Sub
    Private Async Sub cargarEnMemoria()
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     Using Flogin As New FormLogin

                                                         Flogin.Hide()
                                                     End Using
                                                 End Sub)
        Await resp
    End Sub
    Sub AsignarColores()

        Me.PanelFondo.GradientBottomLeft = TemaActual.PanelLateral
        Me.PanelFondo.GradientBottomRight = TemaActual.Fondo
        Me.PanelFondo.GradientTopLeft = TemaActual.PanelLateral
        Me.PanelFondo.GradientTopRight = TemaActual.Fondo
        If (Tema.TemaActual.IsDark = False) Then
            Me.PictureBoxLogo.Image = My.Resources._7_LogoNegroSinFondo
            Me.PictureBoxAServicesApp.Image = My.Resources._4_ASERVICES_LETRASNEGRAS
            Me.PictureBoxServicio.Image = My.Resources._4_SERVICIO_LETRASNEGRAS
            Me.PictureBoxTecnico.Image = My.Resources._4_TECNICO_LETRASNEGRAS
        End If
    End Sub


End Class