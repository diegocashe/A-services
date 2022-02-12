<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PanelPrincipalLeft = New System.Windows.Forms.Panel()
        Me.PanelGrandientLeft = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBoxTecnico = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCandado = New System.Windows.Forms.PictureBox()
        Me.PictureBoxServicio = New System.Windows.Forms.PictureBox()
        Me.PictureBoxNombreApp = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipalRight = New System.Windows.Forms.Panel()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.LinkNosotros = New System.Windows.Forms.LinkLabel()
        Me.LinkAyuda = New System.Windows.Forms.LinkLabel()
        Me.LinkRegistro = New System.Windows.Forms.LinkLabel()
        Me.LinkDerechosAutor = New System.Windows.Forms.LinkLabel()
        Me.LinkContacto = New System.Windows.Forms.LinkLabel()
        Me.PanelColoresAmarillo = New System.Windows.Forms.Panel()
        Me.PanelColoresVerde = New System.Windows.Forms.Panel()
        Me.PanelColoresRojo = New System.Windows.Forms.Panel()
        Me.PanelColoresAzul = New System.Windows.Forms.Panel()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonEntrar = New System.Windows.Forms.Button()
        Me.LineContraseña = New System.Windows.Forms.Panel()
        Me.LineUsuario = New System.Windows.Forms.Panel()
        Me.LabelPrincipal = New System.Windows.Forms.Label()
        Me.PanelShadow = New System.Windows.Forms.Panel()
        Me.PanelPrincipalLeft.SuspendLayout()
        Me.PanelGrandientLeft.SuspendLayout()
        CType(Me.PictureBoxTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCandado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxNombreApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipalRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPrincipalLeft
        '
        Me.PanelPrincipalLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelPrincipalLeft.Controls.Add(Me.PanelGrandientLeft)
        Me.PanelPrincipalLeft.Location = New System.Drawing.Point(2, 65)
        Me.PanelPrincipalLeft.Name = "PanelPrincipalLeft"
        Me.PanelPrincipalLeft.Size = New System.Drawing.Size(350, 350)
        Me.PanelPrincipalLeft.TabIndex = 1
        '
        'PanelGrandientLeft
        '
        Me.PanelGrandientLeft.BackgroundImage = CType(resources.GetObject("PanelGrandientLeft.BackgroundImage"), System.Drawing.Image)
        Me.PanelGrandientLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelGrandientLeft.Controls.Add(Me.PictureBoxTecnico)
        Me.PanelGrandientLeft.Controls.Add(Me.PictureBoxCandado)
        Me.PanelGrandientLeft.Controls.Add(Me.PictureBoxServicio)
        Me.PanelGrandientLeft.Controls.Add(Me.PictureBoxNombreApp)
        Me.PanelGrandientLeft.Controls.Add(Me.PictureBoxLogo)
        Me.PanelGrandientLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrandientLeft.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelGrandientLeft.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelGrandientLeft.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelGrandientLeft.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelGrandientLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelGrandientLeft.Name = "PanelGrandientLeft"
        Me.PanelGrandientLeft.Quality = 100
        Me.PanelGrandientLeft.Size = New System.Drawing.Size(350, 350)
        Me.PanelGrandientLeft.TabIndex = 7
        '
        'PictureBoxTecnico
        '
        Me.PictureBoxTecnico.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxTecnico.Image = Global.InterfazUsuario.My.Resources.Resources._3_tecnicoLetrasBlancas
        Me.PictureBoxTecnico.Location = New System.Drawing.Point(179, 231)
        Me.PictureBoxTecnico.Name = "PictureBoxTecnico"
        Me.PictureBoxTecnico.Size = New System.Drawing.Size(127, 23)
        Me.PictureBoxTecnico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxTecnico.TabIndex = 9
        Me.PictureBoxTecnico.TabStop = False
        '
        'PictureBoxCandado
        '
        Me.PictureBoxCandado.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxCandado.Image = CType(resources.GetObject("PictureBoxCandado.Image"), System.Drawing.Image)
        Me.PictureBoxCandado.Location = New System.Drawing.Point(225, 299)
        Me.PictureBoxCandado.Name = "PictureBoxCandado"
        Me.PictureBoxCandado.Size = New System.Drawing.Size(122, 51)
        Me.PictureBoxCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCandado.TabIndex = 5
        Me.PictureBoxCandado.TabStop = False
        '
        'PictureBoxServicio
        '
        Me.PictureBoxServicio.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxServicio.Image = Global.InterfazUsuario.My.Resources.Resources._3__ServicioLetrasBlancas
        Me.PictureBoxServicio.Location = New System.Drawing.Point(44, 231)
        Me.PictureBoxServicio.Name = "PictureBoxServicio"
        Me.PictureBoxServicio.Size = New System.Drawing.Size(129, 23)
        Me.PictureBoxServicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxServicio.TabIndex = 8
        Me.PictureBoxServicio.TabStop = False
        '
        'PictureBoxNombreApp
        '
        Me.PictureBoxNombreApp.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxNombreApp.Image = Global.InterfazUsuario.My.Resources.Resources._3_AServicesLetrasBlancas
        Me.PictureBoxNombreApp.Location = New System.Drawing.Point(58, 182)
        Me.PictureBoxNombreApp.Name = "PictureBoxNombreApp"
        Me.PictureBoxNombreApp.Size = New System.Drawing.Size(226, 43)
        Me.PictureBoxNombreApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxNombreApp.TabIndex = 7
        Me.PictureBoxNombreApp.TabStop = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(85, 23)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(171, 160)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 6
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelPrincipalRight
        '
        Me.PanelPrincipalRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelPrincipalRight.Controls.Add(Me.TextBoxContraseña)
        Me.PanelPrincipalRight.Controls.Add(Me.TextBoxUsuario)
        Me.PanelPrincipalRight.Controls.Add(Me.LinkNosotros)
        Me.PanelPrincipalRight.Controls.Add(Me.LinkAyuda)
        Me.PanelPrincipalRight.Controls.Add(Me.LinkRegistro)
        Me.PanelPrincipalRight.Controls.Add(Me.LinkDerechosAutor)
        Me.PanelPrincipalRight.Controls.Add(Me.LinkContacto)
        Me.PanelPrincipalRight.Controls.Add(Me.PanelColoresAmarillo)
        Me.PanelPrincipalRight.Controls.Add(Me.PanelColoresVerde)
        Me.PanelPrincipalRight.Controls.Add(Me.PanelColoresRojo)
        Me.PanelPrincipalRight.Controls.Add(Me.PanelColoresAzul)
        Me.PanelPrincipalRight.Controls.Add(Me.ButtonSalir)
        Me.PanelPrincipalRight.Controls.Add(Me.ButtonEntrar)
        Me.PanelPrincipalRight.Controls.Add(Me.LineContraseña)
        Me.PanelPrincipalRight.Controls.Add(Me.LineUsuario)
        Me.PanelPrincipalRight.Controls.Add(Me.LabelPrincipal)
        Me.PanelPrincipalRight.Location = New System.Drawing.Point(348, 6)
        Me.PanelPrincipalRight.Name = "PanelPrincipalRight"
        Me.PanelPrincipalRight.Size = New System.Drawing.Size(440, 450)
        Me.PanelPrincipalRight.TabIndex = 2
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxContraseña.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxContraseña.Location = New System.Drawing.Point(78, 204)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(277, 26)
        Me.TextBoxContraseña.TabIndex = 2
        Me.TextBoxContraseña.Text = "Contraseña"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxUsuario.Location = New System.Drawing.Point(78, 119)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(277, 26)
        Me.TextBoxUsuario.TabIndex = 1
        Me.TextBoxUsuario.Text = "Usuario"
        '
        'LinkNosotros
        '
        Me.LinkNosotros.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkNosotros.AutoSize = True
        Me.LinkNosotros.BackColor = System.Drawing.Color.Transparent
        Me.LinkNosotros.LinkColor = System.Drawing.Color.White
        Me.LinkNosotros.Location = New System.Drawing.Point(131, 358)
        Me.LinkNosotros.Name = "LinkNosotros"
        Me.LinkNosotros.Size = New System.Drawing.Size(49, 13)
        Me.LinkNosotros.TabIndex = 5
        Me.LinkNosotros.TabStop = True
        Me.LinkNosotros.Text = "Nosotros"
        Me.LinkNosotros.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'LinkAyuda
        '
        Me.LinkAyuda.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkAyuda.AutoSize = True
        Me.LinkAyuda.BackColor = System.Drawing.Color.Transparent
        Me.LinkAyuda.LinkColor = System.Drawing.Color.White
        Me.LinkAyuda.Location = New System.Drawing.Point(200, 358)
        Me.LinkAyuda.Name = "LinkAyuda"
        Me.LinkAyuda.Size = New System.Drawing.Size(37, 13)
        Me.LinkAyuda.TabIndex = 6
        Me.LinkAyuda.TabStop = True
        Me.LinkAyuda.Text = "Ayuda"
        Me.LinkAyuda.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'LinkRegistro
        '
        Me.LinkRegistro.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkRegistro.AutoSize = True
        Me.LinkRegistro.BackColor = System.Drawing.Color.Transparent
        Me.LinkRegistro.LinkColor = System.Drawing.Color.White
        Me.LinkRegistro.Location = New System.Drawing.Point(255, 358)
        Me.LinkRegistro.Name = "LinkRegistro"
        Me.LinkRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LinkRegistro.Size = New System.Drawing.Size(46, 13)
        Me.LinkRegistro.TabIndex = 7
        Me.LinkRegistro.TabStop = True
        Me.LinkRegistro.Text = "Registro"
        Me.LinkRegistro.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'LinkDerechosAutor
        '
        Me.LinkDerechosAutor.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkDerechosAutor.AutoSize = True
        Me.LinkDerechosAutor.BackColor = System.Drawing.Color.Transparent
        Me.LinkDerechosAutor.LinkColor = System.Drawing.Color.White
        Me.LinkDerechosAutor.Location = New System.Drawing.Point(321, 358)
        Me.LinkDerechosAutor.Name = "LinkDerechosAutor"
        Me.LinkDerechosAutor.Size = New System.Drawing.Size(56, 13)
        Me.LinkDerechosAutor.TabIndex = 8
        Me.LinkDerechosAutor.TabStop = True
        Me.LinkDerechosAutor.Text = "Copyrights"
        Me.LinkDerechosAutor.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'LinkContacto
        '
        Me.LinkContacto.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkContacto.AutoSize = True
        Me.LinkContacto.BackColor = System.Drawing.Color.Transparent
        Me.LinkContacto.LinkColor = System.Drawing.Color.White
        Me.LinkContacto.Location = New System.Drawing.Point(61, 358)
        Me.LinkContacto.Name = "LinkContacto"
        Me.LinkContacto.Size = New System.Drawing.Size(50, 13)
        Me.LinkContacto.TabIndex = 0
        Me.LinkContacto.TabStop = True
        Me.LinkContacto.Tag = "0"
        Me.LinkContacto.Text = "Contacto"
        Me.LinkContacto.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'PanelColoresAmarillo
        '
        Me.PanelColoresAmarillo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelColoresAmarillo.Location = New System.Drawing.Point(330, 397)
        Me.PanelColoresAmarillo.Name = "PanelColoresAmarillo"
        Me.PanelColoresAmarillo.Size = New System.Drawing.Size(110, 10)
        Me.PanelColoresAmarillo.TabIndex = 10
        '
        'PanelColoresVerde
        '
        Me.PanelColoresVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelColoresVerde.Location = New System.Drawing.Point(220, 397)
        Me.PanelColoresVerde.Name = "PanelColoresVerde"
        Me.PanelColoresVerde.Size = New System.Drawing.Size(110, 10)
        Me.PanelColoresVerde.TabIndex = 9
        '
        'PanelColoresRojo
        '
        Me.PanelColoresRojo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelColoresRojo.Location = New System.Drawing.Point(1, 397)
        Me.PanelColoresRojo.Name = "PanelColoresRojo"
        Me.PanelColoresRojo.Size = New System.Drawing.Size(110, 10)
        Me.PanelColoresRojo.TabIndex = 9
        '
        'PanelColoresAzul
        '
        Me.PanelColoresAzul.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelColoresAzul.Location = New System.Drawing.Point(110, 397)
        Me.PanelColoresAzul.Name = "PanelColoresAzul"
        Me.PanelColoresAzul.Size = New System.Drawing.Size(110, 10)
        Me.PanelColoresAzul.TabIndex = 8
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonSalir.Location = New System.Drawing.Point(59, 290)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(154, 45)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'ButtonEntrar
        '
        Me.ButtonEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEntrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonEntrar.Location = New System.Drawing.Point(225, 290)
        Me.ButtonEntrar.Name = "ButtonEntrar"
        Me.ButtonEntrar.Size = New System.Drawing.Size(154, 45)
        Me.ButtonEntrar.TabIndex = 3
        Me.ButtonEntrar.Text = "Entrar"
        Me.ButtonEntrar.UseVisualStyleBackColor = False
        '
        'LineContraseña
        '
        Me.LineContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineContraseña.Location = New System.Drawing.Point(78, 241)
        Me.LineContraseña.Name = "LineContraseña"
        Me.LineContraseña.Size = New System.Drawing.Size(277, 1)
        Me.LineContraseña.TabIndex = 2
        '
        'LineUsuario
        '
        Me.LineUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineUsuario.Location = New System.Drawing.Point(78, 156)
        Me.LineUsuario.Name = "LineUsuario"
        Me.LineUsuario.Size = New System.Drawing.Size(277, 1)
        Me.LineUsuario.TabIndex = 1
        '
        'LabelPrincipal
        '
        Me.LabelPrincipal.AutoSize = True
        Me.LabelPrincipal.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelPrincipal.Location = New System.Drawing.Point(155, 59)
        Me.LabelPrincipal.Name = "LabelPrincipal"
        Me.LabelPrincipal.Size = New System.Drawing.Size(146, 32)
        Me.LabelPrincipal.TabIndex = 0
        Me.LabelPrincipal.Text = "INGRESAR"
        '
        'PanelShadow
        '
        Me.PanelShadow.BackColor = System.Drawing.Color.Black
        Me.PanelShadow.Location = New System.Drawing.Point(357, 14)
        Me.PanelShadow.Name = "PanelShadow"
        Me.PanelShadow.Size = New System.Drawing.Size(464, 488)
        Me.PanelShadow.TabIndex = 11
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(792, 462)
        Me.Controls.Add(Me.PanelPrincipalRight)
        Me.Controls.Add(Me.PanelPrincipalLeft)
        Me.Controls.Add(Me.PanelShadow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.PanelPrincipalLeft.ResumeLayout(False)
        Me.PanelGrandientLeft.ResumeLayout(False)
        CType(Me.PictureBoxTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCandado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxNombreApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipalRight.ResumeLayout(False)
        Me.PanelPrincipalRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipalLeft As Panel
    Friend WithEvents PanelPrincipalRight As Panel
    Friend WithEvents LineContraseña As Panel
    Friend WithEvents LineUsuario As Panel
    Friend WithEvents LabelPrincipal As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PictureBoxCandado As PictureBox
    Friend WithEvents LinkNosotros As LinkLabel
    Friend WithEvents LinkAyuda As LinkLabel
    Friend WithEvents LinkRegistro As LinkLabel
    Friend WithEvents LinkDerechosAutor As LinkLabel
    Friend WithEvents LinkContacto As LinkLabel
    Friend WithEvents PanelColoresAmarillo As Panel
    Friend WithEvents PanelColoresVerde As Panel
    Friend WithEvents PanelColoresRojo As Panel
    Friend WithEvents PanelColoresAzul As Panel
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonEntrar As Button
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents PanelShadow As Panel
    Friend WithEvents PanelGrandientLeft As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBoxNombreApp As PictureBox
    Friend WithEvents PictureBoxServicio As PictureBox
    Friend WithEvents PictureBoxTecnico As PictureBox
End Class
