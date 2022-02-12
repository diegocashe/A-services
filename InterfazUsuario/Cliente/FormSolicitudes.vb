Imports System.ComponentModel
Imports Comun
Imports Dominio

Public Class FormSolicitudes
    Dim Datatemp As New DataSet
    Dim BinDatosParaSolicitudes, BinPosiblesFallas As New BindingSource
    Dim coleccion As New ControlCollection(Me)
    Private Sub FormSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignarColores()
        Me.MetroTabControl2DatosMaquina.SelectTab(0)
        AsignarBindings()
        DatosAutomaticos()

        'Dim a = DatoscompletosclientesBindingSource.Find(A_servicesDataSet1.datoscompletosclientes.USUARIOColumn.ColumnName, Usuario)
        'DatoscompletosclientesBindingSource.
        'DatoscompletosclientesBindingSource.Filter = "USUARIO = 'Dayanaiga'" '+ Usuario.TRIM
        'MsgBox(Usuario + " " + a.ToString)

        'DatoscompletosclientesBindingSource.Position =
    End Sub
#Region "Botones Atras y continuar"
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.MetroTabControl2DatosMaquina.SelectTab(1)
    End Sub
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Me.MetroTabControl2DatosMaquina.SelectTab(2)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Me.MetroTabControl2DatosMaquina.SelectTab(3)
    End Sub
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Me.MetroTabControl2DatosMaquina.SelectTab(0)
    End Sub
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Me.MetroTabControl2DatosMaquina.SelectTab(1)
    End Sub
    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Me.MetroTabControl2DatosMaquina.SelectTab(2)
    End Sub
#End Region
    Sub AsignarColores()
        Me.BackColor = TemaActual.Fondo
        '''''''''''''''''''''''''' iconos


        ''''''''''''''''''''''''' labels 
        PropiedadesLabel(Me.Label1)
        PropiedadesLabel(Me.Label2)
        PropiedadesLabel(Me.LabelUsuario)
        PropiedadesLabel(Me.LabelNombrePropietarioCuenta)
        PropiedadesLabel(Me.LabelDepartamento)
        PropiedadesLabel(Me.LabelDependencia)
        PropiedadesLabel(Me.Label7)
        'PropiedadesLabel(Me.Label8)
        PropiedadesLabel(Me.Label9)
        PropiedadesLabel(Me.Label10)
        PropiedadesLabel(Me.Label11)
        PropiedadesLabel(Me.Label12)

        PropiedadesLabel(Me.Label14)
        PropiedadesLabel(Me.LabelFechaActual)
        'PropiedadesLabel(Me.Label16)
        PropiedadesLabel(Me.LabelDireccion)


        PropiedadesLabel(Me.Label25)
        PropiedadesLabel(Me.LabelDireccionDeXML)
        PropiedadesLabel(Me.Label27)
        PropiedadesLabel(Me.LabelMac)
        PropiedadesLabel(Me.Label29)
        PropiedadesLabel(Me.LabelNombreEquipo)

        PropiedadesLabel(Me.Label34)
        'PropiedadesLabel(Me.Label35)
        PropiedadesLabel(Me.Label36)
        PropiedadesLabel(Me.LabelUsuarioEnviar)
        PropiedadesLabel(Me.Label38)

        PropiedadesLabel(Me.Label40)
        PropiedadesLabel(Me.LabelFallaComunEnviar)
        PropiedadesLabel(Me.Label42)
        PropiedadesLabel(Me.LabelNombreMaquinaEnviar)
        '' metro Pages Containers
        Me.MetroTabControl2DatosMaquina.BackColor = TemaActual.PanelTop
        Me.MetroTabPage1DatosUsuario.BackColor = TemaActual.PanelTop
        Me.MetroTabPage2.BackColor = TemaActual.PanelTop
        Me.MetroTabPage3MoreInfo.BackColor = TemaActual.PanelTop
        Me.MetroTabPage4.BackColor = TemaActual.PanelTop
    End Sub
    Private Sub AsignarBindings()
        Dim dom As New DatosCompletos
        dom.SolicitarDatosParaSolicitudes(Datatemp)
        dom.SolicitarFallasComunes(Datatemp)
        BinDatosParaSolicitudes.DataSource = Datatemp.Tables("DatosParaSolicitudes")
        BinDatosParaSolicitudes.Filter = "USUARIO = '" & Usuario & "'"
        BinPosiblesFallas.DataSource = Datatemp.Tables("fallascomunes")
    End Sub
    Private Sub DatosAutomaticos()
        LabelUsuario.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "USUARIO"))
        LabelNombrePropietarioCuenta.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "PROPIETARIO"))
        LabelDependencia.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "DEPENDENCIA"))
        LabelDepartamento.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "DEPARTAMENTO"))
        LabelDireccion.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "Direccion Usuario"))
        LabelFechaActual.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "Fecha"))
        LabelNombreEquipo.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "nombreequipo"))
        LabelMac.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "dmac"))
        LabelDireccionDeXML.DataBindings.Add(New Binding("text", BinDatosParaSolicitudes, "dxml"))
        DropdownFallasComunes.DataSource = BinPosiblesFallas
        DropdownFallasComunes.DisplayMember = "NOMBRE_FALLA"
        DropdownFallasComunes.ValueMember = "ID_FALLAS"
        TextBoxFallaComun.DataBindings.Add(New Binding("text", BinPosiblesFallas, "DESCRIPCION"))
        LabelUsuarioEnviar.Text = LabelUsuario.Text
        LabelNombreMaquinaEnviar.Text = LabelNombreEquipo.Text
        LabelFallaComunEnviar.DataBindings.Add(New Binding("text", BinPosiblesFallas, "NOMBRE_FALLA"))
        DropDownUser.DataSource = BinDatosParaSolicitudes
        DropDownUser.ValueMember = "idempleado"
        DropDownUser.DisplayMember = "PROPIETARIO"
    End Sub
    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Dim dom As New SolicitudesYAsistenciasDom
        Dim idusuario, tipofalla, descripcion As String
        Try
            idusuario = DropDownUser.SelectedValue
            tipofalla = DropdownFallasComunes.SelectedValue
            descripcion = TextBoxDescripcion.Text
            Try
                dom.InsertarSolicitudDom(idusuario, tipofalla, descripcion)
                MsgBox("Solicitud Enviada con exito", vbOKOnly + MsgBoxStyle.MsgBoxRight, "Success")
                Me.MetroTabControl2DatosMaquina.SelectTab(0)
            Catch ex As Exception
                MsgBox("Ups, problema" & vbNewLine & ex.ToString(), vbOKOnly + MsgBoxStyle.Critical, "Error")
            End Try
        Catch ex As Exception
            MsgBox("Ups, problema, intentalo otra vez", vbOKOnly + MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Class
