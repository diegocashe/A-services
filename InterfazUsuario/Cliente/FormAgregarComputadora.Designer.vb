<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarComputadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_NombreComputadora = New MetroFramework.Controls.MetroTextBox()
        Me.TB_direccionxml = New MetroFramework.Controls.MetroTextBox()
        Me.TB_MAC = New MetroFramework.Controls.MetroTextBox()
        Me.TBipv41 = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_IPV44 = New MetroFramework.Controls.MetroTextBox()
        Me.TB_IPV43 = New MetroFramework.Controls.MetroTextBox()
        Me.TB_IPV42 = New MetroFramework.Controls.MetroTextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.DropdownRedes = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.PaleGreen
        Me.BunifuFlatButton6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton6.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Aceptar"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = Nothing
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = False
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = False
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = True
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(53, 495)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(642, 39)
        Me.BunifuFlatButton6.TabIndex = 132
        Me.BunifuFlatButton6.Text = "Aceptar"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(131, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 21)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Nombre de tu computadora:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(129, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 36)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Tu Computadora"
        '
        'TB_NombreComputadora
        '
        Me.TB_NombreComputadora.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.TB_NombreComputadora.CustomButton.Image = Nothing
        Me.TB_NombreComputadora.CustomButton.Location = New System.Drawing.Point(456, 1)
        Me.TB_NombreComputadora.CustomButton.Name = ""
        Me.TB_NombreComputadora.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_NombreComputadora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_NombreComputadora.CustomButton.TabIndex = 1
        Me.TB_NombreComputadora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_NombreComputadora.CustomButton.UseSelectable = True
        Me.TB_NombreComputadora.CustomButton.Visible = False
        Me.TB_NombreComputadora.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_NombreComputadora.Lines = New String() {" "}
        Me.TB_NombreComputadora.Location = New System.Drawing.Point(135, 159)
        Me.TB_NombreComputadora.MaxLength = 32767
        Me.TB_NombreComputadora.Name = "TB_NombreComputadora"
        Me.TB_NombreComputadora.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_NombreComputadora.PromptText = "Nombre"
        Me.TB_NombreComputadora.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_NombreComputadora.SelectedText = ""
        Me.TB_NombreComputadora.SelectionLength = 0
        Me.TB_NombreComputadora.SelectionStart = 0
        Me.TB_NombreComputadora.ShortcutsEnabled = True
        Me.TB_NombreComputadora.Size = New System.Drawing.Size(484, 29)
        Me.TB_NombreComputadora.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_NombreComputadora.TabIndex = 115
        Me.TB_NombreComputadora.Text = " "
        Me.TB_NombreComputadora.UseSelectable = True
        Me.TB_NombreComputadora.WaterMark = "Nombre"
        Me.TB_NombreComputadora.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_NombreComputadora.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_direccionxml
        '
        Me.TB_direccionxml.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.TB_direccionxml.CustomButton.Image = Nothing
        Me.TB_direccionxml.CustomButton.Location = New System.Drawing.Point(407, 1)
        Me.TB_direccionxml.CustomButton.Name = ""
        Me.TB_direccionxml.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_direccionxml.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_direccionxml.CustomButton.TabIndex = 1
        Me.TB_direccionxml.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_direccionxml.CustomButton.UseSelectable = True
        Me.TB_direccionxml.CustomButton.Visible = False
        Me.TB_direccionxml.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_direccionxml.Lines = New String() {" "}
        Me.TB_direccionxml.Location = New System.Drawing.Point(135, 269)
        Me.TB_direccionxml.MaxLength = 32767
        Me.TB_direccionxml.Name = "TB_direccionxml"
        Me.TB_direccionxml.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_direccionxml.PromptText = "c:\\"
        Me.TB_direccionxml.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_direccionxml.SelectedText = ""
        Me.TB_direccionxml.SelectionLength = 0
        Me.TB_direccionxml.SelectionStart = 0
        Me.TB_direccionxml.ShortcutsEnabled = True
        Me.TB_direccionxml.Size = New System.Drawing.Size(435, 29)
        Me.TB_direccionxml.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_direccionxml.TabIndex = 119
        Me.TB_direccionxml.Text = " "
        Me.TB_direccionxml.UseSelectable = True
        Me.TB_direccionxml.WaterMark = "c:\\"
        Me.TB_direccionxml.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_direccionxml.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_MAC
        '
        Me.TB_MAC.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.TB_MAC.CustomButton.Image = Nothing
        Me.TB_MAC.CustomButton.Location = New System.Drawing.Point(456, 1)
        Me.TB_MAC.CustomButton.Name = ""
        Me.TB_MAC.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_MAC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_MAC.CustomButton.TabIndex = 1
        Me.TB_MAC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_MAC.CustomButton.UseSelectable = True
        Me.TB_MAC.CustomButton.Visible = False
        Me.TB_MAC.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_MAC.Lines = New String() {" "}
        Me.TB_MAC.Location = New System.Drawing.Point(135, 215)
        Me.TB_MAC.MaxLength = 32767
        Me.TB_MAC.Name = "TB_MAC"
        Me.TB_MAC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_MAC.PromptText = "MAC"
        Me.TB_MAC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_MAC.SelectedText = ""
        Me.TB_MAC.SelectionLength = 0
        Me.TB_MAC.SelectionStart = 0
        Me.TB_MAC.ShortcutsEnabled = True
        Me.TB_MAC.Size = New System.Drawing.Size(484, 29)
        Me.TB_MAC.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_MAC.TabIndex = 116
        Me.TB_MAC.Text = " "
        Me.TB_MAC.UseSelectable = True
        Me.TB_MAC.WaterMark = "MAC"
        Me.TB_MAC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_MAC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TBipv41
        '
        Me.TBipv41.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.TBipv41.CustomButton.Image = Nothing
        Me.TBipv41.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.TBipv41.CustomButton.Name = ""
        Me.TBipv41.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TBipv41.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TBipv41.CustomButton.TabIndex = 1
        Me.TBipv41.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TBipv41.CustomButton.UseSelectable = True
        Me.TBipv41.CustomButton.Visible = False
        Me.TBipv41.Enabled = False
        Me.TBipv41.Lines = New String() {" "}
        Me.TBipv41.Location = New System.Drawing.Point(135, 381)
        Me.TBipv41.MaxLength = 32767
        Me.TBipv41.Name = "TBipv41"
        Me.TBipv41.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBipv41.PromptText = "0"
        Me.TBipv41.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TBipv41.SelectedText = ""
        Me.TBipv41.SelectionLength = 0
        Me.TBipv41.SelectionStart = 0
        Me.TBipv41.ShortcutsEnabled = True
        Me.TBipv41.Size = New System.Drawing.Size(102, 29)
        Me.TBipv41.Style = MetroFramework.MetroColorStyle.Silver
        Me.TBipv41.TabIndex = 129
        Me.TBipv41.Text = " "
        Me.TBipv41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TBipv41.UseSelectable = True
        Me.TBipv41.WaterMark = "0"
        Me.TBipv41.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TBipv41.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(131, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(303, 21)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Carpeta de informacion de maquina:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(131, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 21)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Direccion MAC de tu computadora:"
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 26
        Me.IconButton1.Location = New System.Drawing.Point(576, 266)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(43, 32)
        Me.IconButton1.TabIndex = 140
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(131, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Ip Asignado:"
        '
        'TB_IPV44
        '
        Me.TB_IPV44.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.TB_IPV44.CustomButton.Image = Nothing
        Me.TB_IPV44.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.TB_IPV44.CustomButton.Name = ""
        Me.TB_IPV44.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_IPV44.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_IPV44.CustomButton.TabIndex = 1
        Me.TB_IPV44.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_IPV44.CustomButton.UseSelectable = True
        Me.TB_IPV44.CustomButton.Visible = False
        Me.TB_IPV44.Enabled = False
        Me.TB_IPV44.Lines = New String() {" "}
        Me.TB_IPV44.Location = New System.Drawing.Point(517, 381)
        Me.TB_IPV44.MaxLength = 32767
        Me.TB_IPV44.Name = "TB_IPV44"
        Me.TB_IPV44.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_IPV44.PromptText = "0"
        Me.TB_IPV44.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_IPV44.SelectedText = ""
        Me.TB_IPV44.SelectionLength = 0
        Me.TB_IPV44.SelectionStart = 0
        Me.TB_IPV44.ShortcutsEnabled = True
        Me.TB_IPV44.Size = New System.Drawing.Size(102, 29)
        Me.TB_IPV44.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_IPV44.TabIndex = 142
        Me.TB_IPV44.Text = " "
        Me.TB_IPV44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_IPV44.UseSelectable = True
        Me.TB_IPV44.UseStyleColors = True
        Me.TB_IPV44.WaterMark = "0"
        Me.TB_IPV44.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_IPV44.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_IPV43
        '
        Me.TB_IPV43.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.TB_IPV43.CustomButton.Image = Nothing
        Me.TB_IPV43.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.TB_IPV43.CustomButton.Name = ""
        Me.TB_IPV43.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_IPV43.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_IPV43.CustomButton.TabIndex = 1
        Me.TB_IPV43.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_IPV43.CustomButton.UseSelectable = True
        Me.TB_IPV43.CustomButton.Visible = False
        Me.TB_IPV43.Enabled = False
        Me.TB_IPV43.Lines = New String() {" "}
        Me.TB_IPV43.Location = New System.Drawing.Point(393, 381)
        Me.TB_IPV43.MaxLength = 32767
        Me.TB_IPV43.Name = "TB_IPV43"
        Me.TB_IPV43.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_IPV43.PromptText = "0"
        Me.TB_IPV43.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_IPV43.SelectedText = ""
        Me.TB_IPV43.SelectionLength = 0
        Me.TB_IPV43.SelectionStart = 0
        Me.TB_IPV43.ShortcutsEnabled = True
        Me.TB_IPV43.Size = New System.Drawing.Size(102, 29)
        Me.TB_IPV43.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_IPV43.TabIndex = 143
        Me.TB_IPV43.Text = " "
        Me.TB_IPV43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_IPV43.UseSelectable = True
        Me.TB_IPV43.WaterMark = "0"
        Me.TB_IPV43.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_IPV43.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_IPV42
        '
        Me.TB_IPV42.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.TB_IPV42.CustomButton.Image = Nothing
        Me.TB_IPV42.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.TB_IPV42.CustomButton.Name = ""
        Me.TB_IPV42.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_IPV42.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_IPV42.CustomButton.TabIndex = 1
        Me.TB_IPV42.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_IPV42.CustomButton.UseSelectable = True
        Me.TB_IPV42.CustomButton.Visible = False
        Me.TB_IPV42.Enabled = False
        Me.TB_IPV42.Lines = New String() {" "}
        Me.TB_IPV42.Location = New System.Drawing.Point(267, 381)
        Me.TB_IPV42.MaxLength = 32767
        Me.TB_IPV42.Name = "TB_IPV42"
        Me.TB_IPV42.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_IPV42.PromptText = "0"
        Me.TB_IPV42.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_IPV42.SelectedText = ""
        Me.TB_IPV42.SelectionLength = 0
        Me.TB_IPV42.SelectionStart = 0
        Me.TB_IPV42.ShortcutsEnabled = True
        Me.TB_IPV42.Size = New System.Drawing.Size(102, 29)
        Me.TB_IPV42.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_IPV42.TabIndex = 144
        Me.TB_IPV42.Text = " "
        Me.TB_IPV42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_IPV42.UseSelectable = True
        Me.TB_IPV42.WaterMark = "0"
        Me.TB_IPV42.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_IPV42.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'DropdownRedes
        '
        Me.DropdownRedes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DropdownRedes.FormattingEnabled = True
        Me.DropdownRedes.ItemHeight = 23
        Me.DropdownRedes.Location = New System.Drawing.Point(135, 325)
        Me.DropdownRedes.Name = "DropdownRedes"
        Me.DropdownRedes.Size = New System.Drawing.Size(484, 29)
        Me.DropdownRedes.TabIndex = 145
        Me.DropdownRedes.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(131, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Tu Red:"
        '
        'FormAgregarComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(748, 545)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DropdownRedes)
        Me.Controls.Add(Me.TB_IPV42)
        Me.Controls.Add(Me.TB_IPV43)
        Me.Controls.Add(Me.TB_IPV44)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuFlatButton6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBipv41)
        Me.Controls.Add(Me.TB_MAC)
        Me.Controls.Add(Me.TB_direccionxml)
        Me.Controls.Add(Me.TB_NombreComputadora)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAgregarComputadora"
        Me.Text = "FormAgregarComputadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_NombreComputadora As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_direccionxml As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_MAC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TBipv41 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_IPV44 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_IPV43 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_IPV42 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents DropdownRedes As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label3 As Label
End Class
