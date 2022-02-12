<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAsistencias
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
        Me.DropdownAccion = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownTipo = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownSolicitudes = New MetroFramework.Controls.MetroComboBox()
        Me.DropDownServicio = New MetroFramework.Controls.MetroComboBox()
        Me.TextBoxDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDescripcionSolicitud = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'DropdownAccion
        '
        Me.DropdownAccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropdownAccion.FormattingEnabled = True
        Me.DropdownAccion.ItemHeight = 23
        Me.DropdownAccion.Items.AddRange(New Object() {"CAMBIO", "MANTENIMIENTO", "REPARACION"})
        Me.DropdownAccion.Location = New System.Drawing.Point(40, 157)
        Me.DropdownAccion.Name = "DropdownAccion"
        Me.DropdownAccion.PromptText = "Accion"
        Me.DropdownAccion.Size = New System.Drawing.Size(334, 29)
        Me.DropdownAccion.TabIndex = 1
        Me.DropdownAccion.UseSelectable = True
        '
        'DropDownTipo
        '
        Me.DropDownTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropDownTipo.FormattingEnabled = True
        Me.DropDownTipo.ItemHeight = 23
        Me.DropDownTipo.Items.AddRange(New Object() {"PRESENCIAL", "REMOTA"})
        Me.DropDownTipo.Location = New System.Drawing.Point(40, 202)
        Me.DropDownTipo.Name = "DropDownTipo"
        Me.DropDownTipo.PromptText = "Tipo"
        Me.DropDownTipo.Size = New System.Drawing.Size(334, 29)
        Me.DropDownTipo.TabIndex = 2
        Me.DropDownTipo.UseSelectable = True
        '
        'DropDownSolicitudes
        '
        Me.DropDownSolicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropDownSolicitudes.FormattingEnabled = True
        Me.DropDownSolicitudes.ItemHeight = 23
        Me.DropDownSolicitudes.Location = New System.Drawing.Point(40, 112)
        Me.DropDownSolicitudes.Name = "DropDownSolicitudes"
        Me.DropDownSolicitudes.PromptText = "Solicitud"
        Me.DropDownSolicitudes.Size = New System.Drawing.Size(334, 29)
        Me.DropDownSolicitudes.TabIndex = 3
        Me.DropDownSolicitudes.UseSelectable = True
        '
        'DropDownServicio
        '
        Me.DropDownServicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropDownServicio.FormattingEnabled = True
        Me.DropDownServicio.ItemHeight = 23
        Me.DropDownServicio.Items.AddRange(New Object() {"PRESENCIAL", "REMOTA"})
        Me.DropDownServicio.Location = New System.Drawing.Point(40, 247)
        Me.DropDownServicio.Name = "DropDownServicio"
        Me.DropDownServicio.PromptText = "Servicio"
        Me.DropDownServicio.Size = New System.Drawing.Size(334, 29)
        Me.DropDownServicio.TabIndex = 4
        Me.DropDownServicio.UseSelectable = True
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TextBoxDescripcion.CustomButton.Image = Nothing
        Me.TextBoxDescripcion.CustomButton.Location = New System.Drawing.Point(160, 2)
        Me.TextBoxDescripcion.CustomButton.Name = ""
        Me.TextBoxDescripcion.CustomButton.Size = New System.Drawing.Size(175, 175)
        Me.TextBoxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBoxDescripcion.CustomButton.TabIndex = 1
        Me.TextBoxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBoxDescripcion.CustomButton.UseSelectable = True
        Me.TextBoxDescripcion.CustomButton.Visible = False
        Me.TextBoxDescripcion.Lines = New String(-1) {}
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(40, 292)
        Me.TextBoxDescripcion.MaxLength = 32767
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxDescripcion.PromptText = "Descripcion"
        Me.TextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxDescripcion.SelectedText = ""
        Me.TextBoxDescripcion.SelectionLength = 0
        Me.TextBoxDescripcion.SelectionStart = 0
        Me.TextBoxDescripcion.ShortcutsEnabled = True
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(338, 180)
        Me.TextBoxDescripcion.TabIndex = 5
        Me.TextBoxDescripcion.UseSelectable = True
        Me.TextBoxDescripcion.WaterMark = "Descripcion"
        Me.TextBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBoxDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 36)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Asistencia"
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
        Me.ButtonActualizar.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonActualizar.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActualizar.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonActualizar.Iconimage = Nothing
        Me.ButtonActualizar.Iconimage_right = Nothing
        Me.ButtonActualizar.Iconimage_right_Selected = Nothing
        Me.ButtonActualizar.Iconimage_Selected = Nothing
        Me.ButtonActualizar.IconMarginLeft = 0
        Me.ButtonActualizar.IconMarginRight = 0
        Me.ButtonActualizar.IconRightVisible = False
        Me.ButtonActualizar.IconRightZoom = 0R
        Me.ButtonActualizar.IconVisible = False
        Me.ButtonActualizar.IconZoom = 90.0R
        Me.ButtonActualizar.IsTab = False
        Me.ButtonActualizar.Location = New System.Drawing.Point(402, 391)
        Me.ButtonActualizar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonActualizar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonActualizar.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonActualizar.selected = False
        Me.ButtonActualizar.Size = New System.Drawing.Size(354, 81)
        Me.ButtonActualizar.TabIndex = 94
        Me.ButtonActualizar.Text = "Enviar Datos"
        Me.ButtonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonActualizar.Textcolor = System.Drawing.Color.Black
        Me.ButtonActualizar.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(396, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 36)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Posible problema:"
        '
        'TextBoxDescripcionSolicitud
        '
        Me.TextBoxDescripcionSolicitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TextBoxDescripcionSolicitud.CustomButton.Image = Nothing
        Me.TextBoxDescripcionSolicitud.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.TextBoxDescripcionSolicitud.CustomButton.Name = ""
        Me.TextBoxDescripcionSolicitud.CustomButton.Size = New System.Drawing.Size(223, 223)
        Me.TextBoxDescripcionSolicitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBoxDescripcionSolicitud.CustomButton.TabIndex = 1
        Me.TextBoxDescripcionSolicitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBoxDescripcionSolicitud.CustomButton.UseSelectable = True
        Me.TextBoxDescripcionSolicitud.CustomButton.Visible = False
        Me.TextBoxDescripcionSolicitud.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.TextBoxDescripcionSolicitud.Lines = New String(-1) {}
        Me.TextBoxDescripcionSolicitud.Location = New System.Drawing.Point(402, 157)
        Me.TextBoxDescripcionSolicitud.MaxLength = 32767
        Me.TextBoxDescripcionSolicitud.Name = "TextBoxDescripcionSolicitud"
        Me.TextBoxDescripcionSolicitud.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxDescripcionSolicitud.PromptText = "Descripcion"
        Me.TextBoxDescripcionSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxDescripcionSolicitud.SelectedText = ""
        Me.TextBoxDescripcionSolicitud.SelectionLength = 0
        Me.TextBoxDescripcionSolicitud.SelectionStart = 0
        Me.TextBoxDescripcionSolicitud.ShortcutsEnabled = True
        Me.TextBoxDescripcionSolicitud.Size = New System.Drawing.Size(354, 225)
        Me.TextBoxDescripcionSolicitud.TabIndex = 96
        Me.TextBoxDescripcionSolicitud.UseCustomBackColor = True
        Me.TextBoxDescripcionSolicitud.UseCustomForeColor = True
        Me.TextBoxDescripcionSolicitud.UseSelectable = True
        Me.TextBoxDescripcionSolicitud.UseStyleColors = True
        Me.TextBoxDescripcionSolicitud.WaterMark = "Descripcion"
        Me.TextBoxDescripcionSolicitud.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBoxDescripcionSolicitud.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FormAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(791, 539)
        Me.Controls.Add(Me.TextBoxDescripcionSolicitud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.DropDownServicio)
        Me.Controls.Add(Me.DropDownSolicitudes)
        Me.Controls.Add(Me.DropDownTipo)
        Me.Controls.Add(Me.DropdownAccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAsistencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DropdownAccion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownTipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownSolicitudes As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DropDownServicio As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TextBoxDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonActualizar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDescripcionSolicitud As MetroFramework.Controls.MetroTextBox
End Class
