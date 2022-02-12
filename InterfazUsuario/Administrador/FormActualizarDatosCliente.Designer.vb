<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormActualizarDatosCliente
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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActualizarDatosCliente))
        Me.TextBoxDescrip = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelRif = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DropDownParroquias = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownMunicipios = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownPais = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownEstados = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownTipo = New MetroFramework.Controls.MetroComboBox()
        Me.TextBoxDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.TextBoxRif = New MetroFramework.Controls.MetroTextBox()
        Me.TextBoxNombre = New MetroFramework.Controls.MetroTextBox()
        Me.DropdownCliente = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonClose = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTModificarDatos = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxDescrip
        '
        Me.TextBoxDescrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDescrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BTModificarDatos.SetDecoration(Me.TextBoxDescrip, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxDescrip.Enabled = False
        Me.TextBoxDescrip.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescrip.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBoxDescrip.Location = New System.Drawing.Point(53, 364)
        Me.TextBoxDescrip.Multiline = True
        Me.TextBoxDescrip.Name = "TextBoxDescrip"
        Me.TextBoxDescrip.Size = New System.Drawing.Size(339, 66)
        Me.TextBoxDescrip.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(49, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 21)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(49, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 21)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Descripción:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(49, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 21)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Tipo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(49, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Nombre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(49, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 21)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Rif:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(156, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 21)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Datos Nuevos"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelTipo, BunifuAnimatorNS.DecorationType.None)
        Me.LabelTipo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelTipo.Location = New System.Drawing.Point(175, 204)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(136, 21)
        Me.LabelTipo.TabIndex = 96
        Me.LabelTipo.Text = "Para actualizar: "
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelNombre, BunifuAnimatorNS.DecorationType.None)
        Me.LabelNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelNombre.Location = New System.Drawing.Point(177, 132)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(134, 19)
        Me.LabelNombre.TabIndex = 95
        Me.LabelNombre.Text = "Para actualizar: "
        '
        'LabelRif
        '
        Me.LabelRif.AutoSize = True
        Me.LabelRif.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.LabelRif, BunifuAnimatorNS.DecorationType.None)
        Me.LabelRif.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelRif.Location = New System.Drawing.Point(175, 167)
        Me.LabelRif.Name = "LabelRif"
        Me.LabelRif.Size = New System.Drawing.Size(136, 21)
        Me.LabelRif.TabIndex = 94
        Me.LabelRif.Text = "Para actualizar: "
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.ButtonActualizar.Location = New System.Drawing.Point(7, 454)
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
        'DropDownParroquias
        '
        Me.DropDownParroquias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownParroquias, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownParroquias.DisplayMember = "id_parroquia"
        Me.DropDownParroquias.Enabled = False
        Me.DropDownParroquias.FormattingEnabled = True
        Me.DropDownParroquias.ItemHeight = 23
        Me.DropDownParroquias.Location = New System.Drawing.Point(25, 405)
        Me.DropDownParroquias.Name = "DropDownParroquias"
        Me.DropDownParroquias.PromptText = "Parroquia"
        Me.DropDownParroquias.Size = New System.Drawing.Size(368, 29)
        Me.DropDownParroquias.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownParroquias.TabIndex = 92
        Me.DropDownParroquias.UseSelectable = True
        Me.DropDownParroquias.ValueMember = "id_parroquia"
        '
        'DropDownMunicipios
        '
        Me.DropDownMunicipios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownMunicipios, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownMunicipios.Enabled = False
        Me.DropDownMunicipios.FormattingEnabled = True
        Me.DropDownMunicipios.ItemHeight = 23
        Me.DropDownMunicipios.Location = New System.Drawing.Point(25, 371)
        Me.DropDownMunicipios.Name = "DropDownMunicipios"
        Me.DropDownMunicipios.PromptText = "Municipio"
        Me.DropDownMunicipios.Size = New System.Drawing.Size(368, 29)
        Me.DropDownMunicipios.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownMunicipios.TabIndex = 91
        Me.DropDownMunicipios.UseSelectable = True
        '
        'DropDownPais
        '
        Me.DropDownPais.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownPais, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownPais.FormattingEnabled = True
        Me.DropDownPais.ItemHeight = 23
        Me.DropDownPais.Location = New System.Drawing.Point(25, 303)
        Me.DropDownPais.Name = "DropDownPais"
        Me.DropDownPais.PromptText = "País"
        Me.DropDownPais.Size = New System.Drawing.Size(368, 29)
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
        Me.DropDownEstados.Location = New System.Drawing.Point(25, 337)
        Me.DropDownEstados.Name = "DropDownEstados"
        Me.DropDownEstados.PromptText = "Estado"
        Me.DropDownEstados.Size = New System.Drawing.Size(368, 29)
        Me.DropDownEstados.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownEstados.TabIndex = 89
        Me.DropDownEstados.UseSelectable = True
        '
        'DropDownTipo
        '
        Me.DropDownTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.DropDownTipo, BunifuAnimatorNS.DecorationType.None)
        Me.DropDownTipo.FormattingEnabled = True
        Me.DropDownTipo.ItemHeight = 23
        Me.DropDownTipo.Items.AddRange(New Object() {"C.A", "S.A", "PUBLICA / ESTADAL", "PUBLICA / ORGANIZACION"})
        Me.DropDownTipo.Location = New System.Drawing.Point(25, 247)
        Me.DropDownTipo.Name = "DropDownTipo"
        Me.DropDownTipo.PromptText = "Tipo"
        Me.DropDownTipo.Size = New System.Drawing.Size(368, 29)
        Me.DropDownTipo.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownTipo.TabIndex = 88
        Me.DropDownTipo.UseSelectable = True
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TextBoxDescripcion.CustomButton.Image = Nothing
        Me.TextBoxDescripcion.CustomButton.Location = New System.Drawing.Point(314, 2)
        Me.TextBoxDescripcion.CustomButton.Name = ""
        Me.TextBoxDescripcion.CustomButton.Size = New System.Drawing.Size(51, 51)
        Me.TextBoxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBoxDescripcion.CustomButton.TabIndex = 1
        Me.TextBoxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBoxDescripcion.CustomButton.UseSelectable = True
        Me.TextBoxDescripcion.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TextBoxDescripcion, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxDescripcion.Lines = New String(-1) {}
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(25, 164)
        Me.TextBoxDescripcion.MaxLength = 32767
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxDescripcion.PromptText = "Descripcion"
        Me.TextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxDescripcion.SelectedText = ""
        Me.TextBoxDescripcion.SelectionLength = 0
        Me.TextBoxDescripcion.SelectionStart = 0
        Me.TextBoxDescripcion.ShortcutsEnabled = True
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(368, 56)
        Me.TextBoxDescripcion.Style = MetroFramework.MetroColorStyle.Silver
        Me.TextBoxDescripcion.TabIndex = 87
        Me.TextBoxDescripcion.UseSelectable = True
        Me.TextBoxDescripcion.WaterMark = "Descripcion"
        Me.TextBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBoxDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextBoxRif
        '
        Me.TextBoxRif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TextBoxRif.CustomButton.Image = Nothing
        Me.TextBoxRif.CustomButton.Location = New System.Drawing.Point(340, 2)
        Me.TextBoxRif.CustomButton.Name = ""
        Me.TextBoxRif.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TextBoxRif.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBoxRif.CustomButton.TabIndex = 1
        Me.TextBoxRif.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBoxRif.CustomButton.UseSelectable = True
        Me.TextBoxRif.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TextBoxRif, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxRif.Lines = New String(-1) {}
        Me.TextBoxRif.Location = New System.Drawing.Point(25, 107)
        Me.TextBoxRif.MaxLength = 32767
        Me.TextBoxRif.Name = "TextBoxRif"
        Me.TextBoxRif.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxRif.PromptText = "Rif"
        Me.TextBoxRif.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxRif.SelectedText = ""
        Me.TextBoxRif.SelectionLength = 0
        Me.TextBoxRif.SelectionStart = 0
        Me.TextBoxRif.ShortcutsEnabled = True
        Me.TextBoxRif.Size = New System.Drawing.Size(368, 30)
        Me.TextBoxRif.Style = MetroFramework.MetroColorStyle.Silver
        Me.TextBoxRif.TabIndex = 86
        Me.TextBoxRif.UseSelectable = True
        Me.TextBoxRif.WaterMark = "Rif"
        Me.TextBoxRif.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBoxRif.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TextBoxNombre.CustomButton.Image = Nothing
        Me.TextBoxNombre.CustomButton.Location = New System.Drawing.Point(340, 2)
        Me.TextBoxNombre.CustomButton.Name = ""
        Me.TextBoxNombre.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBoxNombre.CustomButton.TabIndex = 1
        Me.TextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBoxNombre.CustomButton.UseSelectable = True
        Me.TextBoxNombre.CustomButton.Visible = False
        Me.BTModificarDatos.SetDecoration(Me.TextBoxNombre, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxNombre.Lines = New String(-1) {}
        Me.TextBoxNombre.Location = New System.Drawing.Point(25, 50)
        Me.TextBoxNombre.MaxLength = 32767
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxNombre.PromptText = "Nombre"
        Me.TextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxNombre.SelectedText = ""
        Me.TextBoxNombre.SelectionLength = 0
        Me.TextBoxNombre.SelectionStart = 0
        Me.TextBoxNombre.ShortcutsEnabled = True
        Me.TextBoxNombre.Size = New System.Drawing.Size(368, 30)
        Me.TextBoxNombre.Style = MetroFramework.MetroColorStyle.Silver
        Me.TextBoxNombre.TabIndex = 85
        Me.TextBoxNombre.UseSelectable = True
        Me.TextBoxNombre.WaterMark = "Nombre"
        Me.TextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBoxNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DropdownCliente
        '
        Me.BTModificarDatos.SetDecoration(Me.DropdownCliente, BunifuAnimatorNS.DecorationType.None)
        Me.DropdownCliente.DisplayFocus = True
        Me.DropdownCliente.DisplayMember = "ID"
        Me.DropdownCliente.FormattingEnabled = True
        Me.DropdownCliente.ItemHeight = 23
        Me.DropdownCliente.Location = New System.Drawing.Point(53, 90)
        Me.DropdownCliente.Name = "DropdownCliente"
        Me.DropdownCliente.PromptText = "Cliente a modificar"
        Me.DropdownCliente.Size = New System.Drawing.Size(270, 29)
        Me.DropdownCliente.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropdownCliente.TabIndex = 84
        Me.DropdownCliente.UseSelectable = True
        Me.DropdownCliente.ValueMember = "ID"
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
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Para actualizar: "
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
        Me.ButtonClose.Location = New System.Drawing.Point(388, 13)
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
        Me.Label1.Size = New System.Drawing.Size(366, 36)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Modificacion de Cliente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBoxNombre)
        Me.Panel1.Controls.Add(Me.TextBoxRif)
        Me.Panel1.Controls.Add(Me.TextBoxDescripcion)
        Me.Panel1.Controls.Add(Me.DropDownTipo)
        Me.Panel1.Controls.Add(Me.DropDownEstados)
        Me.Panel1.Controls.Add(Me.DropDownPais)
        Me.Panel1.Controls.Add(Me.DropDownMunicipios)
        Me.Panel1.Controls.Add(Me.DropDownParroquias)
        Me.Panel1.Controls.Add(Me.ButtonActualizar)
        Me.BTModificarDatos.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(433, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 509)
        Me.Panel1.TabIndex = 105
        Me.Panel1.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(25, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Dirección:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(25, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(25, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(25, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Rif:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BTModificarDatos.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(25, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nombre:"
        '
        'BTModificarDatos
        '
        Me.BTModificarDatos.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.BTModificarDatos.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 1.0!
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
        Me.BTModificarDatos.DefaultAnimation = Animation2
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(6, 454)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(423, 49)
        Me.BunifuFlatButton1.TabIndex = 106
        Me.BunifuFlatButton1.Text = "Actualizar Datos"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BTModificarDatos.SetDecoration(Me.TextBoxDireccion, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxDireccion.Enabled = False
        Me.TextBoxDireccion.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDireccion.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBoxDireccion.Location = New System.Drawing.Point(53, 266)
        Me.TextBoxDireccion.Multiline = True
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(339, 66)
        Me.TextBoxDireccion.TabIndex = 107
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTModificarDatos.SetDecoration(Me.PictureBoxLogo, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBoxLogo.Image = Global.InterfazUsuario.My.Resources.Resources._3_LogoBlancoSinFondo
        Me.PictureBoxLogo.Location = New System.Drawing.Point(529, 167)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(211, 175)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 108
        Me.PictureBoxLogo.TabStop = False
        '
        'FormActualizarDatosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 509)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxDescrip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelTipo)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelRif)
        Me.Controls.Add(Me.DropdownCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.BTModificarDatos.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormActualizarDatosCliente"
        Me.Text = "FormActualizarDatosCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxDescrip As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelTipo As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelRif As Label
    Friend WithEvents ButtonActualizar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DropDownParroquias As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownMunicipios As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownPais As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownEstados As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownTipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TextBoxDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TextBoxRif As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TextBoxNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DropdownCliente As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTModificarDatos As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label13 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
