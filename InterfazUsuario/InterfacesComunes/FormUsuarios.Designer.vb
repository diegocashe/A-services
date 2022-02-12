<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuarios
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
        Me.ButtonReiniciarListView = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListViewDatosCompletos = New MetroFramework.Controls.MetroListView()
        Me.ButtonClose = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonReiniciarListView
        '
        Me.ButtonReiniciarListView.BackColor = System.Drawing.Color.Transparent
        Me.ButtonReiniciarListView.FlatAppearance.BorderSize = 0
        Me.ButtonReiniciarListView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReiniciarListView.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonReiniciarListView.IconChar = FontAwesome.Sharp.IconChar.Sync
        Me.ButtonReiniciarListView.IconColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonReiniciarListView.IconSize = 20
        Me.ButtonReiniciarListView.Location = New System.Drawing.Point(175, 105)
        Me.ButtonReiniciarListView.Name = "ButtonReiniciarListView"
        Me.ButtonReiniciarListView.Rotation = 0R
        Me.ButtonReiniciarListView.Size = New System.Drawing.Size(30, 29)
        Me.ButtonReiniciarListView.TabIndex = 64
        Me.ButtonReiniciarListView.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(42, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Para actualizar: "
        '
        'ListViewDatosCompletos
        '
        Me.ListViewDatosCompletos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewDatosCompletos.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListViewDatosCompletos.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListViewDatosCompletos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ListViewDatosCompletos.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListViewDatosCompletos.FullRowSelect = True
        Me.ListViewDatosCompletos.Location = New System.Drawing.Point(25, 142)
        Me.ListViewDatosCompletos.Name = "ListViewDatosCompletos"
        Me.ListViewDatosCompletos.OwnerDraw = True
        Me.ListViewDatosCompletos.Size = New System.Drawing.Size(868, 439)
        Me.ListViewDatosCompletos.Style = MetroFramework.MetroColorStyle.Silver
        Me.ListViewDatosCompletos.TabIndex = 62
        Me.ListViewDatosCompletos.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ListViewDatosCompletos.UseCompatibleStateImageBehavior = False
        Me.ListViewDatosCompletos.UseCustomBackColor = True
        Me.ListViewDatosCompletos.UseCustomForeColor = True
        Me.ListViewDatosCompletos.UseSelectable = True
        Me.ListViewDatosCompletos.UseStyleColors = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonClose.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.ButtonClose.IconColor = System.Drawing.Color.White
        Me.ButtonClose.IconSize = 20
        Me.ButtonClose.Location = New System.Drawing.Point(876, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Rotation = 0R
        Me.ButtonClose.Size = New System.Drawing.Size(39, 34)
        Me.ButtonClose.TabIndex = 59
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(19, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 36)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Hola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(42, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 21)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Tus datos son los siguientes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(114, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 36)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "."
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 592)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonReiniciarListView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListViewDatosCompletos)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInicio_clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonReiniciarListView As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ListViewDatosCompletos As MetroFramework.Controls.MetroListView
    Friend WithEvents ButtonClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
