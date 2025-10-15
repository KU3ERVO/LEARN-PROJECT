<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrestamo
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
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.CbxRaza = New System.Windows.Forms.ComboBox()
        Me.cbxOrigen = New System.Windows.Forms.ComboBox()
        Me.cbxCuotas = New System.Windows.Forms.ComboBox()
        Me.txtMontoPrestamo = New System.Windows.Forms.TextBox()
        Me.lbBienvenida = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAtras.Location = New System.Drawing.Point(713, 395)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 43)
        Me.btnAtras.TabIndex = 4
        Me.btnAtras.Text = "BACK"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirmar.Location = New System.Drawing.Point(359, 325)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(134, 29)
        Me.btnConfirmar.TabIndex = 7
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'CbxRaza
        '
        Me.CbxRaza.BackColor = System.Drawing.Color.White
        Me.CbxRaza.FormattingEnabled = True
        Me.CbxRaza.Items.AddRange(New Object() {"HUMANO", "GOBLIN", "DEMENTOR", "TROLL"})
        Me.CbxRaza.Location = New System.Drawing.Point(234, 158)
        Me.CbxRaza.Name = "CbxRaza"
        Me.CbxRaza.Size = New System.Drawing.Size(121, 21)
        Me.CbxRaza.TabIndex = 8
        '
        'cbxOrigen
        '
        Me.cbxOrigen.FormattingEnabled = True
        Me.cbxOrigen.Items.AddRange(New Object() {"Hogwarts", "Beauxbuttons", "Otro"})
        Me.cbxOrigen.Location = New System.Drawing.Point(234, 224)
        Me.cbxOrigen.Name = "cbxOrigen"
        Me.cbxOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cbxOrigen.TabIndex = 9
        '
        'cbxCuotas
        '
        Me.cbxCuotas.FormattingEnabled = True
        Me.cbxCuotas.Items.AddRange(New Object() {"3", "6", "12", "18", "24"})
        Me.cbxCuotas.Location = New System.Drawing.Point(491, 224)
        Me.cbxCuotas.Name = "cbxCuotas"
        Me.cbxCuotas.Size = New System.Drawing.Size(121, 21)
        Me.cbxCuotas.TabIndex = 10
        '
        'txtMontoPrestamo
        '
        Me.txtMontoPrestamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtMontoPrestamo.BackColor = System.Drawing.Color.PeachPuff
        Me.txtMontoPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoPrestamo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPrestamo.Location = New System.Drawing.Point(491, 158)
        Me.txtMontoPrestamo.Multiline = True
        Me.txtMontoPrestamo.Name = "txtMontoPrestamo"
        Me.txtMontoPrestamo.Size = New System.Drawing.Size(190, 20)
        Me.txtMontoPrestamo.TabIndex = 11
        Me.txtMontoPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbBienvenida
        '
        Me.lbBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbBienvenida.AutoSize = True
        Me.lbBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lbBienvenida.Font = New System.Drawing.Font("Times New Roman", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbBienvenida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbBienvenida.Location = New System.Drawing.Point(27, 26)
        Me.lbBienvenida.Name = "lbBienvenida"
        Me.lbBienvenida.Size = New System.Drawing.Size(344, 43)
        Me.lbBienvenida.TabIndex = 12
        Me.lbBienvenida.Text = "GRINGOTTS BANK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ORIGEN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "RAZA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(487, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "MONTO DEL PRÉSTAMO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(487, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "CUOTAS"
        '
        'FormPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miguel_03_06.My.Resources.Resources.istockphoto_867940676_612x612
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbBienvenida)
        Me.Controls.Add(Me.txtMontoPrestamo)
        Me.Controls.Add(Me.cbxCuotas)
        Me.Controls.Add(Me.cbxOrigen)
        Me.Controls.Add(Me.CbxRaza)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "FormPrestamo"
        Me.Text = "FormPrestamo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents CbxRaza As ComboBox
    Friend WithEvents cbxOrigen As ComboBox
    Friend WithEvents cbxCuotas As ComboBox
    Friend WithEvents txtMontoPrestamo As TextBox
    Friend WithEvents lbBienvenida As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
