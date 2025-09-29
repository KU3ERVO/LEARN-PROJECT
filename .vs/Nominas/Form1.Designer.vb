<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.claseTrabajadorGB = New System.Windows.Forms.GroupBox()
        Me.afiliadoGB = New System.Windows.Forms.GroupBox()
        Me.añosServicioGB = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.salirBtn = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.siAfiliadoRB = New System.Windows.Forms.RadioButton()
        Me.noAfiliadoRB = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.claseTrabajadorGB.SuspendLayout()
        Me.afiliadoGB.SuspendLayout()
        Me.añosServicioGB.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'claseTrabajadorGB
        '
        Me.claseTrabajadorGB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.claseTrabajadorGB.Controls.Add(Me.RadioButton4)
        Me.claseTrabajadorGB.Controls.Add(Me.RadioButton3)
        Me.claseTrabajadorGB.Controls.Add(Me.RadioButton2)
        Me.claseTrabajadorGB.Controls.Add(Me.RadioButton1)
        Me.claseTrabajadorGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.claseTrabajadorGB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.claseTrabajadorGB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.claseTrabajadorGB.Location = New System.Drawing.Point(101, 99)
        Me.claseTrabajadorGB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.claseTrabajadorGB.Name = "claseTrabajadorGB"
        Me.claseTrabajadorGB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.claseTrabajadorGB.Size = New System.Drawing.Size(261, 105)
        Me.claseTrabajadorGB.TabIndex = 0
        Me.claseTrabajadorGB.TabStop = False
        Me.claseTrabajadorGB.Text = "Clase Trabajador"
        '
        'afiliadoGB
        '
        Me.afiliadoGB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.afiliadoGB.Controls.Add(Me.noAfiliadoRB)
        Me.afiliadoGB.Controls.Add(Me.siAfiliadoRB)
        Me.afiliadoGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.afiliadoGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.afiliadoGB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.afiliadoGB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.afiliadoGB.Location = New System.Drawing.Point(293, 235)
        Me.afiliadoGB.Margin = New System.Windows.Forms.Padding(4)
        Me.afiliadoGB.Name = "afiliadoGB"
        Me.afiliadoGB.Padding = New System.Windows.Forms.Padding(4)
        Me.afiliadoGB.Size = New System.Drawing.Size(152, 102)
        Me.afiliadoGB.TabIndex = 1
        Me.afiliadoGB.TabStop = False
        Me.afiliadoGB.Text = "Afiliado a sindicato"
        '
        'añosServicioGB
        '
        Me.añosServicioGB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.añosServicioGB.Controls.Add(Me.RadioButton9)
        Me.añosServicioGB.Controls.Add(Me.RadioButton8)
        Me.añosServicioGB.Controls.Add(Me.RadioButton7)
        Me.añosServicioGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.añosServicioGB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.añosServicioGB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.añosServicioGB.Location = New System.Drawing.Point(371, 381)
        Me.añosServicioGB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.añosServicioGB.Name = "añosServicioGB"
        Me.añosServicioGB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.añosServicioGB.Size = New System.Drawing.Size(141, 148)
        Me.añosServicioGB.TabIndex = 2
        Me.añosServicioGB.TabStop = False
        Me.añosServicioGB.Text = "Años de servicio"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(709, 500)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 27)
        Me.NumericUpDown1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(756, 468)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número de Hijos"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(573, 453)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(573, 495)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'salirBtn
        '
        Me.salirBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salirBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.salirBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.salirBtn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirBtn.Location = New System.Drawing.Point(1014, 609)
        Me.salirBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.salirBtn.Name = "salirBtn"
        Me.salirBtn.Size = New System.Drawing.Size(34, 34)
        Me.salirBtn.TabIndex = 7
        Me.salirBtn.Text = "X"
        Me.salirBtn.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(11, 29)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Obrero"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(11, 64)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(121, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Administrativo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(149, 31)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(73, 23)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Técnico"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(149, 64)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(98, 23)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Profesional"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'siAfiliadoRB
        '
        Me.siAfiliadoRB.AutoSize = True
        Me.siAfiliadoRB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siAfiliadoRB.Location = New System.Drawing.Point(11, 29)
        Me.siAfiliadoRB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.siAfiliadoRB.Name = "siAfiliadoRB"
        Me.siAfiliadoRB.Size = New System.Drawing.Size(39, 23)
        Me.siAfiliadoRB.TabIndex = 0
        Me.siAfiliadoRB.TabStop = True
        Me.siAfiliadoRB.Text = "Si"
        Me.siAfiliadoRB.UseVisualStyleBackColor = True
        '
        'noAfiliadoRB
        '
        Me.noAfiliadoRB.AutoSize = True
        Me.noAfiliadoRB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noAfiliadoRB.Location = New System.Drawing.Point(11, 64)
        Me.noAfiliadoRB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.noAfiliadoRB.Name = "noAfiliadoRB"
        Me.noAfiliadoRB.Size = New System.Drawing.Size(43, 23)
        Me.noAfiliadoRB.TabIndex = 1
        Me.noAfiliadoRB.TabStop = True
        Me.noAfiliadoRB.Text = "No"
        Me.noAfiliadoRB.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(11, 29)
        Me.RadioButton7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(79, 23)
        Me.RadioButton7.TabIndex = 0
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "< 5 años"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(11, 64)
        Me.RadioButton8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(97, 23)
        Me.RadioButton8.TabIndex = 1
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "5 - 10 años"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.Location = New System.Drawing.Point(11, 98)
        Me.RadioButton9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(84, 23)
        Me.RadioButton9.TabIndex = 2
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "> 10 años"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1061, 656)
        Me.Controls.Add(Me.salirBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.añosServicioGB)
        Me.Controls.Add(Me.afiliadoGB)
        Me.Controls.Add(Me.claseTrabajadorGB)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Nóminas"
        Me.claseTrabajadorGB.ResumeLayout(False)
        Me.claseTrabajadorGB.PerformLayout()
        Me.afiliadoGB.ResumeLayout(False)
        Me.afiliadoGB.PerformLayout()
        Me.añosServicioGB.ResumeLayout(False)
        Me.añosServicioGB.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents claseTrabajadorGB As GroupBox
    Friend WithEvents afiliadoGB As GroupBox
    Friend WithEvents añosServicioGB As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents salirBtn As Button
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents noAfiliadoRB As RadioButton
    Friend WithEvents siAfiliadoRB As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
End Class
