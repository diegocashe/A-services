Imports Dominio
Imports Comun
Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RetornarColores(My.Settings.Tema)
        Me.AsiganacionDeColores()
        Me.cargarEnMemoria()
    End Sub
    '-------------------------------------- METODOS DEL TEXBOX USUARIO -------------------------------------------
#Region "textBox Usuario"
    Private Sub Txt_usuario_Enter(sender As Object, e As EventArgs) Handles TextBoxUsuario.Enter
        If TextBoxUsuario.Text = "Usuario" Then
            TextBoxUsuario.Text = ""
        End If
        TextBoxUsuario.ForeColor = Color.Silver
        LineUsuario.BackColor = Color.Silver
    End Sub
    Private Sub Txt_usuario_Leave(sender As Object, e As EventArgs) Handles TextBoxUsuario.Leave
        If TextBoxUsuario.Text = "" Then
            TextBoxUsuario.Text = "Usuario"
        Else
            TextBoxUsuario.ForeColor = Color.Silver
            LineUsuario.BackColor = Color.Silver
        End If
        TextBoxUsuario.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        LineUsuario.BackColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub
    Private Sub Txt_usuario_MouseHover(sender As Object, e As EventArgs) Handles TextBoxUsuario.MouseHover
        TextBoxUsuario.ForeColor = Color.Gray
        LineUsuario.BackColor = Color.Gray
    End Sub
    Private Sub Txt_usuario_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxUsuario.MouseLeave
        TextBoxUsuario.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        LineUsuario.BackColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub
#End Region
    '----------------------------------------METODOS DEL TEXTBOX CONTRASEÑA --------------------------------------
#Region "textbox_Contraseña"
    Private Sub Txt_contraseña_Enter(sender As Object, e As EventArgs) Handles TextBoxContraseña.Enter
        If TextBoxContraseña.Text = "Contraseña" Then
            TextBoxContraseña.Text = ""
        End If
        TextBoxContraseña.UseSystemPasswordChar = True
        TextBoxContraseña.ForeColor = Color.Silver
        LineContraseña.BackColor = Color.Silver

    End Sub

    Private Sub Txt_contraseña_Leave(sender As Object, e As EventArgs) Handles TextBoxContraseña.Leave
        If TextBoxContraseña.Text = "" Then
            TextBoxContraseña.Text = "Contraseña"
            TextBoxContraseña.UseSystemPasswordChar = False
        Else
            TextBoxContraseña.ForeColor = Color.Silver
            LineContraseña.BackColor = Color.Silver
        End If
        TextBoxContraseña.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        LineContraseña.BackColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub Txt_contraseña_MouseHover(sender As Object, e As EventArgs) Handles TextBoxContraseña.MouseHover
        TextBoxContraseña.ForeColor = Color.Gray
        LineContraseña.BackColor = Color.Gray
    End Sub

    Private Sub Txt_contraseña_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxContraseña.MouseLeave
        TextBoxContraseña.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        LineContraseña.BackColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub
#End Region
    '----------------------------------------  METODOS DE BOTONES --------------------------------------
#Region "Botones 'Entrar y Salir'"
    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Application.Exit()
    End Sub
    Private Sub Btn_entrar_Click(sender As Object, e As EventArgs) Handles ButtonEntrar.Click
        Dim Log As New LogsUsuario
        Dim validacion As Boolean = Log.LogIn(TextBoxUsuario.Text, TextBoxContraseña.Text)

        If validacion = True Then
            Select Case Rol
                Case "ADMINISTRADOR"
                    FormBaseAdministradores.Show()
                    Try
                        Log.Datos()
                    Catch ex As Exception

                    End Try
                    Me.Close()
                    Exit Select
                Case "TECNICO"
                    FormBaseTecnicos.Show()
                    Try
                        Log.Datos()
                    Catch ex As Exception

                    End Try
                    Me.Close()
                    Exit Select
                Case "CLIENTES"
                    FormBaseClientes.Show()
                    Try
                        Log.Datos()
                    Catch ex As Exception

                    End Try
                    Me.Close()
                    Exit Select
            End Select
        Else
            MessageBox.Show("No se ha encontrado el Usuario")
        End If
    End Sub
#End Region
    Friend Sub AsiganacionDeColores()
        Dim lbs = Me.PanelPrincipalRight.Controls.OfType(Of Label)
        For Each lb In lbs
            lb.ForeColor = TemaActual.Letra
        Next
        Dim lklbs = Me.PanelPrincipalRight.Controls.OfType(Of LinkLabel)
        For Each lklb In lklbs
            lklb.LinkColor = TemaActual.Letra
        Next
        Me.PanelPrincipalRight.BackColor = TemaActual.Fondo
        Me.PanelGrandientLeft.GradientBottomLeft = TemaActual.PanelLateral
        Me.PanelGrandientLeft.GradientBottomRight = TemaActual.Fondo
        Me.PanelGrandientLeft.GradientTopLeft = TemaActual.PanelLateral
        Me.PanelGrandientLeft.GradientTopRight = TemaActual.Fondo
        If TemaActual.IsDark = False Then
            Me.PictureBoxLogo.Image = My.Resources._7_LogoNegroSinFondo
            Me.PictureBoxServicio.Image = My.Resources._4_SERVICIO_LETRASNEGRAS
            Me.PictureBoxNombreApp.Image = My.Resources._4_ASERVICES_LETRASNEGRAS
            Me.PictureBoxTecnico.Image = My.Resources._4_TECNICO_LETRASNEGRAS
        End If
        Me.TextBoxUsuario.BackColor = TemaActual.Fondo
        Me.TextBoxContraseña.BackColor = TemaActual.Fondo
    End Sub
    Async Sub cargarEnMemoria()
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     Using form1 As New FormBaseAdministradores
                                                         form1.Hide()
                                                     End Using
                                                     Using form2 As New FormBaseClientes
                                                         form2.Hide()
                                                     End Using
                                                     Using form3 As New FormBaseTecnicos
                                                         form3.Hide()
                                                     End Using
                                                 End Sub)
        Await resp
    End Sub

    Private Sub LinkContacto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkContacto.LinkClicked
        MsgBox("Contacto a travez de los siguientes numeros:" & vbNewLine & "04143635330" & vbNewLine & "04122987672", vbOKOnly + vbInformation, "INFO")
    End Sub

    Private Sub LinkNosotros_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNosotros.LinkClicked
        MsgBox("Somos un grupo destinado a servirte a ti y a todos tus equipos, !!nunca mas tendras algo arrumado¡¡", vbOKOnly + vbInformation, "INFO")
    End Sub

    Private Sub LinkAyuda_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAyuda.LinkClicked
        MsgBox("Si necesitas ayuda !Envianos un correo¡, estamos atentos de 8:00 am a 5:00 pm ", vbOKOnly + vbInformation, "INFO")
    End Sub

    Private Sub LinkRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegistro.LinkClicked
        MsgBox("Esta opcion estará habilitada en futuras versiones", vbOKOnly + vbInformation, "INFO")
    End Sub

    Private Sub LinkDerechosAutor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDerechosAutor.LinkClicked
        MsgBox("DachSystems C.A ----- A Services C.A", vbOKOnly + vbInformation, "INFO")
    End Sub
End Class