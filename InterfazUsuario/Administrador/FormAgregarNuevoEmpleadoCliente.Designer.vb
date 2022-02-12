<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgregarNuevoEmpleadoCliente
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DropdownEmpresaClienteDepartamento = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownEmpresa = New MetroFramework.Controls.MetroComboBox()
        Me.TBContra = New MetroFramework.Controls.MetroTextBox()
        Me.TBUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTFechaContrato = New MetroFramework.Controls.MetroDateTime()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTFechanacimiento = New MetroFramework.Controls.MetroDateTime()
        Me.DropdownNivelEstudio = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownParroquias = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownEstados = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownMunicipios = New MetroFramework.Controls.MetroComboBox()
        Me.TB_Telefono = New MetroFramework.Controls.MetroTextBox()
        Me.TB_Snombre = New MetroFramework.Controls.MetroTextBox()
        Me.TB_Papellido = New MetroFramework.Controls.MetroTextBox()
        Me.TB_Sapellido = New MetroFramework.Controls.MetroTextBox()
        Me.TB_cedula = New MetroFramework.Controls.MetroTextBox()
        Me.TB_pnombre = New MetroFramework.Controls.MetroTextBox()
        Me.DropDownPais = New MetroFramework.Controls.MetroComboBox()
        Me.DropdonwGenero = New MetroFramework.Controls.MetroComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_correo = New MetroFramework.Controls.MetroTextBox()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(408, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 21)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Cuenta de Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(35, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 21)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Dependencia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(35, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 21)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Datos Personales:"
        '
        'DropdownEmpresaClienteDepartamento
        '
        Me.DropdownEmpresaClienteDepartamento.FormattingEnabled = True
        Me.DropdownEmpresaClienteDepartamento.ItemHeight = 23
        Me.DropdownEmpresaClienteDepartamento.Location = New System.Drawing.Point(39, 484)
        Me.DropdownEmpresaClienteDepartamento.Name = "DropdownEmpresaClienteDepartamento"
        Me.DropdownEmpresaClienteDepartamento.PromptText = "Departamento"
        Me.DropdownEmpresaClienteDepartamento.Size = New System.Drawing.Size(177, 29)
        Me.DropdownEmpresaClienteDepartamento.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropdownEmpresaClienteDepartamento.TabIndex = 110
        Me.DropdownEmpresaClienteDepartamento.UseSelectable = True
        '
        'DropDownEmpresa
        '
        Me.DropDownEmpresa.DisplayMember = "ID"
        Me.DropDownEmpresa.FormattingEnabled = True
        Me.DropDownEmpresa.ItemHeight = 23
        Me.DropDownEmpresa.Location = New System.Drawing.Point(39, 424)
        Me.DropDownEmpresa.Name = "DropDownEmpresa"
        Me.DropDownEmpresa.PromptText = "Empresa"
        Me.DropDownEmpresa.Size = New System.Drawing.Size(177, 29)
        Me.DropDownEmpresa.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownEmpresa.TabIndex = 14
        Me.DropDownEmpresa.UseSelectable = True
        Me.DropDownEmpresa.ValueMember = "ID"
        '
        'TBContra
        '
        Me.TBContra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TBContra.CustomButton.Image = Nothing
        Me.TBContra.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.TBContra.CustomButton.Name = ""
        Me.TBContra.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TBContra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TBContra.CustomButton.TabIndex = 1
        Me.TBContra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TBContra.CustomButton.UseSelectable = True
        Me.TBContra.CustomButton.Visible = False
        Me.TBContra.IconRight = True
        Me.TBContra.Lines = New String() {" "}
        Me.TBContra.Location = New System.Drawing.Point(412, 456)
        Me.TBContra.MaxLength = 32767
        Me.TBContra.Name = "TBContra"
        Me.TBContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TBContra.PromptText = "Contraseña"
        Me.TBContra.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TBContra.SelectedText = ""
        Me.TBContra.SelectionLength = 0
        Me.TBContra.SelectionStart = 0
        Me.TBContra.ShortcutsEnabled = True
        Me.TBContra.Size = New System.Drawing.Size(187, 29)
        Me.TBContra.Style = MetroFramework.MetroColorStyle.Silver
        Me.TBContra.TabIndex = 17
        Me.TBContra.Text = " "
        Me.TBContra.UseSelectable = True
        Me.TBContra.UseStyleColors = True
        Me.TBContra.WaterMark = "Contraseña"
        Me.TBContra.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TBContra.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TBUsuario
        '
        Me.TBUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TBUsuario.CustomButton.Image = Nothing
        Me.TBUsuario.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.TBUsuario.CustomButton.Name = ""
        Me.TBUsuario.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TBUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TBUsuario.CustomButton.TabIndex = 1
        Me.TBUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TBUsuario.CustomButton.UseSelectable = True
        Me.TBUsuario.CustomButton.Visible = False
        Me.TBUsuario.Lines = New String() {" "}
        Me.TBUsuario.Location = New System.Drawing.Point(412, 424)
        Me.TBUsuario.MaxLength = 32767
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBUsuario.PromptText = "Usuario"
        Me.TBUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TBUsuario.SelectedText = ""
        Me.TBUsuario.SelectionLength = 0
        Me.TBUsuario.SelectionStart = 0
        Me.TBUsuario.ShortcutsEnabled = True
        Me.TBUsuario.Size = New System.Drawing.Size(187, 29)
        Me.TBUsuario.Style = MetroFramework.MetroColorStyle.Silver
        Me.TBUsuario.TabIndex = 16
        Me.TBUsuario.Text = " "
        Me.TBUsuario.UseSelectable = True
        Me.TBUsuario.WaterMark = "Usuario"
        Me.TBUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TBUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(408, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 21)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Fecha de Contrato"
        '
        'DTFechaContrato
        '
        Me.DTFechaContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTFechaContrato.CustomFormat = "yyyy-MM-dd"
        Me.DTFechaContrato.Location = New System.Drawing.Point(412, 359)
        Me.DTFechaContrato.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DTFechaContrato.Name = "DTFechaContrato"
        Me.DTFechaContrato.Size = New System.Drawing.Size(367, 29)
        Me.DTFechaContrato.Style = MetroFramework.MetroColorStyle.Silver
        Me.DTFechaContrato.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(35, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 21)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Fecha de nacimiento:"
        '
        'DTFechanacimiento
        '
        Me.DTFechanacimiento.CustomFormat = "yyyy-MM-dd"
        Me.DTFechanacimiento.Location = New System.Drawing.Point(39, 359)
        Me.DTFechanacimiento.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DTFechanacimiento.Name = "DTFechanacimiento"
        Me.DTFechanacimiento.Size = New System.Drawing.Size(367, 29)
        Me.DTFechanacimiento.Style = MetroFramework.MetroColorStyle.Silver
        Me.DTFechanacimiento.TabIndex = 12
        '
        'DropdownNivelEstudio
        '
        Me.DropdownNivelEstudio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropdownNivelEstudio.FormattingEnabled = True
        Me.DropdownNivelEstudio.ItemHeight = 23
        Me.DropdownNivelEstudio.Items.AddRange(New Object() {"BACHILLER", "PREGRADO", "POSTGRADO", "DOCTORADO"})
        Me.DropdownNivelEstudio.Location = New System.Drawing.Point(412, 251)
        Me.DropdownNivelEstudio.Name = "DropdownNivelEstudio"
        Me.DropdownNivelEstudio.PromptText = "Nivel de estudio"
        Me.DropdownNivelEstudio.Size = New System.Drawing.Size(367, 29)
        Me.DropdownNivelEstudio.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropdownNivelEstudio.TabIndex = 8
        Me.DropdownNivelEstudio.UseSelectable = True
        '
        'DropDownParroquias
        '
        Me.DropDownParroquias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropDownParroquias.Enabled = False
        Me.DropDownParroquias.FormattingEnabled = True
        Me.DropDownParroquias.ItemHeight = 23
        Me.DropDownParroquias.Location = New System.Drawing.Point(599, 286)
        Me.DropDownParroquias.Name = "DropDownParroquias"
        Me.DropDownParroquias.PromptText = "Parroquia"
        Me.DropDownParroquias.Size = New System.Drawing.Size(181, 29)
        Me.DropDownParroquias.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownParroquias.TabIndex = 101
        Me.DropDownParroquias.UseSelectable = True
        '
        'DropDownEstados
        '
        Me.DropDownEstados.DisplayMember = "id_estado"
        Me.DropDownEstados.Enabled = False
        Me.DropDownEstados.FormattingEnabled = True
        Me.DropDownEstados.ItemHeight = 23
        Me.DropDownEstados.Location = New System.Drawing.Point(225, 286)
        Me.DropDownEstados.Name = "DropDownEstados"
        Me.DropDownEstados.PromptText = "Estado"
        Me.DropDownEstados.Size = New System.Drawing.Size(181, 29)
        Me.DropDownEstados.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownEstados.TabIndex = 10
        Me.DropDownEstados.UseSelectable = True
        Me.DropDownEstados.ValueMember = "id_estado"
        '
        'DropDownMunicipios
        '
        Me.DropDownMunicipios.Enabled = False
        Me.DropDownMunicipios.FormattingEnabled = True
        Me.DropDownMunicipios.ItemHeight = 23
        Me.DropDownMunicipios.Location = New System.Drawing.Point(412, 286)
        Me.DropDownMunicipios.Name = "DropDownMunicipios"
        Me.DropDownMunicipios.PromptText = "Municipio"
        Me.DropDownMunicipios.Size = New System.Drawing.Size(181, 29)
        Me.DropDownMunicipios.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownMunicipios.TabIndex = 11
        Me.DropDownMunicipios.UseSelectable = True
        '
        'TB_Telefono
        '
        Me.TB_Telefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TB_Telefono.CustomButton.Image = Nothing
        Me.TB_Telefono.CustomButton.Location = New System.Drawing.Point(339, 1)
        Me.TB_Telefono.CustomButton.Name = ""
        Me.TB_Telefono.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Telefono.CustomButton.TabIndex = 1
        Me.TB_Telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Telefono.CustomButton.UseSelectable = True
        Me.TB_Telefono.CustomButton.Visible = False
        Me.TB_Telefono.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Telefono.Lines = New String() {" "}
        Me.TB_Telefono.Location = New System.Drawing.Point(412, 181)
        Me.TB_Telefono.MaxLength = 32767
        Me.TB_Telefono.Name = "TB_Telefono"
        Me.TB_Telefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Telefono.PromptText = "Telefono"
        Me.TB_Telefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Telefono.SelectedText = ""
        Me.TB_Telefono.SelectionLength = 0
        Me.TB_Telefono.SelectionStart = 0
        Me.TB_Telefono.ShortcutsEnabled = True
        Me.TB_Telefono.Size = New System.Drawing.Size(367, 29)
        Me.TB_Telefono.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Telefono.TabIndex = 6
        Me.TB_Telefono.Text = " "
        Me.TB_Telefono.UseSelectable = True
        Me.TB_Telefono.WaterMark = "Telefono"
        Me.TB_Telefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Telefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_Snombre
        '
        '
        '
        '
        Me.TB_Snombre.CustomButton.Image = Nothing
        Me.TB_Snombre.CustomButton.Location = New System.Drawing.Point(339, 1)
        Me.TB_Snombre.CustomButton.Name = ""
        Me.TB_Snombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Snombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Snombre.CustomButton.TabIndex = 1
        Me.TB_Snombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Snombre.CustomButton.UseSelectable = True
        Me.TB_Snombre.CustomButton.Visible = False
        Me.TB_Snombre.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Snombre.Lines = New String() {" "}
        Me.TB_Snombre.Location = New System.Drawing.Point(39, 181)
        Me.TB_Snombre.MaxLength = 32767
        Me.TB_Snombre.Name = "TB_Snombre"
        Me.TB_Snombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Snombre.PromptText = "Segundo Nombre"
        Me.TB_Snombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Snombre.SelectedText = ""
        Me.TB_Snombre.SelectionLength = 0
        Me.TB_Snombre.SelectionStart = 0
        Me.TB_Snombre.ShortcutsEnabled = True
        Me.TB_Snombre.Size = New System.Drawing.Size(367, 29)
        Me.TB_Snombre.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Snombre.TabIndex = 2
        Me.TB_Snombre.Text = " "
        Me.TB_Snombre.UseSelectable = True
        Me.TB_Snombre.WaterMark = "Segundo Nombre"
        Me.TB_Snombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Snombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_Papellido
        '
        '
        '
        '
        Me.TB_Papellido.CustomButton.Image = Nothing
        Me.TB_Papellido.CustomButton.Location = New System.Drawing.Point(339, 1)
        Me.TB_Papellido.CustomButton.Name = ""
        Me.TB_Papellido.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Papellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Papellido.CustomButton.TabIndex = 1
        Me.TB_Papellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Papellido.CustomButton.UseSelectable = True
        Me.TB_Papellido.CustomButton.Visible = False
        Me.TB_Papellido.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Papellido.Lines = New String() {" "}
        Me.TB_Papellido.Location = New System.Drawing.Point(39, 216)
        Me.TB_Papellido.MaxLength = 32767
        Me.TB_Papellido.Name = "TB_Papellido"
        Me.TB_Papellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Papellido.PromptText = "Primer Apellido"
        Me.TB_Papellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Papellido.SelectedText = ""
        Me.TB_Papellido.SelectionLength = 0
        Me.TB_Papellido.SelectionStart = 0
        Me.TB_Papellido.ShortcutsEnabled = True
        Me.TB_Papellido.Size = New System.Drawing.Size(367, 29)
        Me.TB_Papellido.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Papellido.TabIndex = 3
        Me.TB_Papellido.Text = " "
        Me.TB_Papellido.UseSelectable = True
        Me.TB_Papellido.WaterMark = "Primer Apellido"
        Me.TB_Papellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Papellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_Sapellido
        '
        '
        '
        '
        Me.TB_Sapellido.CustomButton.Image = Nothing
        Me.TB_Sapellido.CustomButton.Location = New System.Drawing.Point(339, 1)
        Me.TB_Sapellido.CustomButton.Name = ""
        Me.TB_Sapellido.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_Sapellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_Sapellido.CustomButton.TabIndex = 1
        Me.TB_Sapellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_Sapellido.CustomButton.UseSelectable = True
        Me.TB_Sapellido.CustomButton.Visible = False
        Me.TB_Sapellido.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_Sapellido.Lines = New String() {" "}
        Me.TB_Sapellido.Location = New System.Drawing.Point(39, 251)
        Me.TB_Sapellido.MaxLength = 32767
        Me.TB_Sapellido.Name = "TB_Sapellido"
        Me.TB_Sapellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Sapellido.PromptText = "Segundo Apellido"
        Me.TB_Sapellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_Sapellido.SelectedText = ""
        Me.TB_Sapellido.SelectionLength = 0
        Me.TB_Sapellido.SelectionStart = 0
        Me.TB_Sapellido.ShortcutsEnabled = True
        Me.TB_Sapellido.Size = New System.Drawing.Size(367, 29)
        Me.TB_Sapellido.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_Sapellido.TabIndex = 4
        Me.TB_Sapellido.Text = " "
        Me.TB_Sapellido.UseSelectable = True
        Me.TB_Sapellido.WaterMark = "Segundo Apellido"
        Me.TB_Sapellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_Sapellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_cedula
        '
        Me.TB_cedula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TB_cedula.CustomButton.Image = Nothing
        Me.TB_cedula.CustomButton.Location = New System.Drawing.Point(339, 1)
        Me.TB_cedula.CustomButton.Name = ""
        Me.TB_cedula.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_cedula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_cedula.CustomButton.TabIndex = 1
        Me.TB_cedula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_cedula.CustomButton.UseSelectable = True
        Me.TB_cedula.CustomButton.Visible = False
        Me.TB_cedula.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_cedula.Lines = New String() {" "}
        Me.TB_cedula.Location = New System.Drawing.Point(412, 146)
        Me.TB_cedula.MaxLength = 32767
        Me.TB_cedula.Name = "TB_cedula"
        Me.TB_cedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_cedula.PromptText = "Cédula"
        Me.TB_cedula.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_cedula.SelectedText = ""
        Me.TB_cedula.SelectionLength = 0
        Me.TB_cedula.SelectionStart = 0
        Me.TB_cedula.ShortcutsEnabled = True
        Me.TB_cedula.Size = New System.Drawing.Size(367, 29)
        Me.TB_cedula.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_cedula.TabIndex = 5
        Me.TB_cedula.Text = " "
        Me.TB_cedula.UseSelectable = True
        Me.TB_cedula.WaterMark = "Cédula"
        Me.TB_cedula.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_cedula.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'TB_pnombre
        '
        '
        '
        '
        Me.TB_pnombre.CustomButton.Image = Nothing
        Me.TB_pnombre.CustomButton.Location = New System.Drawing.Point(339, 1)
        Me.TB_pnombre.CustomButton.Name = ""
        Me.TB_pnombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_pnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_pnombre.CustomButton.TabIndex = 1
        Me.TB_pnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_pnombre.CustomButton.UseSelectable = True
        Me.TB_pnombre.CustomButton.Visible = False
        Me.TB_pnombre.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TB_pnombre.Lines = New String() {" "}
        Me.TB_pnombre.Location = New System.Drawing.Point(39, 146)
        Me.TB_pnombre.MaxLength = 32767
        Me.TB_pnombre.Name = "TB_pnombre"
        Me.TB_pnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_pnombre.PromptText = "Primer Nombre"
        Me.TB_pnombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_pnombre.SelectedText = ""
        Me.TB_pnombre.SelectionLength = 0
        Me.TB_pnombre.SelectionStart = 0
        Me.TB_pnombre.ShortcutsEnabled = True
        Me.TB_pnombre.Size = New System.Drawing.Size(367, 29)
        Me.TB_pnombre.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_pnombre.TabIndex = 1
        Me.TB_pnombre.Text = " "
        Me.TB_pnombre.UseSelectable = True
        Me.TB_pnombre.WaterMark = "Primer Nombre"
        Me.TB_pnombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_pnombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'DropDownPais
        '
        Me.DropDownPais.FormattingEnabled = True
        Me.DropDownPais.ItemHeight = 23
        Me.DropDownPais.Location = New System.Drawing.Point(39, 286)
        Me.DropDownPais.Name = "DropDownPais"
        Me.DropDownPais.PromptText = "País"
        Me.DropDownPais.Size = New System.Drawing.Size(181, 29)
        Me.DropDownPais.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropDownPais.TabIndex = 9
        Me.DropDownPais.UseSelectable = True
        '
        'DropdonwGenero
        '
        Me.DropdonwGenero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropdonwGenero.FormattingEnabled = True
        Me.DropdonwGenero.ItemHeight = 23
        Me.DropdonwGenero.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.DropdonwGenero.Location = New System.Drawing.Point(412, 216)
        Me.DropdonwGenero.Name = "DropdonwGenero"
        Me.DropdonwGenero.PromptText = "Genero"
        Me.DropdonwGenero.Size = New System.Drawing.Size(367, 29)
        Me.DropdonwGenero.Style = MetroFramework.MetroColorStyle.Silver
        Me.DropdonwGenero.TabIndex = 7
        Me.DropdonwGenero.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(33, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(431, 36)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Agregar empleado a Cliente"
        '
        'TB_correo
        '
        Me.TB_correo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TB_correo.CustomButton.Image = Nothing
        Me.TB_correo.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.TB_correo.CustomButton.Name = ""
        Me.TB_correo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.TB_correo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_correo.CustomButton.TabIndex = 1
        Me.TB_correo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_correo.CustomButton.UseSelectable = True
        Me.TB_correo.CustomButton.Visible = False
        Me.TB_correo.Lines = New String() {" "}
        Me.TB_correo.Location = New System.Drawing.Point(412, 488)
        Me.TB_correo.MaxLength = 32767
        Me.TB_correo.Name = "TB_correo"
        Me.TB_correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_correo.PromptText = "Correo Electronico"
        Me.TB_correo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TB_correo.SelectedText = ""
        Me.TB_correo.SelectionLength = 0
        Me.TB_correo.SelectionStart = 0
        Me.TB_correo.ShortcutsEnabled = True
        Me.TB_correo.Size = New System.Drawing.Size(187, 29)
        Me.TB_correo.Style = MetroFramework.MetroColorStyle.Silver
        Me.TB_correo.TabIndex = 18
        Me.TB_correo.Text = " "
        Me.TB_correo.UseSelectable = True
        Me.TB_correo.WaterMark = "Correo Electronico"
        Me.TB_correo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TB_correo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
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
        Me.BunifuFlatButton6.ButtonText = "Agregar"
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
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(14, 537)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(791, 39)
        Me.BunifuFlatButton6.TabIndex = 19
        Me.BunifuFlatButton6.Text = "Agregar"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FormAgregarNuevoEmpleadoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 588)
        Me.Controls.Add(Me.BunifuFlatButton6)
        Me.Controls.Add(Me.TB_correo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DropdownEmpresaClienteDepartamento)
        Me.Controls.Add(Me.DropDownEmpresa)
        Me.Controls.Add(Me.TBContra)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTFechaContrato)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTFechanacimiento)
        Me.Controls.Add(Me.DropdownNivelEstudio)
        Me.Controls.Add(Me.DropDownParroquias)
        Me.Controls.Add(Me.DropDownEstados)
        Me.Controls.Add(Me.DropDownMunicipios)
        Me.Controls.Add(Me.TB_Telefono)
        Me.Controls.Add(Me.TB_Snombre)
        Me.Controls.Add(Me.TB_Papellido)
        Me.Controls.Add(Me.TB_Sapellido)
        Me.Controls.Add(Me.TB_cedula)
        Me.Controls.Add(Me.TB_pnombre)
        Me.Controls.Add(Me.DropDownPais)
        Me.Controls.Add(Me.DropdonwGenero)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAgregarNuevoEmpleadoCliente"
        Me.Text = "FormAgregarNuevoEmpleadoCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DropdownEmpresaClienteDepartamento As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownEmpresa As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TBContra As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TBUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTFechaContrato As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label3 As Label
    Friend WithEvents DTFechanacimiento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DropdownNivelEstudio As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownParroquias As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownEstados As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownMunicipios As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TB_Telefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_Snombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_Papellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_Sapellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_cedula As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_pnombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DropDownPais As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropdonwGenero As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_correo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
End Class
