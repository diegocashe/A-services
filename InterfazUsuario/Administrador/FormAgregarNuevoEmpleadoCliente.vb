Imports Comun
Imports Dominio
Public Class FormAgregarNuevoEmpleadoCliente
    Dim DataTemp As New DataSet
    Dim BinPais, BinEstados, BinMunicipios, BinParroquias, BinDepartamentosDeClientes, BinClientes As New BindingSource
    Private Sub FormAgregarNuevoEmpleadoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosDeDirecciones()
        DatosDeEmpresaYDepartamentos()
        LlenarBindings()
        Colores()
        Me.DTFechaContrato.MaxDate = Now()
        Me.DTFechanacimiento.MaxDate = Now()
    End Sub
    Private Sub Colores()
        Dim lbs = Me.Controls.OfType(Of Label)
        For Each lb In lbs
            PropiedadesLabel(lb)
        Next
        Me.BackColor = TemaActual.Fondo
    End Sub
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Dim dom As New Dominio.DatosTrabajadoresYTecnicos
        Dim idtemp As Integer
        Dim pnombre, snombre, papellido, sapellido, Cedula, genero, correo, telefono, direccion, NivelEstudio, FechaNacimiento, FechaContrato, IdDepartamentoDeEmpresa, usuario1, contra As String
        Try
            pnombre = TB_pnombre.Text
            snombre = TB_Snombre.Text
            papellido = TB_Papellido.Text
            sapellido = TB_Sapellido.Text
            Cedula = TB_cedula.Text
            genero = DropdonwGenero.SelectedItem
            correo = TB_correo.Text
            telefono = TB_Telefono.Text
            direccion = DropDownParroquias.SelectedValue.ToString()
            NivelEstudio = DropdownNivelEstudio.SelectedItem
            FechaNacimiento = DTFechanacimiento.Value.ToString("yyyy-MM-dd")
            FechaContrato = DTFechaContrato.Value.ToString("yyyy-MM-dd")
            IdDepartamentoDeEmpresa = DropdownEmpresaClienteDepartamento.SelectedValue.ToString()
            usuario1 = TBUsuario.Text
            contra = TBContra.Text
            Dim a = MsgBox("Esta seguro de agragar al nuevo empleado?", vbYesNo + vbQuestion, "Confirmacion")
            Select Case a
                Case vbYes
                    Try
                        idtemp = dom.InsertPers(pnombre, snombre, papellido, sapellido, Cedula, genero, correo, telefono, direccion, NivelEstudio, FechaNacimiento, FechaContrato)
                        dom.InsertarEmpCli(idtemp.ToString, IdDepartamentoDeEmpresa)
                        dom.InCuentaUsuario(usuario1, contra, idtemp.ToString, "4")
                        MsgBox("Se ha agregado el empleado correctamente.")
                        VaciarDatos()
                        TBUsuario.Text = ""
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                Case vbNo
                    VaciarDatos()
            End Select
        Catch ex As Exception
            MsgBox("Faltan datos por favor ingrese los datos completos")
        End Try
    End Sub
    Private Sub LlenarBindings()
        BinPais.DataSource = DataTemp.Tables("pais")
        BinEstados.DataSource = DataTemp.Tables("estados")
        BinMunicipios.DataSource = DataTemp.Tables("municipios")
        BinParroquias.DataSource = DataTemp.Tables("parroquias")
        BinClientes.DataSource = DataTemp.Tables("empresacliente")
        BinDepartamentosDeClientes.DataSource = DataTemp.Tables("departamentosdeclientes")
    End Sub
#Region "Llenado de dropsdowns"
    Private Sub DatosDeEmpresaYDepartamentos()
        Dim DatosCompletosDom = New DatosCompletos
        DatosCompletosDom.SolicitarDepartamentosDeCliente(DataTemp)
    End Sub
    Private Sub MetroComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownPais.SelectedIndexChanged
        DropDownEstados.Enabled = True
    End Sub
    Private Sub MetroComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownEstados.SelectedIndexChanged
        DropDownMunicipios.Enabled = True
    End Sub
    Private Sub MetroComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownMunicipios.SelectedIndexChanged
        DropDownParroquias.Enabled = True
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) 
        VaciarDatos()
    End Sub
    Private Sub DropDownEmpresa_Click(sender As Object, e As EventArgs) Handles DropDownEmpresa.Click
        With Me.DropDownEmpresa
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = BinClientes
        End With
    End Sub
    Private Sub DropDownEmpresa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DropDownEmpresa.SelectionChangeCommitted
        BinDepartamentosDeClientes.Filter = "idcliente =" + Me.DropDownEmpresa.SelectedValue.ToString
        With Me.DropdownEmpresaClienteDepartamento
            .DataSource = BinDepartamentosDeClientes
            .DisplayMember = "departamento"
            .ValueMember = "idDepartamentoCliente"
        End With
    End Sub
    Private Sub DatosDeDirecciones()
        Dim DatosCompletosDom = New DatosCompletos
        DatosCompletosDom.SolicitarDirecciones(DataTemp)
    End Sub
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
    Private Sub VaciarDatos()
        Dim Tbs = Me.Controls.OfType(Of MetroFramework.Controls.MetroTextBox)
        For Each Tb In Tbs
            Tb.ResetText()
        Next
        Dim Cbs = Me.Controls.OfType(Of MetroFramework.Controls.MetroComboBox)
        For Each Cb In Cbs
            Cb.ResetText()
            Cb.Refresh()
            Cb.DataSource = Nothing
        Next
    End Sub
End Class