<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPresentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPresentacion))
        Me.TimerPin = New System.Windows.Forms.Timer(Me.components)
        Me.PanelFondo = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBoxTecnico = New System.Windows.Forms.PictureBox()
        Me.PictureBoxServicio = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAServicesApp = New System.Windows.Forms.PictureBox()
        Me.ProgressBarPin = New MetroFramework.Controls.MetroProgressBar()
        Me.LabelContador = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelFondo.SuspendLayout()
        CType(Me.PictureBoxTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAServicesApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerPin
        '
        Me.TimerPin.Enabled = True
        Me.TimerPin.Interval = 1000
        '
        'PanelFondo
        '
        Me.PanelFondo.BackgroundImage = CType(resources.GetObject("PanelFondo.BackgroundImage"), System.Drawing.Image)
        Me.PanelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelFondo.Controls.Add(Me.PictureBoxTecnico)
        Me.PanelFondo.Controls.Add(Me.PictureBoxServicio)
        Me.PanelFondo.Controls.Add(Me.PictureBoxAServicesApp)
        Me.PanelFondo.Controls.Add(Me.ProgressBarPin)
        Me.PanelFondo.Controls.Add(Me.LabelContador)
        Me.PanelFondo.Controls.Add(Me.PictureBoxLogo)
        Me.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFondo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelFondo.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelFondo.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelFondo.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelFondo.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelFondo.Location = New System.Drawing.Point(0, 0)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Quality = 1000
        Me.PanelFondo.Size = New System.Drawing.Size(575, 357)
        Me.PanelFondo.TabIndex = 0
        '
        'PictureBoxTecnico
        '
        Me.PictureBoxTecnico.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxTecnico.Image = Global.InterfazUsuario.My.Resources.Resources._3_tecnicoLetrasBlancas
        Me.PictureBoxTecnico.Location = New System.Drawing.Point(306, 246)
        Me.PictureBoxTecnico.Name = "PictureBoxTecnico"
        Me.PictureBoxTecnico.Size = New System.Drawing.Size(105, 29)
        Me.PictureBoxTecnico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxTecnico.TabIndex = 9
        Me.PictureBoxTecnico.TabStop = False
        '
        'PictureBoxServicio
        '
        Me.PictureBoxServicio.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxServicio.Image = Global.InterfazUsuario.My.Resources.Resources._3__ServicioLetrasBlancas
        Me.PictureBoxServicio.Location = New System.Drawing.Point(172, 252)
        Me.PictureBoxServicio.Name = "PictureBoxServicio"
        Me.PictureBoxServicio.Size = New System.Drawing.Size(128, 21)
        Me.PictureBoxServicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxServicio.TabIndex = 8
        Me.PictureBoxServicio.TabStop = False
        '
        'PictureBoxAServicesApp
        '
        Me.PictureBoxAServicesApp.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAServicesApp.Image = Global.InterfazUsuario.My.Resources.Resources._3_AServicesLetrasBlancas
        Me.PictureBoxAServicesApp.Location = New System.Drawing.Point(89, 193)
        Me.PictureBoxAServicesApp.Name = "PictureBoxAServicesApp"
        Me.PictureBoxAServicesApp.Size = New System.Drawing.Size(391, 53)
        Me.PictureBoxAServicesApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAServicesApp.TabIndex = 7
        Me.PictureBoxAServicesApp.TabStop = False
        '
        'ProgressBarPin
        '
        Me.ProgressBarPin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarPin.HideProgressText = False
        Me.ProgressBarPin.Location = New System.Drawing.Point(0, 335)
        Me.ProgressBarPin.Maximum = 1000
        Me.ProgressBarPin.Name = "ProgressBarPin"
        Me.ProgressBarPin.Size = New System.Drawing.Size(575, 22)
        Me.ProgressBarPin.Step = 1
        Me.ProgressBarPin.Style = MetroFramework.MetroColorStyle.Silver
        Me.ProgressBarPin.TabIndex = 6
        Me.ProgressBarPin.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelContador
        '
        Me.LabelContador.AutoSize = True
        Me.LabelContador.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador.Location = New System.Drawing.Point(12, 9)
        Me.LabelContador.Name = "LabelContador"
        Me.LabelContador.Size = New System.Drawing.Size(0, 21)
        Me.LabelContador.TabIndex = 4
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(156, -22)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(255, 236)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'FormPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(575, 357)
        Me.Controls.Add(Me.PanelFondo)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPresentacion"
        Me.PanelFondo.ResumeLayout(False)
        Me.PanelFondo.PerformLayout()
        CType(Me.PictureBoxTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAServicesApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFondo As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents TimerPin As Timer
    Friend WithEvents LabelContador As Label
    Friend WithEvents ProgressBarPin As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents PictureBoxAServicesApp As PictureBox
    Friend WithEvents PictureBoxServicio As PictureBox
    Friend WithEvents PictureBoxTecnico As PictureBox
End Class
