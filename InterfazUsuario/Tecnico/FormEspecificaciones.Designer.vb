<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEspecificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEspecificaciones))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonElegirCarpeta = New FontAwesome.Sharp.IconButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ButtonIniciarLectura = New FontAwesome.Sharp.IconButton()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(386, 76)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(371, 338)
        Me.TreeView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(43, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 36)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Datos del CPU"
        '
        'ButtonElegirCarpeta
        '
        Me.ButtonElegirCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonElegirCarpeta.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonElegirCarpeta.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ButtonElegirCarpeta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonElegirCarpeta.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.ButtonElegirCarpeta.IconColor = System.Drawing.Color.Bisque
        Me.ButtonElegirCarpeta.IconSize = 26
        Me.ButtonElegirCarpeta.Location = New System.Drawing.Point(49, 371)
        Me.ButtonElegirCarpeta.Name = "ButtonElegirCarpeta"
        Me.ButtonElegirCarpeta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ButtonElegirCarpeta.Rotation = 0R
        Me.ButtonElegirCarpeta.Size = New System.Drawing.Size(331, 43)
        Me.ButtonElegirCarpeta.TabIndex = 86
        Me.ButtonElegirCarpeta.Text = "Elegir documento"
        Me.ButtonElegirCarpeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonElegirCarpeta.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(49, 76)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(331, 240)
        Me.RichTextBox1.TabIndex = 87
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'ButtonIniciarLectura
        '
        Me.ButtonIniciarLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIniciarLectura.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonIniciarLectura.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ButtonIniciarLectura.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonIniciarLectura.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.ButtonIniciarLectura.IconColor = System.Drawing.Color.Bisque
        Me.ButtonIniciarLectura.IconSize = 26
        Me.ButtonIniciarLectura.Location = New System.Drawing.Point(49, 322)
        Me.ButtonIniciarLectura.Name = "ButtonIniciarLectura"
        Me.ButtonIniciarLectura.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ButtonIniciarLectura.Rotation = 0R
        Me.ButtonIniciarLectura.Size = New System.Drawing.Size(331, 43)
        Me.ButtonIniciarLectura.TabIndex = 88
        Me.ButtonIniciarLectura.Text = "Iniciar Lectura"
        Me.ButtonIniciarLectura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonIniciarLectura.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'FormEspecificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonIniciarLectura)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ButtonElegirCarpeta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "FormEspecificaciones"
        Me.Text = "FormEspesificacionesCPU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonElegirCarpeta As FontAwesome.Sharp.IconButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ButtonIniciarLectura As FontAwesome.Sharp.IconButton
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
