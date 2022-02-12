Imports Dominio
Imports Comun
Public Class FormMaquina
    Dim RecibirDatosCompletos As New DatosCompletos
    Private Sub FormInicioGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorHeredado()
        DatosDeListView()
        DatosLabel()
    End Sub
    Private Sub DatosLabel()
        Label1.Text = "Hola " + Nombre
    End Sub

    Private Sub ButtonReiniciarListView_Click(sender As Object, e As EventArgs) Handles ButtonReiniciarListView.Click
        DatosDeListView()
    End Sub
    Private Sub ColorHeredado()
        Me.BackColor = TemaActual.Fondo
        Me.ForeColor = TemaActual.Letra
        'Me.Panel4.BackColor = TemaActual.PanelTop
        PropiedadesPanelGradient(Me.PanelGradientTop)
        Me.ListViewDatosCompletos.BackColor = TemaActual.Fondo
        Me.ListViewDatosCompletos.ForeColor = TemaActual.Letra
        ' PropiedadesIconButton(Me.ButtonReiniciarListView)
        Dim lbs = Me.PanelGradientTop.Controls.OfType(Of Label)

        For Each lb In lbs
            PropiedadesLabel(lb)
        Next
        Dim IBtn = Me.PanelGradientTop.Controls.OfType(Of FontAwesome.Sharp.IconButton)
        For Each ibn In IBtn
            PropiedadesIconButton(ibn)
        Next
    End Sub
    Private Sub DatosDeListView()
        Dim tabla = RecibirDatosCompletos.DatosCompletosCliente("cliente")
        With ListViewDatosCompletos
            .Clear()
            .Columns.Add(" Información ", 40, HorizontalAlignment.Left)
            .Columns.Add(" Valor ", 50, HorizontalAlignment.Left)
            .View = View.Details
        End With
        Dim columnas = tabla.Columns
        Dim LectorDatos = tabla.CreateDataReader()

        Dim objitem As ListViewItem
        Dim i As Integer = 0
        While LectorDatos.Read()
            For i = 0 To LectorDatos.FieldCount
                Try
                    objitem = New ListViewItem(LectorDatos.GetName(i))
                    objitem.SubItems.Add(LectorDatos.GetValue(i).ToString())
                    'ListView1.Items.Add(objitem)
                    ListViewDatosCompletos.Items.Add(objitem)

                Catch ex As Exception
                    Exit While
                End Try
            Next

        End While
        ListViewDatosCompletos.Columns(0).Width = CInt((ListViewDatosCompletos.Width / 2) - 12)
        ListViewDatosCompletos.Columns(1).Width = CInt((ListViewDatosCompletos.Width / 2) - 12)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class