Imports Comun
Imports Dominio
Public Class FormActualizarTrabajadores
    Dim datatemp As New DataSet
    Dim BinPais, BinEstados, BinMunicipios, BinParroquias, BinDatosDeTrabajadores As New BindingSource

    Private Sub FormActualizarTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colores()
        LlenarBindings()
        AsignarBindings()
    End Sub
    Private Sub LlenarBindings()
        Dim DatosCompletosDom = New DatosCompletos
        DatosCompletosDom.SolicitarDirecciones(datatemp)
        DatosCompletosDom.SolicitarDatosDeTrabajadores(datatemp)
        BinDatosDeTrabajadores.DataSource = datatemp.Tables("datostrabajadores")
        BinPais.DataSource = datatemp.Tables("pais")
        BinEstados.DataSource = datatemp.Tables("estados")
        BinMunicipios.DataSource = datatemp.Tables("municipios")
        BinParroquias.DataSource = datatemp.Tables("parroquias")
    End Sub

    Private Sub AsignarBindings()

        DropdownTrabajador.DataSource = BinDatosDeTrabajadores
        DropdownTrabajador.DisplayMember = "nombre completo"
        DropdownTrabajador.ValueMember = "id"


        LabelPnombre.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "pnombre"))
        LabelSnombre.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "snombre"))
        LabelPapellido.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "papellido"))
        LabelSapellido.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "sapellido"))
        LabelCi.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "ci"))
        LabelTelefono.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "telefono"))
        LabelNivelEstudio.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "NIVEL_ESTUDIO"))
        LabelEspecialidad.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "ESPECIALIDAD"))
        LabelCuentaDeUsuario.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "usuario"))
        LabelCorreo.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "CORREO"))
        TextBoxDireccion.DataBindings.Add(New Binding("text", BinDatosDeTrabajadores, "Direccion Completa"))

        TB_pnombre.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "pnombre"))
        TB_Snombre.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "snombre"))
        TB_Papellido.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "papellido"))
        TB_Sapellido.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "sapellido"))
        TB_Telefono.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "telefono"))

        TBUsuario.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "usuario"))
        TB_correo.DataBindings.Add(New Binding("Text", BinDatosDeTrabajadores, "CORREO"))

        DropdownNivelEstudio.SelectedItem = DropdownTrabajador.SelectedItem(11)





    End Sub
#Region "Llenado de dropsdowns"

    Private Sub DropDownPais_MouseDown(sender As Object, e As MouseEventArgs) Handles DropDownPais.MouseDown
        With DropDownPais
            .DisplayMember = "nombre"
            .ValueMember = "codigo"
            .DataSource = BinPais
        End With
    End Sub
    Private Sub DropDownPais_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DropDownPais.SelectionChangeCommitted
        DropDownEstados.Enabled = True
        BinEstados.Filter = "codigo_pais ='" & DropDownPais.SelectedValue.ToString() & "'"
        With DropDownEstados
            .DisplayMember = "estado"
            .ValueMember = "id_estado"
            .DataSource = BinEstados
        End With
    End Sub
    Private Sub DropDownEstados_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DropDownEstados.SelectionChangeCommitted
        DropDownMunicipios.Enabled = True
        BinMunicipios.Filter = "id_estado = " & DropDownEstados.SelectedValue.ToString
        With DropDownMunicipios
            .DisplayMember = "municipio"
            .ValueMember = "id_municipio"
            .DataSource = BinMunicipios
        End With
    End Sub


    Private Sub DropDownMunicipios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownMunicipios.SelectionChangeCommitted
        DropDownParroquias.Enabled = True
        BinParroquias.Filter = "id_municipio = " & DropDownMunicipios.SelectedValue.ToString
        With DropDownParroquias
            .DisplayMember = "parroquia"
            .ValueMember = "id_parroquia"
            .DataSource = BinParroquias
        End With
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If Me.Panel1.Visible = True Then
            Me.BTModificarDatos.HideSync(Me.Panel1)
            Me.DropdownTrabajador.Enabled = True
        Else
            Me.BTModificarDatos.ShowSync(Me.Panel1)
            Me.DropdownTrabajador.Enabled = False
        End If
    End Sub
#End Region

    Private Sub colores()
        Me.BackColor = TemaActual.Fondo
        Dim lbs = Me.Controls.OfType(Of Label)
        For Each LB In lbs
            PropiedadesLabel(LB)
        Next
        Me.TextBoxDireccion.BackColor = TemaActual.Fondo
        Me.TextBoxDireccion.ForeColor = TemaActual.Letra
        Me.Panel1.BackColor = TemaActual.PanelLateral
        Dim lbs2 = FlowLayoutPanel1.Controls.OfType(Of Label)
        For Each lb2 In lbs2
            PropiedadesLabel(lb2)
        Next
        If TemaActual.IsDark = False Then
            Me.PictureBoxLogo.Image = My.Resources._7_LogoNegroSinFondo
        End If
        PropiedadesIconButton(ButtonClose)
    End Sub
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Dim dom As New RecibirDatosActualizados
        Dim idtemp As String


        Try
            Dim pnombre As String = LabelPnombre.Text
            Dim snombre As String = LabelSnombre.Text
            Dim papellido As String = LabelPapellido.Text
            Dim sapellido As String = LabelSapellido.Text
            Dim correo As String = LabelCorreo.Text
            Dim telefono As String = LabelTelefono.Text
            Dim direccion As String = DropdownTrabajador.SelectedItem(25)
            Dim NivelEstudio As String = LabelNivelEstudio.Text
            Dim user As String = LabelCuentaDeUsuario.Text
            Dim pass As String

            idtemp = DropdownTrabajador.SelectedValue.ToString
            If LabelPnombre.Text <> TB_pnombre.Text Then
                pnombre = TB_pnombre.Text
            End If
            If snombre <> TB_Snombre.Text Then
                snombre = TB_Snombre.Text
            End If
            If papellido <> TB_Papellido.Text Then
                papellido = TB_Papellido.Text
            End If
            If sapellido <> TB_Sapellido.Text Then
                sapellido = TB_Sapellido.Text
            End If
            If sapellido <> TB_Sapellido.Text Then
                sapellido = TB_Sapellido.Text
            End If
            If correo <> TB_correo.Text Then
                correo = TB_correo.Text
            End If
            If telefono <> TB_Telefono.Text Then
                telefono = TB_Telefono.Text
            End If
            If DropDownParroquias.SelectedItem Is Nothing Then
                direccion = DropdownTrabajador.SelectedItem(25)
            Else
                direccion = DropDownParroquias.SelectedValue
            End If
            If DropdownNivelEstudio.SelectedItem Is Nothing Then
                NivelEstudio = LabelNivelEstudio.Text

            Else
                NivelEstudio = DropdownNivelEstudio.SelectedItem
            End If
            If user <> TBUsuario.Text Then
                user = TBUsuario.Text
            End If

            pass = TBContra.Text
            Dim a = MsgBox("Esta seguro de actualizar al trabajador?", vbYesNo + vbQuestion, "Confirmacion")
            Select Case a
                Case vbYes
                    Try
                        dom.ActualizarTrabajadoresDom(idtemp, pnombre, snombre, papellido, sapellido, correo, telefono, direccion, NivelEstudio, user, pass)
                        MsgBox("Se ha agregado el Tecnico correctamente.")
                        VaciarDatos()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                Case vbNo
                    VaciarDatos()
                Case Else
                    VaciarDatos()
            End Select
        Catch ex As Exception
            MsgBox("Falto llenar un dato Por favor Verifique")
        End Try
        AsignarBindings()
    End Sub
    Private Sub VaciarDatos()
        Dim Tbs = Me.Controls.OfType(Of MetroFramework.Controls.MetroTextBox)
        For Each Tb In Tbs
            Tb.DataBindings.Clear()
            ' Tb.ResetText()
        Next
        Dim Tbs2 = FlowLayoutPanel1.Controls.OfType(Of MetroFramework.Controls.MetroTextBox)
        For Each Tb2 In Tbs2
            '   Tb2.ResetText()
            Tb2.DataBindings.Clear()
        Next
        Dim Cbs = Me.Controls.OfType(Of MetroFramework.Controls.MetroComboBox)
        For Each Cb In Cbs
            '  Cb.ResetText()
            Cb.Refresh()
            Cb.DataSource = Nothing
            Cb.DataBindings.Clear()
        Next
        Dim Cbs2 = FlowLayoutPanel1.Controls.OfType(Of MetroFramework.Controls.MetroComboBox)
        For Each Cb2 In Cbs2
            ' Cb2.ResetText()
            Cb2.Refresh()
            Cb2.DataSource = Nothing
            Cb2.DataBindings.Clear()
        Next
        Dim lbs = Me.Controls.OfType(Of Label)
        For Each lb In lbs
            lb.DataBindings.Clear()
            '  lb.ResetText()
        Next
        Dim Tbxs = Me.Controls.OfType(Of TextBox)
        For Each tbx In Tbxs
            ' tbx.ResetText()
            tbx.Refresh()
            tbx.DataBindings.Clear()
        Next
        Dim Tbxs2 = FlowLayoutPanel1.Controls.OfType(Of TextBox)
        For Each tbx2 In Tbxs2
            ' tbx2.ResetText()
            tbx2.Refresh()
            tbx2.DataBindings.Clear()
        Next

    End Sub
End Class