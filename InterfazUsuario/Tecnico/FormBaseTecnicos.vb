Imports System.Runtime.InteropServices
Imports Comun
Public Class FormBaseTecnicos
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Async Sub FormBasePrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RetornarColores(1)
        CambioDeTema()
        Await AsignarToolTips()
        cargarEnMemoria()
    End Sub
#Region "Panel top"
    Private Sub PanelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    '---------------------------------------BOTON CERRAR
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub
    '-------------...............---------BOTON MAXIMIZAR
    Private Sub ButtonMaximizar_Click(sender As Object, e As EventArgs) Handles ButtonMaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        ButtonMaximizar.Visible = False
        ButtonRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    '----------------------BOTON RESTAURAR
    Private Sub ButtonRestaurar_Click(sender As Object, e As EventArgs) Handles ButtonRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        ButtonMaximizar.Visible = True
        ButtonRestaurar.Visible = False
    End Sub
    '--------------------- BOTON MINIMIZAR
    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region
#Region "Panel lateral"
#Region "Abrir y cerrar PanelLateral"
    Private Async Sub TimerAbrirPanelLateral_Tick(sender As Object, e As EventArgs) Handles TimerAbrirPanelLateral.Tick



        If PanelLateral.Width = 130 Then
            ButtonInicio.Text = "Inicio"
            ButtonMenu2.Text = "Usuario"
            ButtonMenu3.Text = "Agregar"
            ButtonMenu4.Text = "Actualizar"
            ButtonMenu5.Text = "Rendimiento"
            ButtonMenu6.Text = "Configuration"
        End If
        If PanelLateral.Width >= 200 Then
            Me.TimerAbrirPanelLateral.Enabled = False
            Dim a = PanelContenedorFormularios.Controls.OfType(Of Form)
            For Each frm In a
                frm.Show()
            Next
        Else
            Await AbrirPanel()

        End If
    End Sub
    Private Async Function AbrirPanel() As Task
        Dim AbrirResp As Task = Task.Factory.StartNew(Sub()
                                                          PanelLateral.Invoke(New MethodInvoker(Sub()
                                                                                                    Me.PanelLateral.Width = PanelLateral.Width + 10
                                                                                                    Application.DoEvents()
                                                                                                End Sub))
                                                      End Sub)
        Await AbrirResp
    End Function
    Private Async Function CerrarPanel() As Task
        Dim CerrarResp As Task = Task.Factory.StartNew(Sub()
                                                           PanelLateral.Invoke(New MethodInvoker(Sub()
                                                                                                     PanelLateral.Width = PanelLateral.Width - 10
                                                                                                     Application.DoEvents()
                                                                                                 End Sub
                                                                               ))
                                                       End Sub)
        Await CerrarResp
    End Function
    Private Async Sub TimerCerrarPanelLateral_Tick(sender As Object, e As EventArgs) Handles TimerCerrarPanelLateral.Tick

        Dim a = PanelContenedorFormularios.Controls.OfType(Of Form)

        If PanelLateral.Width = 50 Then
            ButtonInicio.Text = ""
            ButtonMenu2.Text = ""
            ButtonMenu3.Text = ""
            ButtonMenu4.Text = ""
            ButtonMenu5.Text = ""
            ButtonMenu6.Text = ""
        End If
        If PanelLateral.Width <= 40 Then
            Me.TimerCerrarPanelLateral.Enabled = False
            For Each frm In a
                frm.Show()
            Next
        Else
            Await CerrarPanel()
        End If
    End Sub
    Private Async Function EventoCerrarPanelLateral() As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     PanelLateral.Invoke(Sub()
                                                                             TimerCerrarPanelLateral.Enabled = True
                                                                             Me.PictureBoxLogo.Dock = DockStyle.Fill
                                                                             Me.LabelTitulo.Visible = False
                                                                         End Sub)
                                                 End Sub)
        Await resp
    End Function
    Private Async Function EventoAbrirPanelLateral() As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     PanelLateral.Invoke(Sub()
                                                                             TimerAbrirPanelLateral.Enabled = True
                                                                             Me.PictureBoxLogo.Dock = DockStyle.None
                                                                             Me.LabelTitulo.Visible = True
                                                                         End Sub)
                                                 End Sub)
        Await resp
    End Function
    Private Async Sub IconButton1_Click(sender As Object, e As EventArgs) Handles ButtonPanelLateral.Click
        If PanelLateral.Width = 200 Then
            Dim a = PanelContenedorFormularios.Controls.OfType(Of Form)
            For Each frm In a
                frm.Hide()
            Next
            Await EventoCerrarPanelLateral()

        Else
            Dim a = PanelContenedorFormularios.Controls.OfType(Of Form)
            For Each frm In a
                frm.Hide()
            Next
            Await EventoAbrirPanelLateral()
        End If
    End Sub
    Private Async Sub ButtonOcultarPanelLateral_Click(sender As Object, e As EventArgs) Handles ButtonOcultarPanelLateral.Click
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     If PanelLateral.Visible = True Then
                                                         BT.HideSync(Me.PanelLateral)
                                                         Me.ButtonOcultarPanelLateral.IconChar = FontAwesome.Sharp.IconChar.CaretLeft
                                                     Else
                                                         BT.ShowSync(Me.PanelLateral)
                                                         Me.ButtonOcultarPanelLateral.IconChar = FontAwesome.Sharp.IconChar.CaretRight
                                                     End If
                                                 End Sub)
        Await resp
    End Sub
#End Region
#Region "menu Y SubMenu"
    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        CargarFormularioHijos(Of FormInicioGeneral)()
    End Sub


#End Region
#Region "Eventos mouseDown y mouseUp"
    Private Async Sub ButtonInicio_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonInicio.MouseDown

        Dim resp As Task = Task.Run(Sub()
                                        If (ButtonInicio.InvokeRequired) Then
                                            Me.ButtonInicio.Invoke(New MethodInvoker(Sub()
                                                                                         Me.ButtonInicio.Font = New System.Drawing.Font("Century Gothic", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                                                                                         Me.ButtonInicio.IconSize = 20
                                                                                     End Sub)
                                            )

                                        End If
                                    End Sub)
        Await resp
    End Sub
    Private Async Sub ButtonInicio_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonInicio.MouseUp
        Dim resp As Task = Task.Run(Sub()
                                        If (ButtonInicio.InvokeRequired) Then
                                            Me.ButtonInicio.Invoke(New MethodInvoker(Sub()
                                                                                         Me.ButtonInicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                                                                                         Me.ButtonInicio.IconSize = 26
                                                                                     End Sub)
                                            )

                                        End If
                                    End Sub)
        Await resp
    End Sub



#End Region
#End Region
#Region "Resize del formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    ReadOnly cGrip As Integer = 10 'dim cambiado por ReadOnly
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    ReadOnly tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)

        region.Exclude(sizeGripRectangle)

        Me.PanelContenedor.Region = region

        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(51, 67, 85)) 'COLOR DE EL RECTANGULO
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)

        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub





#End Region
#Region "Dlls Externos"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
#End Region
#Region "Asignacion de Variables de tema"
    Private Sub CambioDeTema()
        Me.PanelTop.BackColor = TemaActual.PanelTop
        Me.PanelLateral.BackColor = TemaActual.PanelLateral
        Me.ForeColor = TemaActual.Letra
        'Panel de fondo
        Me.PanelContenedorFormularios.BackColor = TemaActual.Fondo
        If (TemaActual.IsDark = False) Then
            Me.PictureBoxLogo.Image = My.Resources._7_LogoNegroSinFondo
            Me.PictureBoxLogoContainer.Image = My.Resources._7_LogoNegroSinFondo
        End If
        'panel Sub Menu
        Me.PanelSubMenu1.BackColor = TemaActual.PanelTop
        Me.PanelSubMenu2.BackColor = TemaActual.PanelTop
        'labels
        PropiedadesLabel(Me.LabelTitulo)
        PropiedadesLabel(Me.Label1)
        'Botones
        PropiedadesIconButton(Me.ButtonClose)
        PropiedadesIconButton(Me.ButtonMinimizar)
        PropiedadesIconButton(Me.ButtonRestaurar)
        PropiedadesIconButton(Me.ButtonMaximizar)
        PropiedadesIconButton(Me.ButtonPanelLateral)
        PropiedadesIconButton(Me.ButtonOcultarPanelLateral)
        'botones con letras e iconos
        PropiedadesIconButton(Me.ButtonInicio)
        PropiedadesIconButton(Me.ButtonMenu2)
        PropiedadesIconButton(Me.ButtonMenu5)
        PropiedadesIconButton(Me.ButtonMenu5)
        PropiedadesIconButton(Me.ButtonMenu6)
        PropiedadesIconButton(Me.ButtonMenu6)
        PropiedadesIconButton(Me.ButtonLogOut)
        PropiedadesIconButton(Me.ButtonLogOut)
        PropiedadesIconButton(Me.IconButton2)
        PropiedadesIconButton(Me.IconButton2)
        PropiedadesIconButton(Me.IconButton3)
        PropiedadesIconButton(Me.IconButton3)
        PropiedadesIconButton(Me.IconButton4)
        PropiedadesIconButton(Me.IconButton4)


        PropiedadesIconButton(Me.IconButton8)
        PropiedadesIconButton(Me.IconButton8)

        Dim a = PanelLateralOpciones.Controls.OfType(Of FontAwesome.Sharp.IconButton)
        For Each btn In a
            PropiedadesIconButton(btn)
        Next




        Dim d = PanelTop.Controls.OfType(Of FontAwesome.Sharp.IconButton)
        For Each btn3 In d
            PropiedadesIconButton(btn3)
        Next
    End Sub




#End Region
#Region "Panel Contenedor de Formularios"
    Private Async Sub CargarFormularioHijos(Of FormSend As {Form, New})() ' procedimiento con parametro generico "of" del tipo(clase) "form" y constructor vacio "New"
        Dim Formulario As Form  ' se declara una variable de tipo form
        'Formulario = PanelContenedorFormularios.Controls.OfType(Of FormSend)().FirstOrDefault() 'busca el formulario en la coleccion
        Dim forms = PanelContenedorFormularios.Controls.OfType(Of Form)
        For Each f In forms
            f.Close()
        Next
        ' PanelContenedorFormularios.Controls.Add(PictureBoxLogoContainer)
        Dim resp2 As Task = Task.Factory.StartNew(Sub()
                                                      PanelContenedorFormularios.Invoke(New MethodInvoker(Sub()

                                                                                                              Formulario = New FormSend With {
                                                        .TopLevel = False,
                                                        .FormBorderStyle = FormBorderStyle.None,
                                                        .Dock = DockStyle.Fill
                                                      }
                                                                                                              PanelContenedorFormularios.Controls.Add(Formulario)
                                                                                                              PanelContenedorFormularios.Tag = Formulario
                                                                                                              Formulario.Show()
                                                                                                              Formulario.BringToFront()
                                                                                                          End Sub))
                                                      'Await MostrarFormulario(Formulario)
                                                  End Sub)
        Await resp2
    End Sub
    Private Async Function MostrarFormulario(ByVal formul As Form) As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     PanelContenedorFormularios.Invoke(New MethodInvoker(Sub()
                                                                                                             PanelContenedorFormularios.Controls.Add(formul)
                                                                                                             PanelContenedorFormularios.Tag = formul
                                                                                                             formul.Show()
                                                                                                             formul.BringToFront()
                                                                                                         End Sub))
                                                 End Sub)
        Await resp
    End Function



    Private Sub ButtonMenu2_Click_1(sender As Object, e As EventArgs) Handles ButtonMenu2.Click
        CargarFormularioHijos(Of FormUsuarios)()

    End Sub

    Private Sub IconButton15_Click(sender As Object, e As EventArgs)
        CargarFormularioHijos(Of FormAgregarEmpresaCliente)()

    End Sub

    Private Sub IconButton14_Click(sender As Object, e As EventArgs)
        CargarFormularioHijos(Of FormAgregarNuevoEmpleadoCliente)()


    End Sub

    Private Sub IconButton13_Click(sender As Object, e As EventArgs)
        CargarFormularioHijos(Of FormAgregarNuevoTrabajador)()

    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs)
        CargarFormularioHijos(Of FormEspecificaciones)()

    End Sub


    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        CargarFormularioHijos(Of FormEstadoCPU)()

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        CargarFormularioHijos(Of FormEstadoMemoriaRAM)()

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        CargarFormularioHijos(Of FormEstadoDiscos)()

    End Sub


    Private Async Sub ButtonMenu4_Click_1(sender As Object, e As EventArgs) Handles ButtonMenu5.Click
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     ButtonMenu6.Invoke(New MethodInvoker(Sub()
                                                                                              If PanelSubMenu2.Visible = True Then

                                                                                                  ButtonMenu6.IconChar = FontAwesome.Sharp.IconChar.ChevronDown
                                                                                              Else
                                                                                                  ButtonMenu6.IconChar = FontAwesome.Sharp.IconChar.Cogs
                                                                                              End If
                                                                                          End Sub))
                                                     If PanelSubMenu1.Visible = True Then
                                                         BTSubMenu.HideSync(Me.PanelSubMenu1)
                                                     Else
                                                         BTSubMenu.ShowSync(Me.PanelSubMenu1)
                                                     End If
                                                 End Sub)
        Await resp
    End Sub

    Private Sub ButtonMenu9_Click(sender As Object, e As EventArgs) Handles ButtonMenu4.Click
        CargarFormularioHijos(Of FormEspecificaciones)()

    End Sub

    Private Async Sub ButtonMenu5_Click_1(sender As Object, e As EventArgs) Handles ButtonMenu6.Click
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     ButtonMenu6.Invoke(New MethodInvoker(Sub()
                                                                                              If PanelSubMenu2.Visible = True Then

                                                                                                  ButtonMenu6.IconChar = FontAwesome.Sharp.IconChar.ChevronDown
                                                                                              Else
                                                                                                  ButtonMenu6.IconChar = FontAwesome.Sharp.IconChar.Cogs
                                                                                              End If
                                                                                          End Sub))
                                                     If PanelSubMenu2.Visible = True Then
                                                         BTSubMenu.HideSync(Me.PanelSubMenu2)
                                                     Else
                                                         BTSubMenu.ShowSync(Me.PanelSubMenu2)
                                                     End If
                                                 End Sub)
        Await resp
    End Sub

    Private Sub ButtonLogOut_Click(sender As Object, e As EventArgs) Handles ButtonLogOut.Click
        Application.Exit()
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        CargarFormularioHijos(Of FormTemas)()

    End Sub

    Private Sub ButtonMenu3_Click(sender As Object, e As EventArgs) Handles ButtonMenu3.Click
        CargarFormularioHijos(Of FormAsistencias)()

    End Sub

    Private Sub IconButton11_Click(sender As Object, e As EventArgs) Handles IconButton11.Click
        CargarFormularioHijos(Of FormEscaner)()

    End Sub




#End Region
    Private Async Function AsignarToolTips() As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     Me.Invoke(
                                                     New MethodInvoker(Sub()
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonOcultarPanelLateral, "Aqui Oculta el Panel de Opciones")
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonClose, “Cerrar Aplicacion“)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonMinimizar, “Minimizar Aplicacion“)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonRestaurar, “Restaurar Tamaño“)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonMaximizar, “Maximizar Aplicacion“)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonPanelLateral, “Vista de Icono - Vista Completa“)
                                                                           'botones con letras e iconos
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonInicio, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonMenu2, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonMenu5, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonMenu5, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonMenu6, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonMenu6, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonLogOut, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.ButtonLogOut, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton2, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton2, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton3, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton3, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton4, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton4, ““)

                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton8, ““)
                                                                           ToolTipPrincipal.SetToolTip(Me.IconButton8, ““)
                                                                       End Sub)
                                                     )
                                                 End Sub)

        Await resp
    End Function
    Private Sub cargarEnMemoria()
        Using Form1 As New FormInicioGeneral
        End Using
    End Sub
End Class