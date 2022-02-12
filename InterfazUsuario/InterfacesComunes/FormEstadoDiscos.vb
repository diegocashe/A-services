Imports Comun
Public Class FormEstadoDiscos
    Dim tiempo As Integer = 0
    Dim datapoint1 As Bunifu.DataViz.WinForms.DataPoint = New Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_splineArea)
    Dim canvas As Bunifu.DataViz.WinForms.Canvas = New Bunifu.DataViz.WinForms.Canvas()
    Dim a As Boolean = False
    Private Async Sub FormEstadoCPU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await CargarColores()
    End Sub
    Private Sub BunifuDataViz1_Load(sender As Object, e As EventArgs) Handles ChartDatosDeRendimiento.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles ButtonIniciarMonitor.Click
        If TimerContadores.Enabled = True Then
            TimerContadores.Enabled = False
            ButtonIniciarMonitor.Text = "Iniciar Monitor"
        Else
            TimerContadores.Enabled = True
            ButtonIniciarMonitor.Text = "Pausar Monitor"
            Me.ChartDatosDeRendimiento.BringToFront()
            Me.LabelInfo.SendToBack()
        End If
    End Sub
    Private Async Sub TimerContadores_Tick(sender As Object, e As EventArgs) Handles TimerContadores.Tick
        Me.ChartDatosDeRendimiento.Refresh()
        Me.ChartDatosDeRendimiento.Update()
        Me.ChartDatosDeRendimiento.PerformAutoScale()
        Await (AgregarAlDataPoint(tiempo, PCTiempo.NextValue()))
        Await AgregarDatosALasBarras()
        tiempo = tiempo + 1
    End Sub
    Private Async Function AgregarAlDataPoint(ByVal x As Integer, ByVal y As Integer) As Task(Of Task)
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     datapoint1.addLabely(x.ToString, y.ToString)
                                                 End Sub)
        Await resp
        Return resp
    End Function
    Private Function AddDataAlObjetoCanvas(ByVal x As Bunifu.DataViz.WinForms.DataPoint) As Task(Of Bunifu.DataViz.WinForms.Canvas)
        Dim respcanvas As Task(Of Bunifu.DataViz.WinForms.Canvas) = Task.Factory.StartNew(Function()
                                                                                              canvas.addData(x)
                                                                                              Return canvas
                                                                                          End Function)
        Return respcanvas
    End Function
    Private Async Function cargarDatos() As Task
        Await AddDataAlObjetoCanvas(datapoint1)
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     ChartDatosDeRendimiento.Invoke(New MethodInvoker(Sub()
                                                                                                          Me.ChartDatosDeRendimiento.Render(canvas)
                                                                                                      End Sub))
                                                 End Sub)
        Await resp
    End Function
    Private Async Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles ButtonMostrarGrafico.Click
        Await cargarDatos()
    End Sub
    Private Async Function AgregarDatosALasBarras() As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     Me.ProgressBarDPC.Invoke(
                                                     New MethodInvoker(Sub()
                                                                           Me.ProgressBarDPC.Value = PCTiempo.NextValue
                                                                       End Sub))
                                                 End Sub)
        Dim resp2 As Task = Task.Factory.StartNew(Sub()
                                                      Me.ProgressBarDPC.Invoke(
                                                     New MethodInvoker(Sub()
                                                                           Me.ProgressBarTiempoUsuario2.Value = PCLectruraDisco.NextValue
                                                                       End Sub))
                                                  End Sub)
        Dim resp3 As Task = Task.Factory.StartNew(Sub()
                                                      Me.ProgressBarDPC.Invoke(
                                                     New MethodInvoker(Sub()
                                                                           Me.ProgressBarTiempoProcesador.Value = PCEscrituraDisco.NextValue
                                                                       End Sub))
                                                  End Sub)
        Await resp
        Await resp2
        Await resp3
    End Function
    Private Function CargarColores() As Task
        PropiedadesLabel(Me.Label1)
        PropiedadesLabel(Me.Label2)
        PropiedadesLabel(Me.Label3)
        PropiedadesLabel(Me.Label5)
        PropiedadesLabel(Me.LabelInfo)
        PropiedadesLabel(Me.Label4)
        Me.ProgressBarDPC.ForeColor = TemaActual.Letra
        Me.ProgressBarTiempoProcesador.ForeColor = TemaActual.Letra
        Me.ProgressBarTiempoUsuario2.ForeColor = TemaActual.Letra
        Me.Label1.ForeColor = TemaActual.Letra
        Me.PanelDeRendimiento.GradientBottomLeft = TemaActual.PanelLateral
        Me.PanelDeRendimiento.GradientBottomRight = TemaActual.Fondo
        Me.PanelDeRendimiento.GradientTopLeft = TemaActual.PanelLateral
        Me.PanelDeRendimiento.GradientTopRight = TemaActual.Fondo
        Me.BackColor = TemaActual.Fondo
        ChartDatosDeRendimiento.colorSet.Add(TemaActual.Letra)
        ChartDatosDeRendimiento.BackColor = TemaActual.Fondo
        ChartDatosDeRendimiento.AxisLineColor = TemaActual.PanelTop
        ChartDatosDeRendimiento.AxisYGridColor = TemaActual.PanelTop
        ChartDatosDeRendimiento.AxisXGridColor = TemaActual.PanelTop
        ChartDatosDeRendimiento.AxisXFontColor = TemaActual.Letra
        ChartDatosDeRendimiento.AxisYFontColor = TemaActual.Letra
        Return Task.Delay(1000)
    End Function

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles ButtonReiniciarGrafico.Click
        tiempo = 0
        datapoint1.clear()
        Me.ChartDatosDeRendimiento.Refresh()
    End Sub


End Class