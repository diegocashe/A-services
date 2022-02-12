<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBaseTecnicos
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBaseTecnicos))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelContenedorFormularios = New System.Windows.Forms.Panel()
        Me.PictureBoxLogoContainer = New System.Windows.Forms.PictureBox()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.PanelLateralOpciones = New System.Windows.Forms.Panel()
        Me.PanelSubMenu2 = New System.Windows.Forms.Panel()
        Me.IconButton11 = New FontAwesome.Sharp.IconButton()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.ButtonMenu6 = New FontAwesome.Sharp.IconButton()
        Me.PanelSubMenu1 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.ButtonMenu5 = New FontAwesome.Sharp.IconButton()
        Me.ButtonMenu4 = New FontAwesome.Sharp.IconButton()
        Me.ButtonMenu3 = New FontAwesome.Sharp.IconButton()
        Me.ButtonMenu2 = New FontAwesome.Sharp.IconButton()
        Me.ButtonLogOut = New FontAwesome.Sharp.IconButton()
        Me.ButtonInicio = New FontAwesome.Sharp.IconButton()
        Me.PanelLateralTop = New System.Windows.Forms.Panel()
        Me.ButtonPanelLateral = New FontAwesome.Sharp.IconButton()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonOcultarPanelLateral = New FontAwesome.Sharp.IconButton()
        Me.ButtonMinimizar = New FontAwesome.Sharp.IconButton()
        Me.ButtonRestaurar = New FontAwesome.Sharp.IconButton()
        Me.ButtonMaximizar = New FontAwesome.Sharp.IconButton()
        Me.ButtonClose = New FontAwesome.Sharp.IconButton()
        Me.TimerAbrirPanelLateral = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrarPanelLateral = New System.Windows.Forms.Timer(Me.components)
        Me.BT = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BTSubMenu = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ToolTipPrincipal = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelContenedorFormularios.SuspendLayout()
        CType(Me.PictureBoxLogoContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLateral.SuspendLayout()
        Me.PanelLateralOpciones.SuspendLayout()
        Me.PanelSubMenu2.SuspendLayout()
        Me.PanelSubMenu1.SuspendLayout()
        Me.PanelLateralTop.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.Transparent
        Me.PanelContenedor.Controls.Add(Me.Panel2)
        Me.PanelContenedor.Controls.Add(Me.Panel1)
        Me.PanelContenedor.Controls.Add(Me.PanelContenedorFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelLateral)
        Me.PanelContenedor.Controls.Add(Me.PanelTop)
        Me.BT.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1035, 660)
        Me.PanelContenedor.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.BT.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(202, 23)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(833, 1)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(200, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 637)
        Me.Panel1.TabIndex = 4
        '
        'PanelContenedorFormularios
        '
        Me.PanelContenedorFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelContenedorFormularios.Controls.Add(Me.PictureBoxLogoContainer)
        Me.BT.SetDecoration(Me.PanelContenedorFormularios, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelContenedorFormularios, BunifuAnimatorNS.DecorationType.None)
        Me.PanelContenedorFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorFormularios.Location = New System.Drawing.Point(200, 23)
        Me.PanelContenedorFormularios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelContenedorFormularios.Name = "PanelContenedorFormularios"
        Me.PanelContenedorFormularios.Size = New System.Drawing.Size(835, 637)
        Me.PanelContenedorFormularios.TabIndex = 3
        '
        'PictureBoxLogoContainer
        '
        Me.PictureBoxLogoContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLogoContainer.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogoContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTSubMenu.SetDecoration(Me.PictureBoxLogoContainer, BunifuAnimatorNS.DecorationType.None)
        Me.BT.SetDecoration(Me.PictureBoxLogoContainer, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBoxLogoContainer.Image = Global.InterfazUsuario.My.Resources.Resources._3_LogoBlancoSinFondo
        Me.PictureBoxLogoContainer.Location = New System.Drawing.Point(296, 208)
        Me.PictureBoxLogoContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxLogoContainer.Name = "PictureBoxLogoContainer"
        Me.PictureBoxLogoContainer.Size = New System.Drawing.Size(243, 220)
        Me.PictureBoxLogoContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogoContainer.TabIndex = 3
        Me.PictureBoxLogoContainer.TabStop = False
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelLateral.Controls.Add(Me.PanelLateralOpciones)
        Me.PanelLateral.Controls.Add(Me.PanelLateralTop)
        Me.BT.SetDecoration(Me.PanelLateral, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelLateral, BunifuAnimatorNS.DecorationType.None)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 23)
        Me.PanelLateral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(200, 637)
        Me.PanelLateral.TabIndex = 2
        '
        'PanelLateralOpciones
        '
        Me.PanelLateralOpciones.AutoScroll = True
        Me.PanelLateralOpciones.BackColor = System.Drawing.Color.Transparent
        Me.PanelLateralOpciones.Controls.Add(Me.PanelSubMenu2)
        Me.PanelLateralOpciones.Controls.Add(Me.ButtonMenu6)
        Me.PanelLateralOpciones.Controls.Add(Me.PanelSubMenu1)
        Me.PanelLateralOpciones.Controls.Add(Me.ButtonMenu5)
        Me.PanelLateralOpciones.Controls.Add(Me.ButtonMenu4)
        Me.PanelLateralOpciones.Controls.Add(Me.ButtonMenu3)
        Me.PanelLateralOpciones.Controls.Add(Me.ButtonMenu2)
        Me.PanelLateralOpciones.Controls.Add(Me.ButtonLogOut)
        Me.PanelLateralOpciones.Controls.Add(Me.ButtonInicio)
        Me.BT.SetDecoration(Me.PanelLateralOpciones, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelLateralOpciones, BunifuAnimatorNS.DecorationType.None)
        Me.PanelLateralOpciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLateralOpciones.Location = New System.Drawing.Point(0, 165)
        Me.PanelLateralOpciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelLateralOpciones.Name = "PanelLateralOpciones"
        Me.PanelLateralOpciones.Size = New System.Drawing.Size(200, 472)
        Me.PanelLateralOpciones.TabIndex = 1
        '
        'PanelSubMenu2
        '
        Me.PanelSubMenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PanelSubMenu2.Controls.Add(Me.IconButton11)
        Me.PanelSubMenu2.Controls.Add(Me.IconButton8)
        Me.BT.SetDecoration(Me.PanelSubMenu2, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelSubMenu2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSubMenu2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenu2.Location = New System.Drawing.Point(0, 355)
        Me.PanelSubMenu2.Name = "PanelSubMenu2"
        Me.PanelSubMenu2.Size = New System.Drawing.Size(183, 81)
        Me.PanelSubMenu2.TabIndex = 29
        Me.PanelSubMenu2.Visible = False
        '
        'IconButton11
        '
        Me.IconButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.IconButton11, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.IconButton11, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton11.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton11.FlatAppearance.BorderSize = 0
        Me.IconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton11.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton11.IconChar = FontAwesome.Sharp.IconChar.Fingerprint
        Me.IconButton11.IconColor = System.Drawing.Color.White
        Me.IconButton11.IconSize = 26
        Me.IconButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton11.Location = New System.Drawing.Point(0, 40)
        Me.IconButton11.Name = "IconButton11"
        Me.IconButton11.Rotation = 0R
        Me.IconButton11.Size = New System.Drawing.Size(183, 40)
        Me.IconButton11.TabIndex = 15
        Me.IconButton11.Text = "Escaner"
        Me.IconButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton11.UseVisualStyleBackColor = True
        '
        'IconButton8
        '
        Me.IconButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.IconButton8, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.IconButton8, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton8.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.Palette
        Me.IconButton8.IconColor = System.Drawing.Color.White
        Me.IconButton8.IconSize = 26
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.Location = New System.Drawing.Point(0, 0)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Rotation = 0R
        Me.IconButton8.Size = New System.Drawing.Size(183, 40)
        Me.IconButton8.TabIndex = 14
        Me.IconButton8.Text = "Temas"
        Me.IconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton8.UseVisualStyleBackColor = True
        '
        'ButtonMenu6
        '
        Me.ButtonMenu6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonMenu6, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonMenu6, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMenu6.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMenu6.FlatAppearance.BorderSize = 0
        Me.ButtonMenu6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu6.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonMenu6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMenu6.IconChar = FontAwesome.Sharp.IconChar.ChevronDown
        Me.ButtonMenu6.IconColor = System.Drawing.Color.White
        Me.ButtonMenu6.IconSize = 26
        Me.ButtonMenu6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu6.Location = New System.Drawing.Point(0, 315)
        Me.ButtonMenu6.Name = "ButtonMenu6"
        Me.ButtonMenu6.Rotation = 0R
        Me.ButtonMenu6.Size = New System.Drawing.Size(183, 40)
        Me.ButtonMenu6.TabIndex = 28
        Me.ButtonMenu6.Text = "Configuracion"
        Me.ButtonMenu6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonMenu6.UseVisualStyleBackColor = True
        '
        'PanelSubMenu1
        '
        Me.PanelSubMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PanelSubMenu1.Controls.Add(Me.IconButton2)
        Me.PanelSubMenu1.Controls.Add(Me.IconButton3)
        Me.PanelSubMenu1.Controls.Add(Me.IconButton4)
        Me.BT.SetDecoration(Me.PanelSubMenu1, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelSubMenu1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSubMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenu1.Location = New System.Drawing.Point(0, 194)
        Me.PanelSubMenu1.Name = "PanelSubMenu1"
        Me.PanelSubMenu1.Size = New System.Drawing.Size(183, 121)
        Me.PanelSubMenu1.TabIndex = 25
        Me.PanelSubMenu1.Visible = False
        '
        'IconButton2
        '
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.IconButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.IconButton2, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Hdd
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconSize = 26
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 80)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(183, 40)
        Me.IconButton2.TabIndex = 16
        Me.IconButton2.Text = "Disco Duro"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.IconButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.IconButton3, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Memory
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconSize = 26
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 40)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(183, 40)
        Me.IconButton3.TabIndex = 15
        Me.IconButton3.Text = "Memoria RAM"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.IconButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.IconButton4, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Microchip
        Me.IconButton4.IconColor = System.Drawing.Color.White
        Me.IconButton4.IconSize = 26
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 0)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(183, 40)
        Me.IconButton4.TabIndex = 14
        Me.IconButton4.Text = "CPU"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'ButtonMenu5
        '
        Me.ButtonMenu5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonMenu5, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonMenu5, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMenu5.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMenu5.FlatAppearance.BorderSize = 0
        Me.ButtonMenu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonMenu5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMenu5.IconChar = FontAwesome.Sharp.IconChar.ChevronDown
        Me.ButtonMenu5.IconColor = System.Drawing.Color.White
        Me.ButtonMenu5.IconSize = 26
        Me.ButtonMenu5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu5.Location = New System.Drawing.Point(0, 154)
        Me.ButtonMenu5.Name = "ButtonMenu5"
        Me.ButtonMenu5.Rotation = 0R
        Me.ButtonMenu5.Size = New System.Drawing.Size(183, 40)
        Me.ButtonMenu5.TabIndex = 24
        Me.ButtonMenu5.Text = "Rendimiento"
        Me.ButtonMenu5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonMenu5.UseVisualStyleBackColor = True
        '
        'ButtonMenu4
        '
        Me.ButtonMenu4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonMenu4, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonMenu4, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMenu4.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMenu4.FlatAppearance.BorderSize = 0
        Me.ButtonMenu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonMenu4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMenu4.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.ButtonMenu4.IconColor = System.Drawing.Color.White
        Me.ButtonMenu4.IconSize = 26
        Me.ButtonMenu4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu4.Location = New System.Drawing.Point(0, 114)
        Me.ButtonMenu4.Name = "ButtonMenu4"
        Me.ButtonMenu4.Rotation = 0R
        Me.ButtonMenu4.Size = New System.Drawing.Size(183, 40)
        Me.ButtonMenu4.TabIndex = 22
        Me.ButtonMenu4.Text = "Especificaciones"
        Me.ButtonMenu4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonMenu4.UseVisualStyleBackColor = True
        '
        'ButtonMenu3
        '
        Me.ButtonMenu3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonMenu3, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonMenu3, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMenu3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMenu3.FlatAppearance.BorderSize = 0
        Me.ButtonMenu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonMenu3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMenu3.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.ButtonMenu3.IconColor = System.Drawing.Color.White
        Me.ButtonMenu3.IconSize = 26
        Me.ButtonMenu3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu3.Location = New System.Drawing.Point(0, 80)
        Me.ButtonMenu3.Name = "ButtonMenu3"
        Me.ButtonMenu3.Rotation = 0R
        Me.ButtonMenu3.Size = New System.Drawing.Size(183, 34)
        Me.ButtonMenu3.TabIndex = 19
        Me.ButtonMenu3.Text = "Asistencias"
        Me.ButtonMenu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonMenu3.UseVisualStyleBackColor = True
        '
        'ButtonMenu2
        '
        Me.ButtonMenu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonMenu2, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonMenu2, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMenu2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMenu2.FlatAppearance.BorderSize = 0
        Me.ButtonMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonMenu2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMenu2.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.ButtonMenu2.IconColor = System.Drawing.Color.White
        Me.ButtonMenu2.IconSize = 26
        Me.ButtonMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu2.Location = New System.Drawing.Point(0, 40)
        Me.ButtonMenu2.Name = "ButtonMenu2"
        Me.ButtonMenu2.Rotation = 0R
        Me.ButtonMenu2.Size = New System.Drawing.Size(183, 40)
        Me.ButtonMenu2.TabIndex = 10
        Me.ButtonMenu2.Text = "Usuario"
        Me.ButtonMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonMenu2.UseVisualStyleBackColor = True
        '
        'ButtonLogOut
        '
        Me.BT.SetDecoration(Me.ButtonLogOut, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonLogOut, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonLogOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.ButtonLogOut.IconColor = System.Drawing.Color.White
        Me.ButtonLogOut.IconSize = 26
        Me.ButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogOut.Location = New System.Drawing.Point(0, 436)
        Me.ButtonLogOut.Name = "ButtonLogOut"
        Me.ButtonLogOut.Rotation = 0R
        Me.ButtonLogOut.Size = New System.Drawing.Size(183, 40)
        Me.ButtonLogOut.TabIndex = 8
        Me.ButtonLogOut.Text = "Salir"
        Me.ButtonLogOut.UseVisualStyleBackColor = True
        '
        'ButtonInicio
        '
        Me.ButtonInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonInicio, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonInicio, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonInicio.FlatAppearance.BorderSize = 0
        Me.ButtonInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonInicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonInicio.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.ButtonInicio.IconColor = System.Drawing.Color.White
        Me.ButtonInicio.IconSize = 26
        Me.ButtonInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInicio.Location = New System.Drawing.Point(0, 0)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Rotation = 0R
        Me.ButtonInicio.Size = New System.Drawing.Size(183, 40)
        Me.ButtonInicio.TabIndex = 0
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonInicio.UseVisualStyleBackColor = True
        '
        'PanelLateralTop
        '
        Me.PanelLateralTop.BackColor = System.Drawing.Color.Transparent
        Me.PanelLateralTop.Controls.Add(Me.ButtonPanelLateral)
        Me.PanelLateralTop.Controls.Add(Me.LabelTitulo)
        Me.PanelLateralTop.Controls.Add(Me.PictureBoxLogo)
        Me.BT.SetDecoration(Me.PanelLateralTop, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelLateralTop, BunifuAnimatorNS.DecorationType.None)
        Me.PanelLateralTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLateralTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateralTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelLateralTop.Name = "PanelLateralTop"
        Me.PanelLateralTop.Size = New System.Drawing.Size(200, 165)
        Me.PanelLateralTop.TabIndex = 0
        '
        'ButtonPanelLateral
        '
        Me.ButtonPanelLateral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPanelLateral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonPanelLateral, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonPanelLateral, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonPanelLateral.FlatAppearance.BorderSize = 0
        Me.ButtonPanelLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPanelLateral.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonPanelLateral.ForeColor = System.Drawing.Color.White
        Me.ButtonPanelLateral.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.ButtonPanelLateral.IconColor = System.Drawing.Color.White
        Me.ButtonPanelLateral.IconSize = 30
        Me.ButtonPanelLateral.Location = New System.Drawing.Point(164, 0)
        Me.ButtonPanelLateral.Name = "ButtonPanelLateral"
        Me.ButtonPanelLateral.Rotation = 0R
        Me.ButtonPanelLateral.Size = New System.Drawing.Size(36, 33)
        Me.ButtonPanelLateral.TabIndex = 1
        Me.ButtonPanelLateral.UseVisualStyleBackColor = True
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitulo.AutoSize = True
        Me.BTSubMenu.SetDecoration(Me.LabelTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.BT.SetDecoration(Me.LabelTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.LabelTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelTitulo.Location = New System.Drawing.Point(51, 124)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(100, 21)
        Me.LabelTitulo.TabIndex = 3
        Me.LabelTitulo.Text = "A SERVICES"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTSubMenu.SetDecoration(Me.PictureBoxLogo, BunifuAnimatorNS.DecorationType.None)
        Me.BT.SetDecoration(Me.PictureBoxLogo, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBoxLogo.Image = Global.InterfazUsuario.My.Resources.Resources._3_LogoBlancoSinFondo
        Me.PictureBoxLogo.Location = New System.Drawing.Point(32, 19)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(137, 101)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 2
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Controls.Add(Me.ButtonOcultarPanelLateral)
        Me.PanelTop.Controls.Add(Me.ButtonMinimizar)
        Me.PanelTop.Controls.Add(Me.ButtonRestaurar)
        Me.PanelTop.Controls.Add(Me.ButtonMaximizar)
        Me.PanelTop.Controls.Add(Me.ButtonClose)
        Me.BT.SetDecoration(Me.PanelTop, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.PanelTop, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelTop.MaximumSize = New System.Drawing.Size(2000, 23)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1035, 23)
        Me.PanelTop.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.BTSubMenu.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BT.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(50, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Modulo Tecnicos"
        '
        'ButtonOcultarPanelLateral
        '
        Me.ButtonOcultarPanelLateral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonOcultarPanelLateral, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonOcultarPanelLateral, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonOcultarPanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonOcultarPanelLateral.FlatAppearance.BorderSize = 0
        Me.ButtonOcultarPanelLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOcultarPanelLateral.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.ButtonOcultarPanelLateral.ForeColor = System.Drawing.Color.White
        Me.ButtonOcultarPanelLateral.IconChar = FontAwesome.Sharp.IconChar.CaretRight
        Me.ButtonOcultarPanelLateral.IconColor = System.Drawing.Color.White
        Me.ButtonOcultarPanelLateral.IconSize = 23
        Me.ButtonOcultarPanelLateral.Location = New System.Drawing.Point(0, 0)
        Me.ButtonOcultarPanelLateral.Name = "ButtonOcultarPanelLateral"
        Me.ButtonOcultarPanelLateral.Rotation = 0R
        Me.ButtonOcultarPanelLateral.Size = New System.Drawing.Size(36, 23)
        Me.ButtonOcultarPanelLateral.TabIndex = 4
        Me.ButtonOcultarPanelLateral.UseVisualStyleBackColor = True
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ButtonMinimizar.IconColor = System.Drawing.Color.White
        Me.ButtonMinimizar.IconSize = 16
        Me.ButtonMinimizar.Location = New System.Drawing.Point(807, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Rotation = 0R
        Me.ButtonMinimizar.Size = New System.Drawing.Size(57, 23)
        Me.ButtonMinimizar.TabIndex = 3
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonRestaurar
        '
        Me.ButtonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonRestaurar, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonRestaurar, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonRestaurar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonRestaurar.FlatAppearance.BorderSize = 0
        Me.ButtonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRestaurar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.ButtonRestaurar.IconColor = System.Drawing.Color.White
        Me.ButtonRestaurar.IconSize = 16
        Me.ButtonRestaurar.Location = New System.Drawing.Point(864, 0)
        Me.ButtonRestaurar.Name = "ButtonRestaurar"
        Me.ButtonRestaurar.Rotation = 0R
        Me.ButtonRestaurar.Size = New System.Drawing.Size(57, 23)
        Me.ButtonRestaurar.TabIndex = 2
        Me.ButtonRestaurar.UseVisualStyleBackColor = True
        Me.ButtonRestaurar.Visible = False
        '
        'ButtonMaximizar
        '
        Me.ButtonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMaximizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMaximizar.FlatAppearance.BorderSize = 0
        Me.ButtonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.ButtonMaximizar.IconColor = System.Drawing.Color.White
        Me.ButtonMaximizar.IconSize = 16
        Me.ButtonMaximizar.Location = New System.Drawing.Point(921, 0)
        Me.ButtonMaximizar.Name = "ButtonMaximizar"
        Me.ButtonMaximizar.Rotation = 0R
        Me.ButtonMaximizar.Size = New System.Drawing.Size(57, 23)
        Me.ButtonMaximizar.TabIndex = 1
        Me.ButtonMaximizar.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT.SetDecoration(Me.ButtonClose, BunifuAnimatorNS.DecorationType.None)
        Me.BTSubMenu.SetDecoration(Me.ButtonClose, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonClose.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ButtonClose.IconColor = System.Drawing.Color.White
        Me.ButtonClose.IconSize = 16
        Me.ButtonClose.Location = New System.Drawing.Point(978, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Rotation = 0R
        Me.ButtonClose.Size = New System.Drawing.Size(57, 23)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TimerAbrirPanelLateral
        '
        Me.TimerAbrirPanelLateral.Interval = 1
        '
        'TimerCerrarPanelLateral
        '
        Me.TimerCerrarPanelLateral.Interval = 1
        '
        'BT
        '
        Me.BT.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.BT.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 1.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BT.DefaultAnimation = Animation1
        Me.BT.TimeStep = 0.009!
        '
        'BTSubMenu
        '
        Me.BTSubMenu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BTSubMenu.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BTSubMenu.DefaultAnimation = Animation2
        Me.BTSubMenu.TimeStep = 0.03!
        '
        'ToolTipPrincipal
        '
        Me.ToolTipPrincipal.AutoPopDelay = 10000
        Me.ToolTipPrincipal.InitialDelay = 500
        Me.ToolTipPrincipal.ReshowDelay = 100
        Me.ToolTipPrincipal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipPrincipal.ToolTipTitle = "Informacion de interfaz"
        '
        'FormBaseTecnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 660)
        Me.Controls.Add(Me.PanelContenedor)
        Me.BTSubMenu.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BT.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1035, 660)
        Me.Name = "FormBaseTecnicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBasePrincipal"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedorFormularios.ResumeLayout(False)
        CType(Me.PictureBoxLogoContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelLateralOpciones.ResumeLayout(False)
        Me.PanelSubMenu2.ResumeLayout(False)
        Me.PanelSubMenu1.ResumeLayout(False)
        Me.PanelLateralTop.ResumeLayout(False)
        Me.PanelLateralTop.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelLateralTop As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonClose As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonRestaurar As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonPanelLateral As FontAwesome.Sharp.IconButton
    Friend WithEvents TimerAbrirPanelLateral As Timer
    Friend WithEvents TimerCerrarPanelLateral As Timer
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelLateralOpciones As Panel
    Friend WithEvents ButtonLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonOcultarPanelLateral As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BT As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BTSubMenu As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTipPrincipal As ToolTip
    Friend WithEvents PanelContenedorFormularios As Panel
    Friend WithEvents PictureBoxLogoContainer As PictureBox
    Friend WithEvents PanelSubMenu1 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMenu5 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMenu4 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMenu3 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMenu2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSubMenu2 As Panel
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMenu6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton11 As FontAwesome.Sharp.IconButton
End Class
