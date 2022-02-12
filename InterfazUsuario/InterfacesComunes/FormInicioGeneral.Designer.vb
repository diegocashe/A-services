<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicioGeneral
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LabelConteo = New System.Windows.Forms.Label()
        Me.ChartRendimiento = New Bunifu.DataViz.WinForms.BunifuDataViz()
        Me.ButtonIniciarGrafico = New FontAwesome.Sharp.IconButton()
        Me.ButtonReiniciarGrafico = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelCuentaLocal = New System.Windows.Forms.Label()
        Me.LabelDatoComputadora = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonClose = New FontAwesome.Sharp.IconButton()
        Me.LabelCargo = New System.Windows.Forms.Label()
        Me.LabelDependencia = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelIdentificador = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChartEspacioDiscoDuro = New Bunifu.DataViz.WinForms.BunifuDataViz()
        Me.ListViewDatosDiagnostico = New MetroFramework.Controls.MetroListView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelSistemaOperativo = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.Labelplat = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PC_PorcEspacioLibreDiscoDuro = New System.Diagnostics.PerformanceCounter()
        Me.PCMegabytesDisponibles = New System.Diagnostics.PerformanceCounter()
        Me.TimerGrafico = New System.Windows.Forms.Timer(Me.components)
        Me.PCProcesador = New System.Diagnostics.PerformanceCounter()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PC_PorcEspacioLibreDiscoDuro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCMegabytesDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCProcesador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(12, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(383, 36)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "GÁFICO DE RENDIMIENTO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(3, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(324, 36)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "DATOS DIAGNÓSTICO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(957, 267)
        Me.Panel2.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.LabelConteo)
        Me.Panel6.Controls.Add(Me.ChartRendimiento)
        Me.Panel6.Controls.Add(Me.ButtonIniciarGrafico)
        Me.Panel6.Controls.Add(Me.ButtonReiniciarGrafico)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(379, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(578, 267)
        Me.Panel6.TabIndex = 1
        '
        'LabelConteo
        '
        Me.LabelConteo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelConteo.AutoSize = True
        Me.LabelConteo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelConteo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelConteo.Location = New System.Drawing.Point(90, 63)
        Me.LabelConteo.Name = "LabelConteo"
        Me.LabelConteo.Size = New System.Drawing.Size(53, 17)
        Me.LabelConteo.TabIndex = 7
        Me.LabelConteo.Text = "Conteo"
        Me.LabelConteo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChartRendimiento
        '
        Me.ChartRendimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartRendimiento.animationEnabled = False
        Me.ChartRendimiento.AxisLineColor = System.Drawing.Color.Transparent
        Me.ChartRendimiento.AxisXFontColor = System.Drawing.Color.Gray
        Me.ChartRendimiento.AxisXGridColor = System.Drawing.Color.Gray
        Me.ChartRendimiento.AxisXGridThickness = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChartRendimiento.AxisYFontColor = System.Drawing.Color.Gray
        Me.ChartRendimiento.AxisYGridColor = System.Drawing.Color.Gray
        Me.ChartRendimiento.AxisYGridThickness = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChartRendimiento.BackColor = System.Drawing.Color.Transparent
        Me.ChartRendimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChartRendimiento.Location = New System.Drawing.Point(18, 92)
        Me.ChartRendimiento.Name = "ChartRendimiento"
        Me.ChartRendimiento.Size = New System.Drawing.Size(539, 161)
        Me.ChartRendimiento.TabIndex = 6
        Me.ChartRendimiento.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1
        Me.ChartRendimiento.Title = ""
        '
        'ButtonIniciarGrafico
        '
        Me.ButtonIniciarGrafico.FlatAppearance.BorderSize = 0
        Me.ButtonIniciarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIniciarGrafico.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonIniciarGrafico.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.ButtonIniciarGrafico.IconColor = System.Drawing.Color.White
        Me.ButtonIniciarGrafico.IconSize = 20
        Me.ButtonIniciarGrafico.Location = New System.Drawing.Point(15, 57)
        Me.ButtonIniciarGrafico.Name = "ButtonIniciarGrafico"
        Me.ButtonIniciarGrafico.Rotation = 0R
        Me.ButtonIniciarGrafico.Size = New System.Drawing.Size(30, 29)
        Me.ButtonIniciarGrafico.TabIndex = 5
        Me.ButtonIniciarGrafico.UseVisualStyleBackColor = True
        '
        'ButtonReiniciarGrafico
        '
        Me.ButtonReiniciarGrafico.FlatAppearance.BorderSize = 0
        Me.ButtonReiniciarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReiniciarGrafico.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonReiniciarGrafico.IconChar = FontAwesome.Sharp.IconChar.Sync
        Me.ButtonReiniciarGrafico.IconColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonReiniciarGrafico.IconSize = 20
        Me.ButtonReiniciarGrafico.Location = New System.Drawing.Point(51, 57)
        Me.ButtonReiniciarGrafico.Name = "ButtonReiniciarGrafico"
        Me.ButtonReiniciarGrafico.Rotation = 0R
        Me.ButtonReiniciarGrafico.Size = New System.Drawing.Size(30, 29)
        Me.ButtonReiniciarGrafico.TabIndex = 4
        Me.ButtonReiniciarGrafico.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.LabelCuentaLocal)
        Me.Panel5.Controls.Add(Me.LabelDatoComputadora)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.ButtonClose)
        Me.Panel5.Controls.Add(Me.LabelCargo)
        Me.Panel5.Controls.Add(Me.LabelDependencia)
        Me.Panel5.Controls.Add(Me.LabelUsuario)
        Me.Panel5.Controls.Add(Me.LabelIdentificador)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(411, 267)
        Me.Panel5.TabIndex = 0
        '
        'LabelCuentaLocal
        '
        Me.LabelCuentaLocal.AutoSize = True
        Me.LabelCuentaLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelCuentaLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCuentaLocal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuentaLocal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelCuentaLocal.Location = New System.Drawing.Point(179, 210)
        Me.LabelCuentaLocal.Name = "LabelCuentaLocal"
        Me.LabelCuentaLocal.Size = New System.Drawing.Size(114, 23)
        Me.LabelCuentaLocal.TabIndex = 32
        Me.LabelCuentaLocal.Text = "CuentaLocal"
        '
        'LabelDatoComputadora
        '
        Me.LabelDatoComputadora.AutoSize = True
        Me.LabelDatoComputadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelDatoComputadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelDatoComputadora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDatoComputadora.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelDatoComputadora.Location = New System.Drawing.Point(179, 179)
        Me.LabelDatoComputadora.Name = "LabelDatoComputadora"
        Me.LabelDatoComputadora.Size = New System.Drawing.Size(25, 23)
        Me.LabelDatoComputadora.TabIndex = 31
        Me.LabelDatoComputadora.Text = "TI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(23, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "CuentaLocal:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(23, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Computadora:"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonClose.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.ButtonClose.IconColor = System.Drawing.Color.White
        Me.ButtonClose.IconSize = 20
        Me.ButtonClose.Location = New System.Drawing.Point(323, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Rotation = 0R
        Me.ButtonClose.Size = New System.Drawing.Size(39, 34)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'LabelCargo
        '
        Me.LabelCargo.AutoSize = True
        Me.LabelCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCargo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCargo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelCargo.Location = New System.Drawing.Point(179, 147)
        Me.LabelCargo.Name = "LabelCargo"
        Me.LabelCargo.Size = New System.Drawing.Size(75, 23)
        Me.LabelCargo.TabIndex = 28
        Me.LabelCargo.Text = "CLIENTE"
        '
        'LabelDependencia
        '
        Me.LabelDependencia.AutoSize = True
        Me.LabelDependencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelDependencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelDependencia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDependencia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelDependencia.Location = New System.Drawing.Point(179, 115)
        Me.LabelDependencia.Name = "LabelDependencia"
        Me.LabelDependencia.Size = New System.Drawing.Size(79, 23)
        Me.LabelDependencia.TabIndex = 27
        Me.LabelDependencia.Text = "Empresa"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelUsuario.Location = New System.Drawing.Point(100, 51)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(68, 23)
        Me.LabelUsuario.TabIndex = 26
        Me.LabelUsuario.Text = "Usuario"
        '
        'LabelIdentificador
        '
        Me.LabelIdentificador.AutoSize = True
        Me.LabelIdentificador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelIdentificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelIdentificador.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdentificador.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelIdentificador.Location = New System.Drawing.Point(179, 83)
        Me.LabelIdentificador.Name = "LabelIdentificador"
        Me.LabelIdentificador.Size = New System.Drawing.Size(29, 23)
        Me.LabelIdentificador.TabIndex = 25
        Me.LabelIdentificador.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(23, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Identificador:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "BIENVENIDO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(23, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(23, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cargo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(23, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Dependencia:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 267)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(957, 338)
        Me.Panel4.TabIndex = 17
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.AutoScroll = True
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Panel1)
        Me.Panel7.Controls.Add(Me.ListViewDatosDiagnostico)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Location = New System.Drawing.Point(293, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(664, 338)
        Me.Panel7.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ChartEspacioDiscoDuro)
        Me.Panel1.Location = New System.Drawing.Point(342, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 335)
        Me.Panel1.TabIndex = 19
        '
        'ChartEspacioDiscoDuro
        '
        Me.ChartEspacioDiscoDuro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartEspacioDiscoDuro.animationEnabled = False
        Me.ChartEspacioDiscoDuro.AxisLineColor = System.Drawing.Color.Transparent
        Me.ChartEspacioDiscoDuro.AxisXFontColor = System.Drawing.Color.Gray
        Me.ChartEspacioDiscoDuro.AxisXGridColor = System.Drawing.Color.Gray
        Me.ChartEspacioDiscoDuro.AxisXGridThickness = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChartEspacioDiscoDuro.AxisYFontColor = System.Drawing.Color.Gray
        Me.ChartEspacioDiscoDuro.AxisYGridColor = System.Drawing.Color.Gray
        Me.ChartEspacioDiscoDuro.AxisYGridThickness = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChartEspacioDiscoDuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ChartEspacioDiscoDuro.Location = New System.Drawing.Point(3, 3)
        Me.ChartEspacioDiscoDuro.Name = "ChartEspacioDiscoDuro"
        Me.ChartEspacioDiscoDuro.Size = New System.Drawing.Size(307, 303)
        Me.ChartEspacioDiscoDuro.TabIndex = 18
        Me.ChartEspacioDiscoDuro.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1
        Me.ChartEspacioDiscoDuro.Title = "Memoria ROM"
        '
        'ListViewDatosDiagnostico
        '
        Me.ListViewDatosDiagnostico.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListViewDatosDiagnostico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewDatosDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ListViewDatosDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewDatosDiagnostico.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ListViewDatosDiagnostico.FullRowSelect = True
        Me.ListViewDatosDiagnostico.Location = New System.Drawing.Point(9, 53)
        Me.ListViewDatosDiagnostico.MaximumSize = New System.Drawing.Size(320, 200)
        Me.ListViewDatosDiagnostico.MinimumSize = New System.Drawing.Size(300, 150)
        Me.ListViewDatosDiagnostico.Name = "ListViewDatosDiagnostico"
        Me.ListViewDatosDiagnostico.OwnerDraw = True
        Me.ListViewDatosDiagnostico.Scrollable = False
        Me.ListViewDatosDiagnostico.Size = New System.Drawing.Size(300, 200)
        Me.ListViewDatosDiagnostico.Style = MetroFramework.MetroColorStyle.Silver
        Me.ListViewDatosDiagnostico.TabIndex = 17
        Me.ListViewDatosDiagnostico.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ListViewDatosDiagnostico.TileSize = New System.Drawing.Size(50, 50)
        Me.ListViewDatosDiagnostico.UseCompatibleStateImageBehavior = False
        Me.ListViewDatosDiagnostico.UseCustomBackColor = True
        Me.ListViewDatosDiagnostico.UseCustomForeColor = True
        Me.ListViewDatosDiagnostico.UseSelectable = True
        Me.ListViewDatosDiagnostico.UseStyleColors = True
        Me.ListViewDatosDiagnostico.View = System.Windows.Forms.View.Details
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.Label16)
        Me.Panel8.Controls.Add(Me.LabelSistemaOperativo)
        Me.Panel8.Controls.Add(Me.LabelVersion)
        Me.Panel8.Controls.Add(Me.Labelplat)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.LabelFecha)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(957, 338)
        Me.Panel8.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(13, 151)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 21)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Version"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(13, 218)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 21)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Plataforma"
        '
        'LabelSistemaOperativo
        '
        Me.LabelSistemaOperativo.AutoSize = True
        Me.LabelSistemaOperativo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSistemaOperativo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelSistemaOperativo.Location = New System.Drawing.Point(13, 119)
        Me.LabelSistemaOperativo.Name = "LabelSistemaOperativo"
        Me.LabelSistemaOperativo.Size = New System.Drawing.Size(37, 19)
        Me.LabelSistemaOperativo.TabIndex = 25
        Me.LabelSistemaOperativo.Text = "Win"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelVersion.Location = New System.Drawing.Point(13, 183)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(155, 21)
        Me.LabelVersion.TabIndex = 24
        Me.LabelVersion.Text = "Sistema Operativo"
        '
        'Labelplat
        '
        Me.Labelplat.AutoSize = True
        Me.Labelplat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelplat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Labelplat.Location = New System.Drawing.Point(13, 252)
        Me.Labelplat.Name = "Labelplat"
        Me.Labelplat.Size = New System.Drawing.Size(40, 21)
        Me.Labelplat.TabIndex = 23
        Me.Labelplat.Text = "Plat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(47, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "FechaIndexada"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelFecha.Location = New System.Drawing.Point(12, 88)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(155, 21)
        Me.LabelFecha.TabIndex = 22
        Me.LabelFecha.Text = "Sistema Operativo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(13, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ultima Revisión del Equipo"
        '
        'PC_PorcEspacioLibreDiscoDuro
        '
        Me.PC_PorcEspacioLibreDiscoDuro.CategoryName = "Disco lógico"
        Me.PC_PorcEspacioLibreDiscoDuro.CounterName = "% de espacio disponible"
        Me.PC_PorcEspacioLibreDiscoDuro.InstanceName = "_Total"
        Me.PC_PorcEspacioLibreDiscoDuro.MachineName = "DESKTOP-MPT44JU"
        '
        'PCMegabytesDisponibles
        '
        Me.PCMegabytesDisponibles.CategoryName = "Disco lógico"
        Me.PCMegabytesDisponibles.CounterName = "Megabytes disponibles"
        Me.PCMegabytesDisponibles.InstanceName = "_Total"
        Me.PCMegabytesDisponibles.MachineName = "DESKTOP-MPT44JU"
        '
        'TimerGrafico
        '
        '
        'PCProcesador
        '
        Me.PCProcesador.CategoryName = "Procesador"
        Me.PCProcesador.CounterName = "% de tiempo de procesador"
        Me.PCProcesador.InstanceName = "_Total"
        Me.PCProcesador.MachineName = "DESKTOP-MPT44JU"
        '
        'FormInicioGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 605)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInicioGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmInicio_clientes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PC_PorcEspacioLibreDiscoDuro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCMegabytesDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCProcesador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents LabelCargo As Label
    Friend WithEvents LabelDependencia As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelIdentificador As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelCuentaLocal As Label
    Friend WithEvents LabelDatoComputadora As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListViewDatosDiagnostico As MetroFramework.Controls.MetroListView
    Friend WithEvents ChartEspacioDiscoDuro As Bunifu.DataViz.WinForms.BunifuDataViz
    Friend WithEvents Labelplat As Label
    Friend WithEvents PC_PorcEspacioLibreDiscoDuro As PerformanceCounter
    Friend WithEvents PCMegabytesDisponibles As PerformanceCounter
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelSistemaOperativo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ButtonIniciarGrafico As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonReiniciarGrafico As FontAwesome.Sharp.IconButton
    Friend WithEvents TimerGrafico As Timer
    Friend WithEvents PCProcesador As PerformanceCounter
    Friend WithEvents ChartRendimiento As Bunifu.DataViz.WinForms.BunifuDataViz
    Friend WithEvents LabelConteo As Label
End Class
