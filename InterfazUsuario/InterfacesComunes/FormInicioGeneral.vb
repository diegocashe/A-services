Imports System.Management
Imports Comun
Imports Bunifu.DataViz.WinForms.DataPoint
Public Class FormInicioGeneral
    Dim tiempo As Integer = 0
    Dim canvas As Bunifu.DataViz.WinForms.Canvas = New Bunifu.DataViz.WinForms.Canvas()
    Dim PunteroDeDataRendimiento As Bunifu.DataViz.WinForms.DataPoint = New Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_splineArea)
    Private Async Sub FormInicioGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await ColorHeredado()
        Await DatosDeLabels()
        Await CargarDatosListView()
        Await GraficoTortaMemoria()
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
    Private Async Function GraficoTortaMemoria() As Task
        Dim resp As Task = Task.Factory.StartNew(
        Sub()
            ChartEspacioDiscoDuro.Invoke(New MethodInvoker(
            Sub()
                Dim canvas As Bunifu.DataViz.WinForms.Canvas = New Bunifu.DataViz.WinForms.Canvas()
                Dim datapoint1 As Bunifu.DataViz.WinForms.DataPoint
                ChartEspacioDiscoDuro.colorSet.Add(Color.FromArgb(44, 187, 76))
                ChartEspacioDiscoDuro.colorSet.Add(Color.FromArgb(247, 70, 67))
                ChartEspacioDiscoDuro.BackColor = TemaActual.Fondo
                datapoint1 = New Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_doughnut)
                datapoint1.addLabely("Espacio Libre:" + Format(100 - PC_PorcEspacioLibreDiscoDuro.NextValue(), "0.0").ToString() + "%", (100 - PC_PorcEspacioLibreDiscoDuro.NextValue))
                datapoint1.addLabely("Espacio Utilizado: " + Format(PC_PorcEspacioLibreDiscoDuro.NextValue(), "0.0").ToString() + "%", PC_PorcEspacioLibreDiscoDuro.NextValue)

                canvas.addData(datapoint1)
                ChartEspacioDiscoDuro.Render(canvas)
            End Sub
            ))
        End Sub
        )

        Await resp
    End Function
    Private Function TransformarEnGB(ByVal NumeroEnBytes As String) As Integer
        Dim NumeroEnGigaBytes As Double
        Dim temp As Double = CDbl(NumeroEnBytes)
        NumeroEnGigaBytes = temp / 1000000000 '1073741824

        Return NumeroEnGigaBytes
    End Function

    Private Async Sub TimerGrafico_Tick(sender As Object, e As EventArgs) Handles TimerGrafico.Tick
        If tiempo = 0 Then
            Await CargarChartRendimiento()
        End If
        Await LLenarElPunterodeData(tiempo, PCProcesador.NextValue)
        Me.ChartRendimiento.Refresh()
        Me.LabelConteo.Text = tiempo.ToString()
        tiempo += 1
        If tiempo = 10 Then
            TimerGrafico.Enabled = False
            Me.ButtonIniciarGrafico.IconChar = FontAwesome.Sharp.IconChar.Play
            tiempo = 0
        End If
    End Sub
    Private Async Function LLenarElPunterodeData(x As Integer, y As Integer) As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     PunteroDeDataRendimiento.addLabely(x.ToString, y.ToString())
                                                 End Sub)
        Await resp
    End Function
    Private Async Function CargarChartRendimiento() As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     ChartRendimiento.colorSet.Add(TemaActual.Letra)
                                                     canvas.addData(PunteroDeDataRendimiento)
                                                 End Sub)
        Me.ChartRendimiento.Render(canvas)
        Await resp
    End Function
    Private Async Function CargarDatosListView() As Task
        Dim consultaSQLArquitectura As String = "SELECT * FROM WIN32_DiskDrive"
        Dim objArquitectura As New ManagementObjectSearcher(consultaSQLArquitectura)
        Dim inter As ULong

        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     ListViewDatosDiagnostico.Invoke(
                                                     New MethodInvoker(Sub()
                                                                           For Each info As ManagementObject In objArquitectura.Get()
                                                                               inter = info.Properties("Size").Value
                                                                           Next info
                                                                           Try
                                                                               ' agrega dos encabezados  
                                                                               With ListViewDatosDiagnostico
                                                                                   .Clear()
                                                                                   .Columns.Add(" Información ", 40, HorizontalAlignment.Left)
                                                                                   .Columns.Add(" Valor ", 50, HorizontalAlignment.Left)
                                                                                   .View = View.Details
                                                                               End With
                                                                               ' agrega los items  
                                                                               With My.Computer.Info
                                                                                   ' Referencia al item  
                                                                                   Dim ObjItem As ListViewItem
                                                                                   ' ram físca libre  
                                                                                   '''''''''''''''''''''''''''''''''''''''  
                                                                                   ObjItem = New ListViewItem("Memoria Física Disponible ")
                                                                                   ObjItem.SubItems.Add(((.AvailablePhysicalMemory) / 1048576) & " MB")
                                                                                   ListViewDatosDiagnostico.Items.Add(ObjItem)

                                                                                   ' Ram fisica total  
                                                                                   '''''''''''''''''''''''''''''''''''''''  
                                                                                   ObjItem = New ListViewItem("Memoria física total ")
                                                                                   ObjItem.SubItems.Add(((.TotalPhysicalMemory) / 1048576) & " MB")
                                                                                   ListViewDatosDiagnostico.Items.Add(ObjItem)

                                                                                   ' Ram Virtual libre  
                                                                                   '''''''''''''''''''''''''''''''''''''''  
                                                                                   ObjItem = New ListViewItem("Memoria Virtual libre")
                                                                                   ObjItem.SubItems.Add(((.AvailableVirtualMemory) / 1048576) & " MB")
                                                                                   ListViewDatosDiagnostico.Items.Add(ObjItem)

                                                                                   ' memoria virtual total  
                                                                                   '''''''''''''''''''''''''''''''''''''''  
                                                                                   ObjItem = New ListViewItem("Memoria virtual total")
                                                                                   ObjItem.SubItems.Add(((.TotalVirtualMemory) / 1048576) & " MB")
                                                                                   ListViewDatosDiagnostico.Items.Add(ObjItem)
                                                                                   ObjItem = New ListViewItem("Memoria ROM total")
                                                                                   ObjItem.SubItems.Add(TransformarEnGB(inter).ToString() + " GB")
                                                                                   ListViewDatosDiagnostico.Items.Add(ObjItem)
                                                                                   ObjItem = New ListViewItem("Memoria ROM Utilizada")
                                                                                   ObjItem.SubItems.Add((PCMegabytesDisponibles.NextValue / 1000).ToString() + " GB")
                                                                                   ListViewDatosDiagnostico.Items.Add(ObjItem)
                                                                                   ObjItem = New ListViewItem("Porcentaje de Memoria ROM Libre ")
                                                                                   ObjItem.SubItems.Add(Format(PC_PorcEspacioLibreDiscoDuro.NextValue, "0.0").ToString() + "%")
                                                                                   ListViewDatosDiagnostico.Items.Add(ObjItem)
                                                                                   ' autoajusta los headers  
                                                                                   ListViewDatosDiagnostico.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                                                                                   ListViewDatosDiagnostico.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                                                                               End With
                                                                               ' error  
                                                                           Catch omsg As Exception
                                                                               MsgBox(omsg.Message, MsgBoxStyle.Critical)
                                                                           End Try
                                                                       End Sub)
                                                     )

                                                 End Sub)
        Await resp
    End Function

    Private Sub ButtonReiniciarGrafico_Click(sender As Object, e As EventArgs) Handles ButtonReiniciarGrafico.Click
        tiempo = 0
        Me.PunteroDeDataRendimiento.clear()
        Me.ChartRendimiento.Refresh()
    End Sub

    Private Sub ButtonIniciarGrafico_Click(sender As Object, e As EventArgs) Handles ButtonIniciarGrafico.Click
        If TimerGrafico.Enabled = False Then
            TimerGrafico.Enabled = True
            Me.ButtonIniciarGrafico.IconChar = FontAwesome.Sharp.IconChar.Pause

        Else
            TimerGrafico.Enabled = False
            Me.ButtonIniciarGrafico.IconChar = FontAwesome.Sharp.IconChar.Play
            tiempo = 0
        End If
    End Sub


    Private Async Function DatosDeLabels() As Task
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     Me.Invoke(New MethodInvoker(Sub()
                                                                                     Me.LabelUsuario.Text = Nombre
                                                                                     Me.LabelIdentificador.Text = ci
                                                                                     Me.LabelDependencia.Text = Empresa
                                                                                     Me.LabelCargo.Text = Rol
                                                                                     Me.LabelDatoComputadora.Text = My.Computer.Name
                                                                                     Me.LabelCuentaLocal.Text = Environment.UserName

                                                                                     Me.Label10.Text = fechaUltimaRevision

                                                                                     Me.LabelSistemaOperativo.Text = My.Computer.Info.OSFullName
                                                                                     Me.Labelplat.Text = My.Computer.Info.OSPlatform
                                                                                     Me.LabelVersion.Text = My.Computer.Info.OSVersion
                                                                                 End Sub))
                                                 End Sub)
        Await resp
        '' panel Arriba izquierda
    End Function
    Private Async Function ColorHeredado() As Task
        Me.BackColor = TemaActual.Fondo
        Me.ForeColor = TemaActual.Letra
        Me.Panel4.BackColor = TemaActual.PanelTop
        Me.Panel5.BackColor = TemaActual.PanelLateral
        Dim resp As Task = Task.Factory.StartNew(Sub()
                                                     Me.Invoke(New MethodInvoker(Sub()
                                                                                     Me.ListViewDatosDiagnostico.BackColor = TemaActual.Fondo
                                                                                     Me.ChartRendimiento.BackColor = TemaActual.PanelLateral
                                                                                     PropiedadesLabel(Label17)
                                                                                     PropiedadesLabel(Me.Label1)
                                                                                     PropiedadesLabel(Me.Label2)
                                                                                     PropiedadesLabel(Me.Label3)
                                                                                     PropiedadesLabel(Me.Label4)
                                                                                     PropiedadesLabel(Me.Label5)
                                                                                     PropiedadesLabel(Me.Label6)
                                                                                     PropiedadesLabel(Me.Label7)
                                                                                     PropiedadesLabel(Me.Label8)
                                                                                     PropiedadesLabel(Me.Label9)
                                                                                     PropiedadesLabel(Me.Label10)
                                                                                     PropiedadesLabel(Me.LabelFecha)
                                                                                     PropiedadesLabel(Me.Label12)
                                                                                     PropiedadesLabel(Me.LabelVersion)
                                                                                     PropiedadesLabel(Me.LabelCargo)
                                                                                     PropiedadesLabel(Me.LabelCuentaLocal)
                                                                                     PropiedadesLabel(Me.LabelDatoComputadora)
                                                                                     PropiedadesLabel(Me.LabelDependencia)
                                                                                     PropiedadesLabel(Me.LabelIdentificador)
                                                                                     PropiedadesLabel(Me.LabelSistemaOperativo)
                                                                                     PropiedadesLabel(Me.LabelUsuario)
                                                                                     PropiedadesLabel(Me.Labelplat)
                                                                                     PropiedadesLabel(Me.LabelConteo)
                                                                                     PropiedadesLabel(Me.LabelSistemaOperativo)
                                                                                     PropiedadesLabel(Me.Label16)
                                                                                     PropiedadesIconButton(ButtonIniciarGrafico)
                                                                                     PropiedadesIconButton(ButtonReiniciarGrafico)
                                                                                     PropiedadesIconButton(ButtonClose)
                                                                                 End Sub))
                                                 End Sub)
        Await resp
    End Function


End Class