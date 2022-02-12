<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEstadoDiscos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstadoDiscos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartDatosDeRendimiento = New Bunifu.DataViz.WinForms.BunifuDataViz()
        Me.TimerContadores = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonIniciarMonitor = New MetroFramework.Controls.MetroButton()
        Me.ButtonMostrarGrafico = New MetroFramework.Controls.MetroButton()
        Me.ButtonReiniciarGrafico = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.PCEscrituraDisco = New System.Diagnostics.PerformanceCounter()
        Me.PCLectruraDisco = New System.Diagnostics.PerformanceCounter()
        Me.PanelDeRendimiento = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBarTiempoUsuario2 = New Bunifu.Framework.UI.BunifuGauge()
        Me.ProgressBarDPC = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBarTiempoProcesador = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PCTiempo = New System.Diagnostics.PerformanceCounter()
        CType(Me.PCEscrituraDisco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCLectruraDisco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDeRendimiento.SuspendLayout()
        CType(Me.PCTiempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 77)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Disco local"
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
        Me.ChartDatosDeRendimiento.Size = New System.Drawing.Size(576, 381)
        Me.ChartDatosDeRendimiento.TabIndex = 15
        Me.ChartDatosDeRendimiento.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1
        Me.ChartDatosDeRendimiento.Title = "Rendimiento de CPU"
        '
        'TimerContadores
        '
        Me.TimerContadores.Interval = 1000
        '
        'ButtonIniciarMonitor
        '
        Me.ButtonIniciarMonitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIniciarMonitor.Location = New System.Drawing.Point(662, 82)
        Me.ButtonIniciarMonitor.Name = "ButtonIniciarMonitor"
        Me.ButtonIniciarMonitor.Size = New System.Drawing.Size(164, 23)
        Me.ButtonIniciarMonitor.TabIndex = 16
        Me.ButtonIniciarMonitor.Text = "Iniciar Monitor"
        Me.ButtonIniciarMonitor.UseSelectable = True
        '
        'ButtonMostrarGrafico
        '
        Me.ButtonMostrarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrarGrafico.Location = New System.Drawing.Point(662, 53)
        Me.ButtonMostrarGrafico.Name = "ButtonMostrarGrafico"
        Me.ButtonMostrarGrafico.Size = New System.Drawing.Size(164, 23)
        Me.ButtonMostrarGrafico.TabIndex = 17
        Me.ButtonMostrarGrafico.Text = "Mostrar Gráfico"
        Me.ButtonMostrarGrafico.UseSelectable = True
        '
        'ButtonReiniciarGrafico
        '
        Me.ButtonReiniciarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReiniciarGrafico.Location = New System.Drawing.Point(662, 24)
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
        Me.Label4.Location = New System.Drawing.Point(246, 86)
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
        'PCEscrituraDisco
        '
        Me.PCEscrituraDisco.CategoryName = "Disco físico"
        Me.PCEscrituraDisco.CounterName = "% de tiempo de escritura en disco"
        Me.PCEscrituraDisco.InstanceName = "_Total"
        Me.PCEscrituraDisco.MachineName = "DESKTOP-MPT44JU"
        '
        'PCLectruraDisco
        '
        Me.PCLectruraDisco.CategoryName = "Disco físico"
        Me.PCLectruraDisco.CounterName = "% de tiempo de lectura de disco"
        Me.PCLectruraDisco.InstanceName = "_Total"
        Me.PCLectruraDisco.MachineName = "DESKTOP-MPT44JU"
        '
        'PanelDeRendimiento
        '
        Me.PanelDeRendimiento.BackgroundImage = CType(resources.GetObject("PanelDeRendimiento.BackgroundImage"), System.Drawing.Image)
        Me.PanelDeRendimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDeRendimiento.Controls.Add(Me.Label2)
        Me.PanelDeRendimiento.Controls.Add(Me.ProgressBarTiempoUsuario2)
        Me.PanelDeRendimiento.Controls.Add(Me.ProgressBarDPC)
        Me.PanelDeRendimiento.Controls.Add(Me.Label3)
        Me.PanelDeRendimiento.Controls.Add(Me.ProgressBarTiempoProcesador)
        Me.PanelDeRendimiento.Controls.Add(Me.Label5)
        Me.PanelDeRendimiento.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDeRendimiento.GradientBottomLeft = System.Drawing.Color.DimGray
        Me.PanelDeRendimiento.GradientBottomRight = System.Drawing.Color.Silver
        Me.PanelDeRendimiento.GradientTopLeft = System.Drawing.Color.DimGray
        Me.PanelDeRendimiento.GradientTopRight = System.Drawing.Color.Silver
        Me.PanelDeRendimiento.Location = New System.Drawing.Point(0, 0)
        Me.PanelDeRendimiento.Name = "PanelDeRendimiento"
        Me.PanelDeRendimiento.Quality = 10
        Me.PanelDeRendimiento.Size = New System.Drawing.Size(212, 529)
        Me.PanelDeRendimiento.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(66, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Lectura"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBarTiempoUsuario2
        '
        Me.ProgressBarTiempoUsuario2.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBarTiempoUsuario2.BackgroundImage = CType(resources.GetObject("ProgressBarTiempoUsuario2.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBarTiempoUsuario2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBarTiempoUsuario2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProgressBarTiempoUsuario2.Location = New System.Drawing.Point(18, 298)
        Me.ProgressBarTiempoUsuario2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBarTiempoUsuario2.Name = "ProgressBarTiempoUsuario2"
        Me.ProgressBarTiempoUsuario2.ProgressBgColor = System.Drawing.Color.Silver
        Me.ProgressBarTiempoUsuario2.ProgressColor1 = System.Drawing.Color.SeaGreen
        Me.ProgressBarTiempoUsuario2.ProgressColor2 = System.Drawing.Color.Tomato
        Me.ProgressBarTiempoUsuario2.Size = New System.Drawing.Size(182, 108)
        Me.ProgressBarTiempoUsuario2.Suffix = "%"
        Me.ProgressBarTiempoUsuario2.TabIndex = 20
        Me.ProgressBarTiempoUsuario2.Thickness = 10
        Me.ProgressBarTiempoUsuario2.Value = 0
        '
        'ProgressBarDPC
        '
        Me.ProgressBarDPC.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBarDPC.BackgroundImage = CType(resources.GetObject("ProgressBarDPC.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBarDPC.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBarDPC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProgressBarDPC.Location = New System.Drawing.Point(18, 14)
        Me.ProgressBarDPC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBarDPC.Name = "ProgressBarDPC"
        Me.ProgressBarDPC.ProgressBgColor = System.Drawing.Color.Silver
        Me.ProgressBarDPC.ProgressColor1 = System.Drawing.Color.SeaGreen
        Me.ProgressBarDPC.ProgressColor2 = System.Drawing.Color.Tomato
        Me.ProgressBarDPC.Size = New System.Drawing.Size(182, 108)
        Me.ProgressBarDPC.Suffix = "%"
        Me.ProgressBarDPC.TabIndex = 14
        Me.ProgressBarDPC.Thickness = 10
        Me.ProgressBarDPC.Value = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(47, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 48)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "TIempo en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Disco Fisico"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBarTiempoProcesador
        '
        Me.ProgressBarTiempoProcesador.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBarTiempoProcesador.BackgroundImage = CType(resources.GetObject("ProgressBarTiempoProcesador.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBarTiempoProcesador.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBarTiempoProcesador.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProgressBarTiempoProcesador.Location = New System.Drawing.Point(18, 156)
        Me.ProgressBarTiempoProcesador.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBarTiempoProcesador.Name = "ProgressBarTiempoProcesador"
        Me.ProgressBarTiempoProcesador.ProgressBgColor = System.Drawing.Color.Silver
        Me.ProgressBarTiempoProcesador.ProgressColor1 = System.Drawing.Color.SeaGreen
        Me.ProgressBarTiempoProcesador.ProgressColor2 = System.Drawing.Color.Tomato
        Me.ProgressBarTiempoProcesador.Size = New System.Drawing.Size(182, 108)
        Me.ProgressBarTiempoProcesador.Suffix = "%"
        Me.ProgressBarTiempoProcesador.TabIndex = 16
        Me.ProgressBarTiempoProcesador.Thickness = 10
        Me.ProgressBarTiempoProcesador.Value = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(63, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Escritura"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PCTiempo
        '
        Me.PCTiempo.CategoryName = "Disco físico"
        Me.PCTiempo.CounterName = "% de tiempo de disco"
        Me.PCTiempo.InstanceName = "_Total"
        Me.PCTiempo.MachineName = "DESKTOP-MPT44JU"
        '
        'FormEstadoDiscos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(838, 529)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonReiniciarGrafico)
        Me.Controls.Add(Me.ButtonMostrarGrafico)
        Me.Controls.Add(Me.ButtonIniciarMonitor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelDeRendimiento)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.ChartDatosDeRendimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEstadoDiscos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEstadoCPU"
        CType(Me.PCEscrituraDisco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCLectruraDisco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDeRendimiento.ResumeLayout(False)
        Me.PanelDeRendimiento.PerformLayout()
        CType(Me.PCTiempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelDeRendimiento As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ProgressBarTiempoUsuario2 As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBarDPC As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBarTiempoProcesador As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ChartDatosDeRendimiento As Bunifu.DataViz.WinForms.BunifuDataViz
    Friend WithEvents TimerContadores As Timer
    Friend WithEvents ButtonIniciarMonitor As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonMostrarGrafico As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonReiniciarGrafico As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents PCEscrituraDisco As PerformanceCounter
    Friend WithEvents PCLectruraDisco As PerformanceCounter
    Friend WithEvents PCTiempo As PerformanceCounter
End Class
