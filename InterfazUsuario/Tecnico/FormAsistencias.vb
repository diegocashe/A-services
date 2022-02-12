Imports Dominio
Imports Comun
Public Class FormAsistencias
    Dim DataTemp As New DataSet
    Dim BinSolicitudes, BinServicios As New BindingSource
    Private Sub FormAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colores()
        Llenarbindings()
    End Sub
    Private Sub Llenarbindings()
        Dim dom As New DatosCompletos
        dom.SolicitarSolicitudesSinAtender(DataTemp)
        dom.SolicitarServicios(DataTemp)
        BinSolicitudes.DataSource = DataTemp.Tables("datoscompletossolicitudes")
        BinSolicitudes.Filter = "ID_ASISTENCIAS = 'No Aplica'"
        BinServicios.DataSource = DataTemp.Tables("servicios")
        AsignarBinding()
    End Sub
    Private Sub AsignarBinding()
        With DropDownSolicitudes
            .DataSource = BinSolicitudes
            .DisplayMember = "idsolicitud"
            .ValueMember = "idsolicitud"
        End With
        With DropDownServicio
            .DataSource = BinServicios
            .DisplayMember = "NOMBRE"
            .ValueMember = "ID_SERVICIOS"
        End With
        TextBoxDescripcionSolicitud.DataBindings.Add(New Binding("text", BinSolicitudes, "DESCSOL"))
    End Sub
    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Dim dom As New SolicitudesYAsistenciasDom
        Try
            Dim tipo, accion, idsolicitud, IdTecnico, servicio, descripcion As String
            tipo = DropDownTipo.SelectedItem
            accion = DropdownAccion.SelectedItem
            idsolicitud = DropDownSolicitudes.SelectedValue
            IdTecnico = UsuarioActual.id
            servicio = DropDownServicio.SelectedValue
            descripcion = TextBoxDescripcion.Text
            Try
                Dim a = MsgBox("Esta seguro de agregar la asistencia a la Base de datos?", vbYesNo + vbQuestion, "Confirmacion")
                Select Case a
                    Case vbYes
                        dom.InsertarAsistenciaDom(tipo, accion, idsolicitud, IdTecnico, servicio, descripcion)
                        MsgBox("Se ha realizado con exito", vbOKOnly + vbMsgBoxRight, "Success")
                        vaciar()
                    Case vbNo
                        Exit Select
                End Select
            Catch ex As Exception
                MsgBox("No se concreto la asistencia" + vbOKOnly + vbInformation, "ERROR")

                vaciar()
            End Try
        Catch ex As Exception
            MsgBox("Faltan datos Por Favor revise.", vbOKOnly + vbInformation, "ERROR")
        End Try
    End Sub
    Private Sub colores()
        Dim lbs = Me.Controls.OfType(Of Label)
        For Each lb In lbs
            PropiedadesLabel(lb)
        Next
        Me.BackColor = TemaActual.Fondo
        TextBoxDescripcionSolicitud.BackColor = TemaActual.Fondo
        TextBoxDescripcionSolicitud.ForeColor = TemaActual.Letra
    End Sub
    Private Sub vaciar()
        Dim a = Me.Controls.OfType(Of MetroFramework.Controls.MetroComboBox)
        For Each mcb In a
            mcb.DataSource = Nothing
        Next
        TextBoxDescripcion.ResetText()
    End Sub
End Class