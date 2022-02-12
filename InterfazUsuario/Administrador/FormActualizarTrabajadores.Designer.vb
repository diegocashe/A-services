<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormActualizarTrabajadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActualizarTrabajadores))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonClose = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.BTModificarDatos = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_pnombre = New MetroFramework.Controls.MetroTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_Snombre = New MetroFramework.Controls.MetroTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_Papellido = New MetroFramework.Controls.MetroTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_Sapellido = New MetroFramework.Controls.MetroTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TB_Telefono = New MetroFramework.Controls.MetroTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DropdownNivelEstudio = New MetroFramework.Controls.MetroComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DropDownPais = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownEstados = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownMunicipios = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownParroquias = New MetroFramework.Controls.MetroComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TBUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.TBContra = New MetroFramework.Controls.MetroTextBox()
        Me.TB_correo = New MetroFramework.Controls.MetroTextBox()
        Me.ButtonActualizar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LabelEspecialidad = New System.Windows.Forms.Label()
        Me.LabelCuentaDeUsuario = New System.Windows.Forms.Label()
        Me.LabelPnombre = New System.Windows.Forms.Label()
        Me.LabelSnombre = New System.Windows.Forms.Label()
        Me.LabelPapellido = New System.Windows.Forms.Label()
        Me.LabelSapellido = New System.Windows.Forms.Label()
        Me.LabelCi = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelNivelEstudio = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DropdownTrabajador = New MetroFramework.Controls.MetroComboBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(49, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 21)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Seleccione el Trabajador a actualizar: "
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTModificarDatos.SetDecoration(Me.ButtonClose, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonClose.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.ButtonClose.IconColor = System.Drawing.Color.White
        Me.ButtonClose.IconSize = 20
        Me.ButtonClose.Location = New System.Drawing.Point(444, 15)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Rotation = 0R
        Me.ButtonClose.Size = New System.Drawing.Size(39, 34)
        Me.ButtonClose.TabIndex = 81
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(26, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 36)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Modificacion de Trabajador"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Actualizar Datos"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTModificarDatos.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(9, 435)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(449, 49)
        Me.BunifuFlatButton1.TabIndex = 106
        Me.BunifuFlatButton1.Text = "Actualizar Datos"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TextBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BTModificarDatos.SetDecoration(Me.TextBoxDireccion, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxDireccion.Enabled = False
        Me.TextBoxDireccion.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TextBoxDireccion.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBoxDireccion.Location = New System.Drawing.Point(196, 372)
        Me.TextBoxDireccion.Multiline = True
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(250, 44)
        Me.TextBoxDireccion.TabIndex = 107
        '
        'BTModificarDatos
        '
        Me.BTModificarDatos.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.BTModificarDatos.Cursor = Nothing
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
        Me.BTModificarDatos.DefaultAnimation = Animation1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.BTModificarDatos.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(465, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 490)
        Me.Panel1.TabIndex = 105
        Me.Panel1.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_pnombre)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_Snombre)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_Papellido)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_Sapellido)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label20)
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_Telefono)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel1.Controls.Add(Me.DropdownNivelEstudio)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.DropDownPais)
        Me.FlowLayoutPanel1.Controls.Add(Me.DropDownEstados)
        Me.FlowLayoutPanel1.Controls.Add(Me.DropDownMunicipios)
        Me.FlowLayoutPanel1.Controls.Add(Me.DropDownParroquias)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label19)
        Me.FlowLayoutPanel1.Controls.Add(Me.TBUsuario)
        Me.FlowLayoutPanel1.Controls.Add(Me.TBContra)
        Me.FlowLayoutPanel1.Controls.Add(Me.TB_correo)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonActualizar)
        Me.BTModificarDatos.SetDecoration(Me.FlowLayoutPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(448, 490)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(13, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 22)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Datos Nuevos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(13, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Primer Nombre:"
        '
        'TB_pnombre
        '
        '
        '
        '
        Me.TB_pnombre.CustomButton.Image = Nothing
        Me.TB_pnombre.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TB_pnombre.CustomButton.Name = ""
        Me.TB_pnombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_pnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_pnombre.CustomButton.TabIndex = 1
        Me.TB_pnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_pnombre.CustomButton.UseSelectable = True
        Me.TB_pnombre.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TB_pnombre, BunifuAnimatorNS.DecorationType.None)
        Me.TB_pnombre.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_pnombre.Lines = New String() {" "}
        Me.TB_pnombre.Location = New System.Drawing.Point(13, 52)
        Me.TB_pnombre.MaxLength = 32767
        Me.TB_pnombre.Name = "TB_pnombre"
        Me.TB_pnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_pnombre.PromptText = "Primer Nombre"
        Me.TB_pnombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_pnombre.SelectedText = ""
        Me.TB_pnombre.SelectionLength = 0
        Me.TB_pnombre.SelectionStart = 0
        Me.TB_pnombre.ShortcutsEnabled = True
        Me.TB_pnombre.Size = New System.Drawing.Size(415, 29)
        Me.TB_pnombre.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_pnombre.TabIndex = 113
        Me.TB_pnombre.Text = " "
        Me.TB_pnombre.UseSelectable = True
        Me.TB_pnombre.WaterMark = "Primer Nombre"
        Me.TB_pnombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_pnombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(13, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 17)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Segundo Nombre:"
        '
        'TB_Snombre
        '
        '
        '
        '
        Me.TB_Snombre.CustomButton.Image = Nothing
        Me.TB_Snombre.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TB_Snombre.CustomButton.Name = ""
        Me.TB_Snombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Snombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Snombre.CustomButton.TabIndex = 1
        Me.TB_Snombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Snombre.CustomButton.UseSelectable = True
        Me.TB_Snombre.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TB_Snombre, BunifuAnimatorNS.DecorationType.None)
        Me.TB_Snombre.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Snombre.Lines = New String() {" "}
        Me.TB_Snombre.Location = New System.Drawing.Point(13, 104)
        Me.TB_Snombre.MaxLength = 32767
        Me.TB_Snombre.Name = "TB_Snombre"
        Me.TB_Snombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Snombre.PromptText = "Segundo Nombre"
        Me.TB_Snombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Snombre.SelectedText = ""
        Me.TB_Snombre.SelectionLength = 0
        Me.TB_Snombre.SelectionStart = 0
        Me.TB_Snombre.ShortcutsEnabled = True
        Me.TB_Snombre.Size = New System.Drawing.Size(415, 29)
        Me.TB_Snombre.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Snombre.TabIndex = 114
        Me.TB_Snombre.Text = " "
        Me.TB_Snombre.UseSelectable = True
        Me.TB_Snombre.WaterMark = "Segundo Nombre"
        Me.TB_Snombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Snombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(13, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 17)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Primer Apellido:"
        '
        'TB_Papellido
        '
        '
        '
        '
        Me.TB_Papellido.CustomButton.Image = Nothing
        Me.TB_Papellido.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TB_Papellido.CustomButton.Name = ""
        Me.TB_Papellido.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Papellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Papellido.CustomButton.TabIndex = 1
        Me.TB_Papellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Papellido.CustomButton.UseSelectable = True
        Me.TB_Papellido.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TB_Papellido, BunifuAnimatorNS.DecorationType.None)
        Me.TB_Papellido.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Papellido.Lines = New String() {" "}
        Me.TB_Papellido.Location = New System.Drawing.Point(13, 156)
        Me.TB_Papellido.MaxLength = 32767
        Me.TB_Papellido.Name = "TB_Papellido"
        Me.TB_Papellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Papellido.PromptText = "Primer Apellido"
        Me.TB_Papellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Papellido.SelectedText = ""
        Me.TB_Papellido.SelectionLength = 0
        Me.TB_Papellido.SelectionStart = 0
        Me.TB_Papellido.ShortcutsEnabled = True
        Me.TB_Papellido.Size = New System.Drawing.Size(415, 29)
        Me.TB_Papellido.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Papellido.TabIndex = 115
        Me.TB_Papellido.Text = " "
        Me.TB_Papellido.UseSelectable = True
        Me.TB_Papellido.WaterMark = "Primer Apellido"
        Me.TB_Papellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Papellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(13, 188)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 17)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "Segundo Apellido"
        '
        'TB_Sapellido
        '
        '
        '
        '
        Me.TB_Sapellido.CustomButton.Image = Nothing
        Me.TB_Sapellido.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TB_Sapellido.CustomButton.Name = ""
        Me.TB_Sapellido.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Sapellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Sapellido.CustomButton.TabIndex = 1
        Me.TB_Sapellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Sapellido.CustomButton.UseSelectable = True
        Me.TB_Sapellido.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TB_Sapellido, BunifuAnimatorNS.DecorationType.None)
        Me.TB_Sapellido.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Sapellido.Lines = New String() {" "}
        Me.TB_Sapellido.Location = New System.Drawing.Point(13, 208)
        Me.TB_Sapellido.MaxLength = 32767
        Me.TB_Sapellido.Name = "TB_Sapellido"
        Me.TB_Sapellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Sapellido.PromptText = "Segundo Apellido"
        Me.TB_Sapellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Sapellido.SelectedText = ""
        Me.TB_Sapellido.SelectionLength = 0
        Me.TB_Sapellido.SelectionStart = 0
        Me.TB_Sapellido.ShortcutsEnabled = True
        Me.TB_Sapellido.Size = New System.Drawing.Size(415, 29)
        Me.TB_Sapellido.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Sapellido.TabIndex = 116
        Me.TB_Sapellido.Text = " "
        Me.TB_Sapellido.UseSelectable = True
        Me.TB_Sapellido.WaterMark = "Segundo Apellido"
        Me.TB_Sapellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Sapellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.Location = New System.Drawing.Point(13, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 17)
        Me.Label20.TabIndex = 128
        Me.Label20.Text = "Telefono:"
        '
        'TB_Telefono
        '
        Me.TB_Telefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TB_Telefono.CustomButton.Image = Nothing
        Me.TB_Telefono.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TB_Telefono.CustomButton.Name = ""
        Me.TB_Telefono.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Telefono.CustomButton.TabIndex = 1
        Me.TB_Telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Telefono.CustomButton.UseSelectable = True
        Me.TB_Telefono.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TB_Telefono, BunifuAnimatorNS.DecorationType.None)
        Me.TB_Telefono.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Telefono.Lines = New String() {" "}
        Me.TB_Telefono.Location = New System.Drawing.Point(13, 260)
        Me.TB_Telefono.MaxLength = 32767
        Me.TB_Telefono.Name = "TB_Telefono"
        Me.TB_Telefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Telefono.PromptText = "Telefono"
        Me.TB_Telefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Telefono.SelectedText = ""
        Me.TB_Telefono.SelectionLength = 0
        Me.TB_Telefono.SelectionStart = 0
        Me.TB_Telefono.ShortcutsEnabled = True
        Me.TB_Telefono.Size = New System.Drawing.Size(415, 29)
        Me.TB_Telefono.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Telefono.TabIndex = 118
        Me.TB_Telefono.Text = " "
        Me.TB_Telefono.UseSelectable = True
        Me.TB_Telefono.WaterMark = "Telefono"
        Me.TB_Telefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Telefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label21.Location = New System.Drawing.Point(13, 292)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 17)
        Me.Label21.TabIndex = 129
        Me.Label21.Text = "Nivel de estudio:"
        '
        'DropdownNivelEstudio
        '
        Me.DropdownNivelEstudio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropdownNivelEstudio, BunifuAnimatorNS.DecorationType.None)
        Me.DropdownNivelEstudio.FormattingEnabled = True
        Me.DropdownNivelEstudio.ItemHeight = 23
        Me.DropdownNivelEstudio.Items.AddRange(New Object() {"BACHILLER", "PREGRADO", "POSTGRADO", "DOCTORADO"})
        Me.DropdownNivelEstudio.Location = New System.Drawing.Point(13, 312)
        Me.DropdownNivelEstudio.Name = "DropdownNivelEstudio"
        Me.DropdownNivelEstudio.PromptText = "Nivel de estudio"
        Me.DropdownNivelEstudio.Size = New System.Drawing.Size(415, 29)
        Me.DropdownNivelEstudio.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropdownNivelEstudio.TabIndex = 120
        Me.DropdownNivelEstudio.UseSelectable = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(13, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Dirección:"
        '
        'DropDownPais
        '
        Me.DropDownPais.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownPais, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownPais.FormattingEnabled = True
        Me.DropDownPais.ItemHeight = 23
        Me.DropDownPais.Location = New System.Drawing.Point(13, 364)
        Me.DropDownPais.Name = "DropDownPais"
        Me.DropDownPais.PromptText = "País"
        Me.DropDownPais.Size = New System.Drawing.Size(415, 29)
        Me.DropDownPais.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownPais.TabIndex = 90
        Me.DropDownPais.UseSelectable = True
        '
        'DropDownEstados
        '
        Me.DropDownEstados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownEstados, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownEstados.Enabled = False
        Me.DropDownEstados.FormattingEnabled = True
        Me.DropDownEstados.ItemHeight = 23
        Me.DropDownEstados.Location = New System.Drawing.Point(13, 399)
        Me.DropDownEstados.Name = "DropDownEstados"
        Me.DropDownEstados.PromptText = "Estado"
        Me.DropDownEstados.Size = New System.Drawing.Size(415, 29)
        Me.DropDownEstados.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownEstados.TabIndex = 89
        Me.DropDownEstados.UseSelectable = True
        '
        'DropDownMunicipios
        '
        Me.DropDownMunicipios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownMunicipios, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownMunicipios.Enabled = False
        Me.DropDownMunicipios.FormattingEnabled = True
        Me.DropDownMunicipios.ItemHeight = 23
        Me.DropDownMunicipios.Location = New System.Drawing.Point(13, 434)
        Me.DropDownMunicipios.Name = "DropDownMunicipios"
        Me.DropDownMunicipios.PromptText = "Municipio"
        Me.DropDownMunicipios.Size = New System.Drawing.Size(415, 29)
        Me.DropDownMunicipios.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownMunicipios.TabIndex = 91
        Me.DropDownMunicipios.UseSelectable = True
        '
        'DropDownParroquias
        '
        Me.DropDownParroquias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownParroquias, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownParroquias.DisplayMember = "id_parroquia"
        Me.DropDownParroquias.Enabled = False
        Me.DropDownParroquias.FormattingEnabled = True
        Me.DropDownParroquias.ItemHeight = 23
        Me.DropDownParroquias.Location = New System.Drawing.Point(13, 469)
        Me.DropDownParroquias.Name = "DropDownParroquias"
        Me.DropDownParroquias.PromptText = "Parroquia"
        Me.DropDownParroquias.Size = New System.Drawing.Size(415, 29)
        Me.DropDownParroquias.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownParroquias.TabIndex = 92
        Me.DropDownParroquias.UseSelectable = True
        Me.DropDownParroquias.ValueMember = "id_parroquia"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(13, 501)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 17)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "Cuenta de Usuario:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TBUsuario.CustomButton.Image = Nothing
        Me.TBUsuario.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TBUsuario.CustomButton.Name = ""
        Me.TBUsuario.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TBUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TBUsuario.CustomButton.TabIndex = 1
        Me.TBUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TBUsuario.CustomButton.UseSelectable = True
        Me.TBUsuario.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TBUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.TBUsuario.Lines = New String() {" "}
        Me.TBUsuario.Location = New System.Drawing.Point(13, 521)
        Me.TBUsuario.MaxLength = 32767
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBUsuario.PromptText = "Usuario"
        Me.TBUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TBUsuario.SelectedText = ""
        Me.TBUsuario.SelectionLength = 0
        Me.TBUsuario.SelectionStart = 0
        Me.TBUsuario.ShortcutsEnabled = True
        Me.TBUsuario.Size = New System.Drawing.Size(415, 29)
        Me.TBUsuario.Style = MetroFramework.MetroColorStyle.Silver
        Me.TBUsuario.TabIndex = 124
        Me.TBUsuario.Text = " "
        Me.TBUsuario.UseSelectable = True
        Me.TBUsuario.WaterMark = "Usuario"
        Me.TBUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TBUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TBContra
        '
        Me.TBContra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TBContra.CustomButton.Image = Nothing
        Me.TBContra.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TBContra.CustomButton.Name = ""
        Me.TBContra.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TBContra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TBContra.CustomButton.TabIndex = 1
        Me.TBContra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TBContra.CustomButton.UseSelectable = True
        Me.TBContra.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TBContra, BunifuAnimatorNS.DecorationType.None)
        Me.TBContra.IconRight = True
        Me.TBContra.Lines = New String() {" "}
        Me.TBContra.Location = New System.Drawing.Point(13, 556)
        Me.TBContra.MaxLength = 32767
        Me.TBContra.Name = "TBContra"
        Me.TBContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TBContra.PromptText = "Contraseña"
        Me.TBContra.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TBContra.SelectedText = ""
        Me.TBContra.SelectionLength = 0
        Me.TBContra.SelectionStart = 0
        Me.TBContra.ShortcutsEnabled = True
        Me.TBContra.Size = New System.Drawing.Size(415, 29)
        Me.TBContra.Style = MetroFramework.MetroColorStyle.Silver
        Me.TBContra.TabIndex = 125
        Me.TBContra.Text = " "
        Me.TBContra.UseSelectable = True
        Me.TBContra.UseStyleColors = True
        Me.TBContra.WaterMark = "Contraseña"
        Me.TBContra.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TBContra.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_correo
        '
        Me.TB_correo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TB_correo.CustomButton.Image = Nothing
        Me.TB_correo.CustomButton.Location = New System.Drawing.Point(387, 1)
        Me.TB_correo.CustomButton.Name = ""
        Me.TB_correo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_correo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_correo.CustomButton.TabIndex = 1
        Me.TB_correo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_correo.CustomButton.UseSelectable = True
        Me.TB_correo.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TB_correo, BunifuAnimatorNS.DecorationType.None)
        Me.TB_correo.Lines = New String() {" "}
        Me.TB_correo.Location = New System.Drawing.Point(13, 591)
        Me.TB_correo.MaxLength = 32767
        Me.TB_correo.Name = "TB_correo"
        Me.TB_correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_correo.PromptText = "Correo Electronico"
        Me.TB_correo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_correo.SelectedText = ""
        Me.TB_correo.SelectionLength = 0
        Me.TB_correo.SelectionStart = 0
        Me.TB_correo.ShortcutsEnabled = True
        Me.TB_correo.Size = New System.Drawing.Size(415, 29)
        Me.TB_correo.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_correo.TabIndex = 126
        Me.TB_correo.Text = " "
        Me.TB_correo.UseSelectable = True
        Me.TB_correo.WaterMark = "Correo Electronico"
        Me.TB_correo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_correo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ButtonActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonActualizar.BorderRadius = 0
        Me.ButtonActualizar.ButtonText = "Enviar Datos"
        Me.ButtonActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTModificarDatos.SetDecoration(Me.ButtonActualizar, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonActualizar.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonActualizar.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActualizar.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonActualizar.Iconimage = Nothing
        Me.ButtonActualizar.Iconimage_right = Nothing
        Me.ButtonActualizar.Iconimage_right_Selected = Nothing
        Me.ButtonActualizar.Iconimage_Selected = Nothing
        Me.ButtonActualizar.IconMarginLeft = 0
        Me.ButtonActualizar.IconMarginRight = 0
        Me.ButtonActualizar.IconRightVisible = True
        Me.ButtonActualizar.IconRightZoom = 0R
        Me.ButtonActualizar.IconVisible = False
        Me.ButtonActualizar.IconZoom = 90.0R
        Me.ButtonActualizar.IsTab = False
        Me.ButtonActualizar.Location = New System.Drawing.Point(17, 629)
        Me.ButtonActualizar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonActualizar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonActualizar.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonActualizar.selected = False
        Me.ButtonActualizar.Size = New System.Drawing.Size(407, 49)
        Me.ButtonActualizar.TabIndex = 93
        Me.ButtonActualizar.Text = "Enviar Datos"
        Me.ButtonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonActualizar.Textcolor = System.Drawing.Color.Black
        Me.ButtonActualizar.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(50, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Primer Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(50, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "Segundo Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(50, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 17)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Primer Apellido:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label22.Location = New System.Drawing.Point(50, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 17)
        Me.Label22.TabIndex = 134
        Me.Label22.Text = "Segundo Apellido"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label23.Location = New System.Drawing.Point(50, 222)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 17)
        Me.Label23.TabIndex = 135
        Me.Label23.Text = "Ci:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label24.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label24.Location = New System.Drawing.Point(50, 247)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 17)
        Me.Label24.TabIndex = 136
        Me.Label24.Text = "Telefono:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label25.Location = New System.Drawing.Point(50, 272)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(108, 17)
        Me.Label25.TabIndex = 137
        Me.Label25.Text = "Nivel de estudio:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Location = New System.Drawing.Point(50, 372)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 17)
        Me.Label26.TabIndex = 131
        Me.Label26.Text = "Dirección:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label27.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label27.Location = New System.Drawing.Point(50, 297)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 17)
        Me.Label27.TabIndex = 138
        Me.Label27.Text = "Especialidad:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label28.Location = New System.Drawing.Point(50, 322)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 17)
        Me.Label28.TabIndex = 139
        Me.Label28.Text = "Cuenta de Usuario:"
        '
        'LabelEspecialidad
        '
        Me.LabelEspecialidad.AutoSize = True
        Me.LabelEspecialidad.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelEspecialidad, BunifuAnimatorNS.DecorationType.None)
        Me.LabelEspecialidad.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelEspecialidad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelEspecialidad.Location = New System.Drawing.Point(193, 297)
        Me.LabelEspecialidad.Name = "LabelEspecialidad"
        Me.LabelEspecialidad.Size = New System.Drawing.Size(87, 17)
        Me.LabelEspecialidad.TabIndex = 147
        Me.LabelEspecialidad.Text = "Especialidad:"
        '
        'LabelCuentaDeUsuario
        '
        Me.LabelCuentaDeUsuario.AutoSize = True
        Me.LabelCuentaDeUsuario.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelCuentaDeUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.LabelCuentaDeUsuario.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelCuentaDeUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelCuentaDeUsuario.Location = New System.Drawing.Point(193, 322)
        Me.LabelCuentaDeUsuario.Name = "LabelCuentaDeUsuario"
        Me.LabelCuentaDeUsuario.Size = New System.Drawing.Size(120, 17)
        Me.LabelCuentaDeUsuario.TabIndex = 148
        Me.LabelCuentaDeUsuario.Text = "Cuenta de Usuario:"
        '
        'LabelPnombre
        '
        Me.LabelPnombre.AutoSize = True
        Me.LabelPnombre.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelPnombre, BunifuAnimatorNS.DecorationType.None)
        Me.LabelPnombre.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelPnombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelPnombre.Location = New System.Drawing.Point(193, 122)
        Me.LabelPnombre.Name = "LabelPnombre"
        Me.LabelPnombre.Size = New System.Drawing.Size(99, 17)
        Me.LabelPnombre.TabIndex = 140
        Me.LabelPnombre.Text = "Primer Nombre:"
        '
        'LabelSnombre
        '
        Me.LabelSnombre.AutoSize = True
        Me.LabelSnombre.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelSnombre, BunifuAnimatorNS.DecorationType.None)
        Me.LabelSnombre.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelSnombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelSnombre.Location = New System.Drawing.Point(193, 147)
        Me.LabelSnombre.Name = "LabelSnombre"
        Me.LabelSnombre.Size = New System.Drawing.Size(115, 17)
        Me.LabelSnombre.TabIndex = 141
        Me.LabelSnombre.Text = "Segundo Nombre:"
        '
        'LabelPapellido
        '
        Me.LabelPapellido.AutoSize = True
        Me.LabelPapellido.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelPapellido, BunifuAnimatorNS.DecorationType.None)
        Me.LabelPapellido.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelPapellido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelPapellido.Location = New System.Drawing.Point(193, 172)
        Me.LabelPapellido.Name = "LabelPapellido"
        Me.LabelPapellido.Size = New System.Drawing.Size(101, 17)
        Me.LabelPapellido.TabIndex = 142
        Me.LabelPapellido.Text = "Primer Apellido:"
        '
        'LabelSapellido
        '
        Me.LabelSapellido.AutoSize = True
        Me.LabelSapellido.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelSapellido, BunifuAnimatorNS.DecorationType.None)
        Me.LabelSapellido.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelSapellido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelSapellido.Location = New System.Drawing.Point(193, 197)
        Me.LabelSapellido.Name = "LabelSapellido"
        Me.LabelSapellido.Size = New System.Drawing.Size(114, 17)
        Me.LabelSapellido.TabIndex = 143
        Me.LabelSapellido.Text = "Segundo Apellido"
        '
        'LabelCi
        '
        Me.LabelCi.AutoSize = True
        Me.LabelCi.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelCi, BunifuAnimatorNS.DecorationType.None)
        Me.LabelCi.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelCi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelCi.Location = New System.Drawing.Point(193, 222)
        Me.LabelCi.Name = "LabelCi"
        Me.LabelCi.Size = New System.Drawing.Size(23, 17)
        Me.LabelCi.TabIndex = 144
        Me.LabelCi.Text = "Ci:"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelTelefono, BunifuAnimatorNS.DecorationType.None)
        Me.LabelTelefono.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelTelefono.Location = New System.Drawing.Point(193, 247)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(62, 17)
        Me.LabelTelefono.TabIndex = 145
        Me.LabelTelefono.Text = "Telefono:"
        '
        'LabelNivelEstudio
        '
        Me.LabelNivelEstudio.AutoSize = True
        Me.LabelNivelEstudio.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelNivelEstudio, BunifuAnimatorNS.DecorationType.None)
        Me.LabelNivelEstudio.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelNivelEstudio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelNivelEstudio.Location = New System.Drawing.Point(193, 272)
        Me.LabelNivelEstudio.Name = "LabelNivelEstudio"
        Me.LabelNivelEstudio.Size = New System.Drawing.Size(108, 17)
        Me.LabelNivelEstudio.TabIndex = 146
        Me.LabelNivelEstudio.Text = "Nivel de estudio:"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelCorreo, BunifuAnimatorNS.DecorationType.None)
        Me.LabelCorreo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelCorreo.Location = New System.Drawing.Point(193, 347)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(120, 17)
        Me.LabelCorreo.TabIndex = 150
        Me.LabelCorreo.Text = "Cuenta de Usuario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(50, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Correo:"
        '
        'DropdownTrabajador
        '
        Me.BTModificarDatos.SetDecoration(Me.DropdownTrabajador, BunifuAnimatorNS.DecorationType.None)
        Me.DropdownTrabajador.FormattingEnabled = True
        Me.DropdownTrabajador.ItemHeight = 23
        Me.DropdownTrabajador.Location = New System.Drawing.Point(53, 84)
        Me.DropdownTrabajador.MaxDropDownItems = 99
        Me.DropdownTrabajador.Name = "DropdownTrabajador"
        Me.DropdownTrabajador.Size = New System.Drawing.Size(307, 29)
        Me.DropdownTrabajador.TabIndex = 151
        Me.DropdownTrabajador.UseSelectable = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.PictureBoxLogo, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBoxLogo.Image = Global.InterfazUsuario.My.Resources.Resources._3_LogoBlancoSinFondo
        Me.PictureBoxLogo.Location = New System.Drawing.Point(603, 152)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(172, 175)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 152
        Me.PictureBoxLogo.TabStop = False
        '
        'FormActualizarTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 490)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelEspecialidad)
        Me.Controls.Add(Me.LabelCuentaDeUsuario)
        Me.Controls.Add(Me.LabelPnombre)
        Me.Controls.Add(Me.LabelSnombre)
        Me.Controls.Add(Me.LabelPapellido)
        Me.Controls.Add(Me.LabelSapellido)
        Me.Controls.Add(Me.LabelCi)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.LabelNivelEstudio)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DropdownTrabajador)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.BTModificarDatos.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormActualizarTrabajadores"
        Me.Text = "FormActualizarDatosCliente"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents BTModificarDatos As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DropDownPais As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownEstados As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownMunicipios As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownParroquias As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ButtonActualizar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TB_pnombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_Snombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_Papellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_Sapellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TBUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TBContra As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_correo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DropdownNivelEstudio As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TB_Telefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents LabelEspecialidad As Label
    Friend WithEvents LabelCuentaDeUsuario As Label
    Friend WithEvents LabelPnombre As Label
    Friend WithEvents LabelSnombre As Label
    Friend WithEvents LabelPapellido As Label
    Friend WithEvents LabelSapellido As Label
    Friend WithEvents LabelCi As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelNivelEstudio As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DropdownTrabajador As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
