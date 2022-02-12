<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEstadoMemoriaRAM
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstadoMemoriaRAM))
        Me.PanelDeRendimiento = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBarmeMRAM = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartDatosDeRendimiento = New Bunifu.DataViz.WinForms.BunifuDataViz()
        Me.TimerContadores = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonIniciarMonitor = New MetroFramework.Controls.MetroButton()
        Me.ButtonMostrarGrafico = New MetroFramework.Controls.MetroButton()
        Me.ButtonReiniciarGrafico = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.PCMemoriaRAMEnUso = New System.Diagnostics.PerformanceCounter()
        Me.PCMBDisponibles = New System.Diagnostics.PerformanceCounter()
        Me.PCbytesconfirmados = New System.Diagnostics.PerformanceCounter()
        Me.PCbytescache = New System.Diagnostics.PerformanceCounter()
        Me.PCBytesCacheSistema = New System.Diagnostics.PerformanceCounter()
        Me.PCcopiasEscritura = New System.Diagnostics.PerformanceCounter()
        Me.PCEntradasDePAginas = New System.Diagnostics.PerformanceCounter()
        Me.PCErrorTransicion = New System.Diagnostics.PerformanceCounter()
        Me.PCLecturasdePAgina = New System.Diagnostics.PerformanceCounter()
        Me.PCPAginasTransReasiganda = New System.Diagnostics.PerformanceCounter()
        Me.PCPaginas = New System.Diagnostics.PerformanceCounter()
        Me.LabelLecturasdePAgina = New System.Windows.Forms.Label()
        Me.LabelPaginas = New System.Windows.Forms.Label()
        Me.LabelErrorTransicion = New System.Windows.Forms.Label()
        Me.LabelPAginasTransReasiganda = New System.Windows.Forms.Label()
        Me.LabelcopiasEscritura = New System.Windows.Forms.Label()
        Me.LabelBytesCacheSistema = New System.Windows.Forms.Label()
        Me.Labelbytescache = New System.Windows.Forms.Label()
        Me.LabelEntradasDePAginas = New System.Windows.Forms.Label()
        Me.LabelMBDisponibles = New System.Windows.Forms.Label()
        Me.Labelbytesconfirmados = New System.Windows.Forms.Label()
        Me.PanelDeRendimiento.SuspendLayout()
        CType(Me.PCMemoriaRAMEnUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCMBDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCbytesconfirmados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCbytescache, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBytesCacheSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCcopiasEscritura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCEntradasDePAginas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCErrorTransicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCLecturasdePAgina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCPAginasTransReasiganda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCPaginas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDeRendimiento
        '
        Me.PanelDeRendimiento.BackgroundImage = CType(resources.GetObject("PanelDeRendimiento.BackgroundImage"), System.Drawing.Image)
        Me.PanelDeRendimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDeRendimiento.Controls.Add(Me.LabelLecturasdePAgina)
        Me.PanelDeRendimiento.Controls.Add(Me.LabelPaginas)
        Me.PanelDeRendimiento.Controls.Add(Me.LabelErrorTransicion)
        Me.PanelDeRendimiento.Controls.Add(Me.LabelPAginasTransReasiganda)
        Me.PanelDeRendimiento.Controls.Add(Me.LabelcopiasEscritura)
        Me.PanelDeRendimiento.Controls.Add(Me.LabelBytesCacheSistema)
        Me.PanelDeRendimiento.Controls.Add(Me.Labelbytescache)
        Me.PanelDeRendimiento.Controls.Add(Me.LabelEntradasDePAginas)
        Me.PanelDeRendimiento.Controls.Add(Me.LabelMBDisponibles)
        Me.PanelDeRendimiento.Controls.Add(Me.Labelbytesconfirmados)
        Me.PanelDeRendimiento.Controls.Add(Me.Label11)
        Me.PanelDeRendimiento.Controls.Add(Me.Label12)
        Me.PanelDeRendimiento.Controls.Add(Me.Label14)
        Me.PanelDeRendimiento.Controls.Add(Me.Label15)
        Me.PanelDeRendimiento.Controls.Add(Me.Label9)
        Me.PanelDeRendimiento.Controls.Add(Me.Label8)
        Me.PanelDeRendimiento.Controls.Add(Me.Label7)
        Me.PanelDeRendimiento.Controls.Add(Me.Label6)
        Me.PanelDeRendimiento.Controls.Add(Me.Label2)
        Me.PanelDeRendimiento.Controls.Add(Me.Label3)
        Me.PanelDeRendimiento.Controls.Add(Me.ProgressBarmeMRAM)
        Me.PanelDeRendimiento.Controls.Add(Me.Label5)
        Me.PanelDeRendimiento.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDeRendimiento.GradientBottomLeft = System.Drawing.Color.DimGray
        Me.PanelDeRendimiento.GradientBottomRight = System.Drawing.Color.Silver
        Me.PanelDeRendimiento.GradientTopLeft = System.Drawing.Color.DimGray
        Me.PanelDeRendimiento.GradientTopRight = System.Drawing.Color.Silver
        Me.PanelDeRendimiento.Location = New System.Drawing.Point(0, 0)
        Me.PanelDeRendimiento.Name = "PanelDeRendimiento"
        Me.PanelDeRendimiento.Quality = 10
        Me.PanelDeRendimiento.Size = New System.Drawing.Size(243, 483)
        Me.PanelDeRendimiento.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(0, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Lecturas:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(0, 401)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Paginas Totales:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(0, 338)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 20)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Error Transicion:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(0, 380)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 20)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Reasignaciones:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(0, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Escritura:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(0, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Bytes Cache Sistema:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(0, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Bytes Cache:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(0, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Entradas:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(78, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "En uso"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(0, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Mbs Disponibles:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBarmeMRAM
        '
        Me.ProgressBarmeMRAM.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBarmeMRAM.BackgroundImage = CType(resources.GetObject("ProgressBarmeMRAM.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBarmeMRAM.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBarmeMRAM.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProgressBarmeMRAM.Location = New System.Drawing.Point(-5, -12)
        Me.ProgressBarmeMRAM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBarmeMRAM.Name = "ProgressBarmeMRAM"
        Me.ProgressBarmeMRAM.ProgressBgColor = System.Drawing.Color.Silver
        Me.ProgressBarmeMRAM.ProgressColor1 = System.Drawing.Color.SeaGreen
        Me.ProgressBarmeMRAM.ProgressColor2 = System.Drawing.Color.Tomato
        Me.ProgressBarmeMRAM.Size = New System.Drawing.Size(250, 145)
        Me.ProgressBarmeMRAM.Suffix = "%"
        Me.ProgressBarmeMRAM.TabIndex = 16
        Me.ProgressBarmeMRAM.Thickness = 15
        Me.ProgressBarmeMRAM.Value = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(0, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Bytes totales:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(244, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 112)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "RAM"
        '
        'ChartDatosDeRendimiento
        '
        Me.ChartDatosDeRendimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartDatosDeRendimiento.animationEnabled = True
        Me.ChartDatosDeRendimiento.AxisLineColor = System.Drawing.Color.Black
        Me.ChartDatosDeRendimiento.AxisXFontColor = System.Drawing.Color.Black
        Me.ChartDatosDeRendimiento.AxisXGridColor = System.Drawing.Color.Black
        Me.ChartDatosDeRendimiento.AxisXGridThickness = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChartDatosDeRendimiento.AxisYFontColor = System.Drawing.Color.Black
        Me.ChartDatosDeRendimiento.AxisYGridColor = System.Drawing.Color.Black
        Me.ChartDatosDeRendimiento.AxisYGridThickness = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChartDatosDeRendimiento.BackColor = System.Drawing.Color.Transparent
        Me.ChartDatosDeRendimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ChartDatosDeRendimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ChartDatosDeRendimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ChartDatosDeRendimiento.Location = New System.Drawing.Point(250, 136)
        Me.ChartDatosDeRendimiento.Name = "ChartDatosDeRendimiento"
        Me.ChartDatosDeRendimiento.Size = New System.Drawing.Size(538, 335)
        Me.ChartDatosDeRendimiento.TabIndex = 15
        Me.ChartDatosDeRendimiento.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1
        Me.ChartDatosDeRendimiento.Title = "Uso de RAM"
        '
        'TimerContadores
        '
        Me.TimerContadores.Interval = 1000
        '
        'ButtonIniciarMonitor
        '
        Me.ButtonIniciarMonitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIniciarMonitor.Location = New System.Drawing.Point(624, 82)
        Me.ButtonIniciarMonitor.Name = "ButtonIniciarMonitor"
        Me.ButtonIniciarMonitor.Size = New System.Drawing.Size(164, 23)
        Me.ButtonIniciarMonitor.TabIndex = 16
        Me.ButtonIniciarMonitor.Text = "Iniciar Monitor"
        Me.ButtonIniciarMonitor.UseSelectable = True
        '
        'ButtonMostrarGrafico
        '
        Me.ButtonMostrarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrarGrafico.Location = New System.Drawing.Point(624, 53)
        Me.ButtonMostrarGrafico.Name = "ButtonMostrarGrafico"
        Me.ButtonMostrarGrafico.Size = New System.Drawing.Size(164, 23)
        Me.ButtonMostrarGrafico.TabIndex = 17
        Me.ButtonMostrarGrafico.Text = "Mostrar Gráfico"
        Me.ButtonMostrarGrafico.UseSelectable = True
        '
        'ButtonReiniciarGrafico
        '
        Me.ButtonReiniciarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReiniciarGrafico.Location = New System.Drawing.Point(624, 24)
        Me.ButtonReiniciarGrafico.Name = "ButtonReiniciarGrafico"
        Me.ButtonReiniciarGrafico.Size = New System.Drawing.Size(164, 23)
        Me.ButtonReiniciarGrafico.TabIndex = 18
        Me.ButtonReiniciarGrafico.Text = "Reiniciar Gráfico"
        Me.ButtonReiniciarGrafico.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(267, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Monitor de Rendimiento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelInfo
        '
        Me.LabelInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.BackColor = System.Drawing.Color.Transparent
        Me.LabelInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelInfo.Location = New System.Drawing.Point(267, 177)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(454, 210)
        Me.LabelInfo.TabIndex = 20
        Me.LabelInfo.Text = resources.GetString("LabelInfo.Text")
        Me.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PCMemoriaRAMEnUso
        '
        Me.PCMemoriaRAMEnUso.CategoryName = "Memoria"
        Me.PCMemoriaRAMEnUso.CounterName = "% de bytes confirmados en uso"
        Me.PCMemoriaRAMEnUso.MachineName = "DESKTOP-MPT44JU"
        '
        'PCMBDisponibles
        '
        Me.PCMBDisponibles.CategoryName = "Memoria"
        Me.PCMBDisponibles.CounterName = "Mbytes disponibles"
        Me.PCMBDisponibles.MachineName = "DESKTOP-MPT44JU"
        '
        'PCbytesconfirmados
        '
        Me.PCbytesconfirmados.CategoryName = "Memoria"
        Me.PCbytesconfirmados.CounterName = "Bytes confirmados"
        Me.PCbytesconfirmados.MachineName = "DESKTOP-MPT44JU"
        '
        'PCbytescache
        '
        Me.PCbytescache.CategoryName = "Memoria"
        Me.PCbytescache.CounterName = "Bytes de caché"
        Me.PCbytescache.MachineName = "DESKTOP-MPT44JU"
        '
        'PCBytesCacheSistema
        '
        Me.PCBytesCacheSistema.CategoryName = "Memoria"
        Me.PCBytesCacheSistema.CounterName = "Bytes residentes de caché del sistema"
        Me.PCBytesCacheSistema.MachineName = "DESKTOP-MPT44JU"
        '
        'PCcopiasEscritura
        '
        Me.PCcopiasEscritura.CategoryName = "Memoria"
        Me.PCcopiasEscritura.CounterName = "Copias de escritura/s"
        Me.PCcopiasEscritura.MachineName = "DESKTOP-MPT44JU"
        '
        'PCEntradasDePAginas
        '
        Me.PCEntradasDePAginas.CategoryName = "Memoria"
        Me.PCEntradasDePAginas.CounterName = "Entrada de páginas/s"
        Me.PCEntradasDePAginas.MachineName = "DESKTOP-MPT44JU"
        '
        'PCErrorTransicion
        '
        Me.PCErrorTransicion.CategoryName = "Memoria"
        Me.PCErrorTransicion.CounterName = "Errores de transición/s"
        Me.PCErrorTransicion.MachineName = "DESKTOP-MPT44JU"
        '
        'PCLecturasdePAgina
        '
        Me.PCLecturasdePAgina.CategoryName = "Memoria"
        Me.PCLecturasdePAgina.CounterName = "Lecturas de páginas/s"
        Me.PCLecturasdePAgina.MachineName = "DESKTOP-MPT44JU"
        '
        'PCPAginasTransReasiganda
        '
        Me.PCPAginasTransReasiganda.CategoryName = "Memoria"
        Me.PCPAginasTransReasiganda.CounterName = "Páginas de transición reasignadas/s"
        Me.PCPAginasTransReasiganda.MachineName = "DESKTOP-MPT44JU"
        '
        'PCPaginas
        '
        Me.PCPaginas.CategoryName = "Memoria"
        Me.PCPaginas.CounterName = "Páginas/s"
        Me.PCPaginas.MachineName = "DESKTOP-MPT44JU"
        '
        'LabelLecturasdePAgina
        '
        Me.LabelLecturasdePAgina.AutoSize = True
        Me.LabelLecturasdePAgina.BackColor = System.Drawing.Color.Transparent
        Me.LabelLecturasdePAgina.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLecturasdePAgina.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelLecturasdePAgina.Location = New System.Drawing.Point(167, 359)
        Me.LabelLecturasdePAgina.Name = "LabelLecturasdePAgina"
        Me.LabelLecturasdePAgina.Size = New System.Drawing.Size(23, 20)
        Me.LabelLecturasdePAgina.TabIndex = 38
        Me.LabelLecturasdePAgina.Text = "xx"
        Me.LabelLecturasdePAgina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPaginas
        '
        Me.LabelPaginas.AutoSize = True
        Me.LabelPaginas.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaginas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaginas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelPaginas.Location = New System.Drawing.Point(167, 401)
        Me.LabelPaginas.Name = "LabelPaginas"
        Me.LabelPaginas.Size = New System.Drawing.Size(23, 20)
        Me.LabelPaginas.TabIndex = 37
        Me.LabelPaginas.Text = "xx"
        Me.LabelPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelErrorTransicion
        '
        Me.LabelErrorTransicion.AutoSize = True
        Me.LabelErrorTransicion.BackColor = System.Drawing.Color.Transparent
        Me.LabelErrorTransicion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorTransicion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelErrorTransicion.Location = New System.Drawing.Point(167, 338)
        Me.LabelErrorTransicion.Name = "LabelErrorTransicion"
        Me.LabelErrorTransicion.Size = New System.Drawing.Size(23, 20)
        Me.LabelErrorTransicion.TabIndex = 35
        Me.LabelErrorTransicion.Text = "xx"
        Me.LabelErrorTransicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPAginasTransReasiganda
        '
        Me.LabelPAginasTransReasiganda.AutoSize = True
        Me.LabelPAginasTransReasiganda.BackColor = System.Drawing.Color.Transparent
        Me.LabelPAginasTransReasiganda.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPAginasTransReasiganda.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelPAginasTransReasiganda.Location = New System.Drawing.Point(167, 380)
        Me.LabelPAginasTransReasiganda.Name = "LabelPAginasTransReasiganda"
        Me.LabelPAginasTransReasiganda.Size = New System.Drawing.Size(23, 20)
        Me.LabelPAginasTransReasiganda.TabIndex = 36
        Me.LabelPAginasTransReasiganda.Text = "xx"
        Me.LabelPAginasTransReasiganda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelcopiasEscritura
        '
        Me.LabelcopiasEscritura.AutoSize = True
        Me.LabelcopiasEscritura.BackColor = System.Drawing.Color.Transparent
        Me.LabelcopiasEscritura.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelcopiasEscritura.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelcopiasEscritura.Location = New System.Drawing.Point(167, 296)
        Me.LabelcopiasEscritura.Name = "LabelcopiasEscritura"
        Me.LabelcopiasEscritura.Size = New System.Drawing.Size(23, 20)
        Me.LabelcopiasEscritura.TabIndex = 34
        Me.LabelcopiasEscritura.Text = "xx"
        Me.LabelcopiasEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelBytesCacheSistema
        '
        Me.LabelBytesCacheSistema.AutoSize = True
        Me.LabelBytesCacheSistema.BackColor = System.Drawing.Color.Transparent
        Me.LabelBytesCacheSistema.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBytesCacheSistema.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelBytesCacheSistema.Location = New System.Drawing.Point(167, 275)
        Me.LabelBytesCacheSistema.Name = "LabelBytesCacheSistema"
        Me.LabelBytesCacheSistema.Size = New System.Drawing.Size(23, 20)
        Me.LabelBytesCacheSistema.TabIndex = 33
        Me.LabelBytesCacheSistema.Text = "xx"
        Me.LabelBytesCacheSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelbytescache
        '
        Me.Labelbytescache.AutoSize = True
        Me.Labelbytescache.BackColor = System.Drawing.Color.Transparent
        Me.Labelbytescache.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbytescache.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Labelbytescache.Location = New System.Drawing.Point(167, 254)
        Me.Labelbytescache.Name = "Labelbytescache"
        Me.Labelbytescache.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Labelbytescache.Size = New System.Drawing.Size(23, 20)
        Me.Labelbytescache.TabIndex = 32
        Me.Labelbytescache.Text = "xx"
        Me.Labelbytescache.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelEntradasDePAginas
        '
        Me.LabelEntradasDePAginas.AutoSize = True
        Me.LabelEntradasDePAginas.BackColor = System.Drawing.Color.Transparent
        Me.LabelEntradasDePAginas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEntradasDePAginas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelEntradasDePAginas.Location = New System.Drawing.Point(167, 317)
        Me.LabelEntradasDePAginas.Name = "LabelEntradasDePAginas"
        Me.LabelEntradasDePAginas.Size = New System.Drawing.Size(23, 20)
        Me.LabelEntradasDePAginas.TabIndex = 31
        Me.LabelEntradasDePAginas.Text = "xx"
        Me.LabelEntradasDePAginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMBDisponibles
        '
        Me.LabelMBDisponibles.AutoSize = True
        Me.LabelMBDisponibles.BackColor = System.Drawing.Color.Transparent
        Me.LabelMBDisponibles.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMBDisponibles.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelMBDisponibles.Location = New System.Drawing.Point(167, 212)
        Me.LabelMBDisponibles.Name = "LabelMBDisponibles"
        Me.LabelMBDisponibles.Size = New System.Drawing.Size(23, 20)
        Me.LabelMBDisponibles.TabIndex = 29
        Me.LabelMBDisponibles.Text = "xx"
        Me.LabelMBDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelbytesconfirmados
        '
        Me.Labelbytesconfirmados.AutoSize = True
        Me.Labelbytesconfirmados.BackColor = System.Drawing.Color.Transparent
        Me.Labelbytesconfirmados.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbytesconfirmados.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Labelbytesconfirmados.Location = New System.Drawing.Point(167, 233)
        Me.Labelbytesconfirmados.Name = "Labelbytesconfirmados"
        Me.Labelbytesconfirmados.Size = New System.Drawing.Size(23, 20)
        Me.Labelbytesconfirmados.TabIndex = 30
        Me.Labelbytesconfirmados.Text = "xx"
        Me.Labelbytesconfirmados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormEstadoMemoriaRAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonReiniciarGrafico)
        Me.Controls.Add(Me.ButtonMostrarGrafico)
        Me.Controls.Add(Me.ButtonIniciarMonitor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelDeRendimiento)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.ChartDatosDeRendimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEstadoMemoriaRAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEstadoCPU"
        Me.PanelDeRendimiento.ResumeLayout(False)
        Me.PanelDeRendimiento.PerformLayout()
        CType(Me.PCMemoriaRAMEnUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCMBDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCbytesconfirmados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCbytescache, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBytesCacheSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCcopiasEscritura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCEntradasDePAginas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCErrorTransicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCLecturasdePAgina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCPAginasTransReasiganda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCPaginas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelDeRendimiento As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBarmeMRAM As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ChartDatosDeRendimiento As Bunifu.DataViz.WinForms.BunifuDataViz
    Friend WithEvents TimerContadores As Timer
    Friend WithEvents ButtonIniciarMonitor As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonMostrarGrafico As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonReiniciarGrafico As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents PCMemoriaRAMEnUso As PerformanceCounter
    Friend WithEvents PCMBDisponibles As PerformanceCounter
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PCbytesconfirmados As PerformanceCounter
    Friend WithEvents PCbytescache As PerformanceCounter
    Friend WithEvents PCBytesCacheSistema As PerformanceCounter
    Friend WithEvents PCcopiasEscritura As PerformanceCounter
    Friend WithEvents PCEntradasDePAginas As PerformanceCounter
    Friend WithEvents PCErrorTransicion As PerformanceCounter
    Friend WithEvents PCLecturasdePAgina As PerformanceCounter
    Friend WithEvents PCPAginasTransReasiganda As PerformanceCounter
    Friend WithEvents PCPaginas As PerformanceCounter
    Friend WithEvents LabelLecturasdePAgina As Label
    Friend WithEvents LabelPaginas As Label
    Friend WithEvents LabelErrorTransicion As Label
    Friend WithEvents LabelPAginasTransReasiganda As Label
    Friend WithEvents LabelcopiasEscritura As Label
    Friend WithEvents LabelBytesCacheSistema As Label
    Friend WithEvents Labelbytescache As Label
    Friend WithEvents LabelEntradasDePAginas As Label
    Friend WithEvents LabelMBDisponibles As Label
    Friend WithEvents Labelbytesconfirmados As Label
End Class
