Imports Comun
Imports Dominio
Public Class FormAgregarEmpresaCliente
    ReadOnly Insertar As New InsertarCliente
    Dim DataTemp As New DataSet
    Dim BinPais, BinEstados, BinMunicipios, BinParroquias, BinDepartamentos As New BindingSource
    Dim DepartamentosACrear(100) As Integer
    Dim indice As Integer = 0
    Dim nombre, rif, descripcion, tipo, NombreRed, IPV41, IPV42 As String
    Dim direccion, id_CLIENTE, IdDepartamento As Integer
    Private Sub FormFormAgregarEmpresaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignarColores()
        Me.MetroTab1.SelectTab(0)
        Me.DatosDeDirecciones()
        Me.DatosDepartamentos()
        Me.LlenarBindings()
    End Sub
#Region "Botones Atras y continuar"
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        nombre = TextBoxNombreEmpresa.Text
        rif = DropDownTipoRif.SelectedItem + TextBoxRif.Text
        descripcion = TextBoxDescripcionEmpresa.Text
        tipo = DropDownTipoEmpresa.SelectedValue
        direccion = DropDownParroquias.SelectedValue
        Me.MetroTab1.SelectTab(1)
        Me.BunifuProgressBar1.Value += 25
        MsgBox(DepartamentosACrear(0).ToString)
        'MsgBox(nombre + vbNewLine + rif + vbNewLine + descripcion + vbNewLine + tipo + vbNewLine + direccion.ToString())

    End Sub
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click

        Me.MetroTab1.SelectTab(2)
        Me.BunifuProgressBar1.Value += 25
    End Sub
    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        NombreRed = TextBoxRedCliente.Text
        IPV41 = TextBoxIPV41.Text
        IPV42 = TextBoxIPV42.Text

        Me.MetroTab1.SelectTab(3)
        Me.BunifuProgressBar1.Value += 25
        Label14.Text = nombre
        Label4.Text = indice.ToString
        Label3.Text = NombreRed
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Me.MetroTab1.SelectTab(0)
        Me.BunifuProgressBar1.Value -= 25
    End Sub
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Me.MetroTab1.SelectTab(1)
        Me.BunifuProgressBar1.Value -= 25
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Me.MetroTab1.SelectTab(2)
        Me.BunifuProgressBar1.Value -= 25
    End Sub

#End Region
    Sub AsignarColores()
        Me.BackColor = TemaActual.Fondo
        PropiedadesIconButton(ButtonAgregarDepartamento)
        PropiedadesIconButton(ButtonReiniciar)
        PropiedadesLabel(Me.Label1)
        PropiedadesLabel(Me.Label2)
        PropiedadesLabel(Me.Label3)
        PropiedadesLabel(Label4)
        PropiedadesLabel(Label13)
        PropiedadesLabel(Label8)
        PropiedadesLabel(Label6)
        PropiedadesLabel(Me.Label7)
        PropiedadesLabel(Me.Label9)
        PropiedadesLabel(Me.Label10)
        PropiedadesLabel(Me.Label11)
        PropiedadesLabel(Me.Label12)
        PropiedadesLabel(Label42)
        PropiedadesLabel(Me.Label29)
        PropiedadesLabel(Me.Label36)
        PropiedadesLabel(Me.Label14)
        PropiedadesLabel(Me.Label38)
        PropiedadesLabel(Label5)
        PropiedadesLabel(Label15)
        Me.MetroTab1.BackColor = TemaActual.PanelTop
        Me.MetroTabPage1DatosUsuario.BackColor = TemaActual.PanelTop
        Me.MetroTabPage2.BackColor = TemaActual.PanelTop
        Me.MetroTabPage3.BackColor = TemaActual.PanelTop
        TabPageRedCliente.BackColor = TemaActual.PanelTop
        Me.TexBoxDescripcionDelDepartamento.BackColor = TemaActual.PanelTop
        TexBoxDescripcionDelDepartamento.ForeColor = TemaActual.Letra
    End Sub

#Region "SELECCION DE IP"
    Private Sub BunifuRange2_RangeChanged(sender As Object, e As EventArgs) Handles RangeIPv41.RangeChanged
        TextBoxIPV41.Text = RangeIPv41.RangeMax.ToString
    End Sub

    Private Sub BunifuRange1_RangeChanged(sender As Object, e As EventArgs) Handles RangeIPv42.RangeChanged
        TextBoxIPV42.Text = RangeIPv42.RangeMax.ToString
    End Sub
#End Region

    Private Sub Button_Submit_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Try
            Dim resultado = MsgBox("¿Esta seguro de agregar nuevo Cliente?", vbYesNo + MsgBoxStyle.Exclamation, "Confirmacion")
            Select Case resultado
                Case vbYes
                    Try
                        InsertarCliente(nombre, rif, descripcion, tipo, direccion, NombreRed, IPV41, IPV42, indice)
                    Catch ex As Exception
                        MsgBox("Ups, creo que faltaron datos, intenta otra vez")
                        Me.MetroTab1.SelectTab(0)
                        Exit Select
                    End Try
                    VaciarDatos()
                    MsgBox("Se ha realizado con exito", vbOKOnly + vbInformation, "Enhorabuena")
                    Exit Select
                Case vbNo
                    VaciarDatos()
                    Exit Select
                Case Else
            End Select
            Me.BunifuProgressBar1.Value = 0
            Me.MetroTab1.SelectTab(0)
        Catch ex As Exception
            MsgBox("ERROR por favor revise los datos ingresados" + vbNewLine + ex.ToString)
        End Try
    End Sub
    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        VaciarDatosDepartamentos()
    End Sub

    Private Sub TextBoxNombreEmpresa_Click(sender As Object, e As EventArgs) Handles TextBoxNombreEmpresa.Click

    End Sub

    Private Sub MetroTab1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTab1.SelectedIndexChanged

    End Sub


#Region "Seleccion y llenado de dropdowns"
    Private Sub LlenarBindings()
        BinPais.DataSource = DataTemp.Tables("pais")
        BinEstados.DataSource = DataTemp.Tables("estados")
        BinMunicipios.DataSource = DataTemp.Tables("municipios")
        BinParroquias.DataSource = DataTemp.Tables("parroquias")
        BinDepartamentos.DataSource = DataTemp.Tables("departamentos")
        'BinPais.DataMember = "nombre"
    End Sub

#Region "Direcciones"
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
#Region "Departamentos"
    Private Sub DatosDepartamentos()
        Dim DatosCompletosDom = New DatosCompletos
        DatosCompletosDom.SolicitarDepartamentos(DataTemp)
    End Sub
    Private Sub DropDownParroquias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DropDownParroquias.SelectionChangeCommitted
        DropdownDepartamentos.Enabled = True
        With DropdownDepartamentos
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = BinDepartamentos
        End With
        TexBoxDescripcionDelDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BinDepartamentos, "DESCRIPCION", True))
    End Sub
    Private Sub ButtonAgregarDepartamento_Click(sender As Object, e As EventArgs) Handles ButtonAgregarDepartamento.Click
        Dim objitem As ListViewItem
        objitem = New ListViewItem(DropdownDepartamentos.SelectedValue.ToString)
        objitem.SubItems.Add(DropdownDepartamentos.SelectedItem(1).ToString)

        ListViewDepartamentos.Items.Add(objitem)
        ' ListViewVerificar.Items.Add(objitem)
        DepartamentosACrear(indice) = DropdownDepartamentos.SelectedItem(0)
        ListViewDepartamentos.Columns(0).Width = CInt((ListViewDepartamentos.Width / 2) - 12)
        ListViewDepartamentos.Columns(1).Width = CInt((ListViewDepartamentos.Width / 2) - 12)
        'ListViewVerificar.Columns(0).Width = CInt((ListViewDepartamentos.Width / 2) - 12)
        'ListViewVerificar.Columns(1).Width = CInt((ListViewDepartamentos.Width / 2) - 12)
        indice = indice + 1
    End Sub
#End Region


    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#End Region

    Private Sub VaciarDatos()
        Me.TextBoxNombreEmpresa.ResetText()
        Me.DropDownTipoRif.ResetText()
        Me.TextBoxRif.ResetText()
        Me.TextBoxDescripcionEmpresa.ResetText()
        Me.DropDownTipoEmpresa.ResetText()
        Me.DropDownPais.DataSource = Nothing
        Me.DropDownEstados.DataSource = Nothing
        Me.DropDownMunicipios.DataSource = Nothing
        Me.DropDownParroquias.DataSource = Nothing
        Me.DropdownDepartamentos.DataSource = Nothing
        Me.TextBoxIPV41.ResetText()
        Me.TextBoxIPV42.ResetText()
        Me.TextBoxRedCliente.ResetText()
        Me.TexBoxDescripcionDelDepartamento.ResetText()
        ' DepartamentosACrear.Clear()
        VaciarDatosDepartamentos()
        Erase DepartamentosACrear
        ReDim DepartamentosACrear(100)
        Me.LlenarBindings()
    End Sub
    Private Function InsertarCliente(nombre As String, rif As String, descripcion As String, tipo As String,
                                        direccion As String, NombreRed As String, IPV41 As String, IPV42 As String,
                                        indice As Integer) As Integer

        id_CLIENTE = Insertar.InsertarEnClientes(nombre, rif, descripcion, tipo, direccion.ToString)
        Insertar.InsertarRedClientes(NombreRed, IPV41, IPV42, id_CLIENTE.ToString)
        For i = 0 To indice
            Try
                Insertar.InsertarDepartamentosCliente(id_CLIENTE.ToString, DepartamentosACrear(i).ToString)
            Catch ex As Exception
                Exit For
            End Try
        Next
        Return 0
    End Function
    Private Sub VaciarDatosDepartamentos()
        ListViewDepartamentos.Clear()
        With ListViewDepartamentos
            .Columns.Add(" ID", CInt((ListViewDepartamentos.Width / 2) - 12), HorizontalAlignment.Left)
            .Columns.Add(" Departamento ", CInt((ListViewDepartamentos.Width / 2) - 12), HorizontalAlignment.Left)
        End With
        For i = 0 To indice
            Try
                DepartamentosACrear(i) = 0
            Catch ex As Exception
                Exit For
            End Try
        Next
        indice = 0
    End Sub

End Class

