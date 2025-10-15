<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
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
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lbBanco2 = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbBanco = New System.Windows.Forms.Label()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.Miguel_03_06.My.Resources.Resources.Blason_de_Gringotts
        Me.pbxLogo.Location = New System.Drawing.Point(331, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(190, 248)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'lbBanco2
        '
        Me.lbBanco2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbBanco2.AutoSize = True
        Me.lbBanco2.BackColor = System.Drawing.Color.Transparent
        Me.lbBanco2.Font = New System.Drawing.Font("Times New Roman", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbBanco2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbBanco2.Location = New System.Drawing.Point(-1, 113)
        Me.lbBanco2.Name = "lbBanco2"
        Me.lbBanco2.Size = New System.Drawing.Size(344, 43)
        Me.lbBanco2.TabIndex = 1
        Me.lbBanco2.Text = "GRINGOTTS BANK"
        '
        'lbNombre
        '
        Me.lbNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbNombre.AutoSize = True
        Me.lbNombre.BackColor = System.Drawing.Color.Transparent
        Me.lbNombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(215, 305)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(110, 19)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "YOUR NAME :"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(753, 395)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 43)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "EXIT"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BackColor = System.Drawing.Color.PeachPuff
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(331, 305)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(190, 20)
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.Text = "NAME"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbBanco
        '
        Me.lbBanco.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbBanco.AutoSize = True
        Me.lbBanco.BackColor = System.Drawing.Color.Transparent
        Me.lbBanco.Font = New System.Drawing.Font("Times New Roman", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbBanco.Location = New System.Drawing.Point(499, 113)
        Me.lbBanco.Name = "lbBanco"
        Me.lbBanco.Size = New System.Drawing.Size(344, 43)
        Me.lbBanco.TabIndex = 5
        Me.lbBanco.Text = "GRINGOTTS BANK"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSolicitar.Location = New System.Drawing.Point(359, 331)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(134, 29)
        Me.btnSolicitar.TabIndex = 6
        Me.btnSolicitar.Text = "SOLICITAR"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BackgroundImage = Global.Miguel_03_06.My.Resources.Resources.istockphoto_867940676_612x612
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 450)
        Me.Controls.Add(Me.btnSolicitar)
        Me.Controls.Add(Me.lbBanco)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbBanco2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "FormInicio"
        Me.Text = "Form1"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents lbBanco2 As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lbBanco As Label
    Friend WithEvents btnSolicitar As Button
End Class
