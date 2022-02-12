Imports Comun
Imports Dominio
Public Class FormActualizarDatosCliente
    Dim datatemp As New DataSet
    Dim BinDatosCompletosCliente, BinPais, BinEstados, BinMunicipios, BinParroquias As New BindingSource
    Private Sub FormActualizarDatosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colores()
        Me.llenarBindings()
        Me.AsignarDatosBinding()
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
    Private Sub llenarBindings()
        Dim Recibir As New DatosCompletos
        Recibir.SolicitarDirecciones(datatemp)
        Recibir.DatosCompletosClienteTodos(datatemp)
        BinDatosCompletosCliente.DataSource = datatemp.Tables("datosdeclientes")
        BinPais.DataSource = datatemp.Tables("pais")
        BinEstados.DataSource = datatemp.Tables("estados")
        BinMunicipios.DataSource = datatemp.Tables("municipios")
        BinParroquias.DataSource = datatemp.Tables("parroquias")
    End Sub
    Private Sub VaciarBindings()
        BinDatosCompletosCliente.ResetBindings(True)
        BinPais.ResetBindings(True)
        BinEstados.ResetBindings(True)
        BinMunicipios.ResetBindings(True)
        BinParroquias.ResetBindings(True)
    End Sub
    Private Sub AsignarDatosBinding()
        LabelNombre.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "empresa"))
        LabelRif.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "rif"))
        LabelTipo.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "tipo"))
        TextBoxDireccion.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "direccion completa"))
        TextBoxDescrip.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "descripcion"))
        TextBoxNombre.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "empresa"))
        TextBoxRif.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "rif"))
        DropDownTipo.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "tipo"))
        TextBoxDescripcion.DataBindings.Add(New Binding("Text", BinDatosCompletosCliente, "descripcion"))
        DropdownCliente.DataSource = BinDatosCompletosCliente
        DropdownCliente.DisplayMember = "Empresa"
        DropdownCliente.ValueMember = "idempresa"
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

#End Region

    Private Sub colores()
        Me.BackColor = TemaActual.Fondo
        Dim lbs = Me.Controls.OfType(Of Label)
        For Each LB In lbs
            PropiedadesLabel(LB)
        Next
        Me.TextBoxDescrip.BackColor = TemaActual.Fondo
        Me.TextBoxDescrip.ForeColor = TemaActual.Letra
        Me.TextBoxDireccion.BackColor = TemaActual.Fondo
        Me.TextBoxDireccion.ForeColor = TemaActual.Letra
        Me.Panel1.BackColor = TemaActual.PanelLateral
        Dim lbs2 = Panel1.Controls.OfType(Of Label)
        For Each lb2 In lbs2
            PropiedadesLabel(lb2)
        Next
        If TemaActual.IsDark = False Then
            Me.PictureBoxLogo.Image = My.Resources._7_LogoNegroSinFondo
        End If
        PropiedadesIconButton(ButtonClose)
    End Sub
    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If Panel1.Visible = False Then
            BTModificarDatos.ShowSync(Me.Panel1)
        Else
            BTModificarDatos.HideSync(Me.Panel1)
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Dim update As New InsertarCliente
        Dim idtemp As String = DropdownCliente.SelectedValue.ToString
        Dim nombret As String = LabelNombre.Text
        Dim rif As String = LabelRif.Text
        Dim descripcion As String = TextBoxDescrip.Text
        DropDownTipo.SelectedItem = LabelTipo.Text
        Dim tipo As String = DropDownTipo.SelectedItem
        Dim parroquia As String

        Try
            idtemp = DropdownCliente.SelectedValue
            If TextBoxNombre.Text <> LabelNombre.Text Then
                nombret = TextBoxNombre.Text
            End If
            If TextBoxRif.Text <> LabelRif.Text Then
                rif = TextBoxRif.Text
            End If
            If TextBoxDescrip.Text <> TextBoxDescripcion.Text Then
                descripcion = TextBoxDescripcion.Text
            End If

            If DropDownParroquias.SelectedItem Is Nothing Then
                parroquia = DropdownCliente.SelectedItem(10).ToString
            Else
                parroquia = DropDownParroquias.SelectedValue
            End If

            Dim resultado = MsgBox("¿Esta seguro de actualizar al Cliente?", vbYesNo + vbQuestion, "Mensaje especial")
            Try
                Select Case resultado
                    Case vbYes
                        update.ActualizarCliente(idtemp, nombret, rif, descripcion, tipo, parroquia)
                        MessageBox.Show("Se ha actualizado con exito")

                        BinDatosCompletosCliente.ResetBindings(True)
                        Exit Select
                    Case vbNo
                        Exit Select
                End Select
            Catch ex As Exception
                MsgBox("Error" + vbNewLine + ex.ToString(), vbOKOnly + vbCritical, "Error")
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
            '  MsgBox("Faltan datos, por favor verifique.", vbOKOnly + vbInformation, "Error")
        End Try


    End Sub

End Class