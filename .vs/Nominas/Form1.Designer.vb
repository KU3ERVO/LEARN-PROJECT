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
        Me.rbProfesional = New System.Windows.Forms.RadioButton()
        Me.rbTecnico = New System.Windows.Forms.RadioButton()
        Me.rbAdministrativo = New System.Windows.Forms.RadioButton()
        Me.rbObrero = New System.Windows.Forms.RadioButton()
        Me.afiliadoGB = New System.Windows.Forms.GroupBox()
        Me.rbSindicatoNo = New System.Windows.Forms.RadioButton()
        Me.rbSindicatoSi = New System.Windows.Forms.RadioButton()
        Me.añosServicioGB = New System.Windows.Forms.GroupBox()
        Me.rbServicio10 = New System.Windows.Forms.RadioButton()
        Me.rbServicio5a10 = New System.Windows.Forms.RadioButton()
        Me.rbServicio5 = New System.Windows.Forms.RadioButton()
        Me.nudHijos = New System.Windows.Forms.NumericUpDown()
        Me.lblNumhijos = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.claseTrabajadorGB.SuspendLayout()
        Me.afiliadoGB.SuspendLayout()
        Me.añosServicioGB.SuspendLayout()
        CType(Me.nudHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'claseTrabajadorGB
        '
        Me.claseTrabajadorGB.BackColor = System.Drawing.Color.Gainsboro
        Me.claseTrabajadorGB.Controls.Add(Me.rbProfesional)
        Me.claseTrabajadorGB.Controls.Add(Me.rbTecnico)
        Me.claseTrabajadorGB.Controls.Add(Me.rbAdministrativo)
        Me.claseTrabajadorGB.Controls.Add(Me.rbObrero)
        Me.claseTrabajadorGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.claseTrabajadorGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.claseTrabajadorGB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.claseTrabajadorGB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.claseTrabajadorGB.Location = New System.Drawing.Point(75, 75)
        Me.claseTrabajadorGB.Margin = New System.Windows.Forms.Padding(4)
        Me.claseTrabajadorGB.Name = "claseTrabajadorGB"
        Me.claseTrabajadorGB.Padding = New System.Windows.Forms.Padding(4)
        Me.claseTrabajadorGB.Size = New System.Drawing.Size(152, 163)
        Me.claseTrabajadorGB.TabIndex = 0
        Me.claseTrabajadorGB.TabStop = False
        Me.claseTrabajadorGB.Text = "Clase Trabajador"
        '
        'rbProfesional
        '
        Me.rbProfesional.AutoSize = True
        Me.rbProfesional.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProfesional.Location = New System.Drawing.Point(11, 126)
        Me.rbProfesional.Margin = New System.Windows.Forms.Padding(4)
        Me.rbProfesional.Name = "rbProfesional"
        Me.rbProfesional.Size = New System.Drawing.Size(98, 23)
        Me.rbProfesional.TabIndex = 3
        Me.rbProfesional.TabStop = True
        Me.rbProfesional.Text = "Profesional"
        Me.rbProfesional.UseVisualStyleBackColor = True
        '
        'rbTecnico
        '
        Me.rbTecnico.AutoSize = True
        Me.rbTecnico.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTecnico.Location = New System.Drawing.Point(11, 95)
        Me.rbTecnico.Margin = New System.Windows.Forms.Padding(4)
        Me.rbTecnico.Name = "rbTecnico"
        Me.rbTecnico.Size = New System.Drawing.Size(73, 23)
        Me.rbTecnico.TabIndex = 2
        Me.rbTecnico.TabStop = True
        Me.rbTecnico.Text = "Técnico"
        Me.rbTecnico.UseVisualStyleBackColor = True
        '
        'rbAdministrativo
        '
        Me.rbAdministrativo.AutoSize = True
        Me.rbAdministrativo.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdministrativo.Location = New System.Drawing.Point(11, 64)
        Me.rbAdministrativo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbAdministrativo.Name = "rbAdministrativo"
        Me.rbAdministrativo.Size = New System.Drawing.Size(121, 23)
        Me.rbAdministrativo.TabIndex = 1
        Me.rbAdministrativo.TabStop = True
        Me.rbAdministrativo.Text = "Administrativo"
        Me.rbAdministrativo.UseVisualStyleBackColor = True
        '
        'rbObrero
        '
        Me.rbObrero.AutoSize = True
        Me.rbObrero.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbObrero.Location = New System.Drawing.Point(11, 29)
        Me.rbObrero.Margin = New System.Windows.Forms.Padding(4)
        Me.rbObrero.Name = "rbObrero"
        Me.rbObrero.Size = New System.Drawing.Size(70, 23)
        Me.rbObrero.TabIndex = 0
        Me.rbObrero.TabStop = True
        Me.rbObrero.Text = "Obrero"
        Me.rbObrero.UseVisualStyleBackColor = True
        '
        'afiliadoGB
        '
        Me.afiliadoGB.BackColor = System.Drawing.Color.Gainsboro
        Me.afiliadoGB.Controls.Add(Me.rbSindicatoNo)
        Me.afiliadoGB.Controls.Add(Me.rbSindicatoSi)
        Me.afiliadoGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.afiliadoGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.afiliadoGB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.afiliadoGB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.afiliadoGB.Location = New System.Drawing.Point(75, 255)
        Me.afiliadoGB.Margin = New System.Windows.Forms.Padding(4)
        Me.afiliadoGB.Name = "afiliadoGB"
        Me.afiliadoGB.Padding = New System.Windows.Forms.Padding(4)
        Me.afiliadoGB.Size = New System.Drawing.Size(152, 102)
        Me.afiliadoGB.TabIndex = 1
        Me.afiliadoGB.TabStop = False
        Me.afiliadoGB.Text = "Afiliado a sindicato"
        '
        'rbSindicatoNo
        '
        Me.rbSindicatoNo.AutoSize = True
        Me.rbSindicatoNo.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSindicatoNo.Location = New System.Drawing.Point(11, 64)
        Me.rbSindicatoNo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSindicatoNo.Name = "rbSindicatoNo"
        Me.rbSindicatoNo.Size = New System.Drawing.Size(43, 23)
        Me.rbSindicatoNo.TabIndex = 1
        Me.rbSindicatoNo.TabStop = True
        Me.rbSindicatoNo.Text = "No"
        Me.rbSindicatoNo.UseVisualStyleBackColor = True
        '
        'rbSindicatoSi
        '
        Me.rbSindicatoSi.AutoSize = True
        Me.rbSindicatoSi.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSindicatoSi.Location = New System.Drawing.Point(11, 29)
        Me.rbSindicatoSi.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSindicatoSi.Name = "rbSindicatoSi"
        Me.rbSindicatoSi.Size = New System.Drawing.Size(39, 23)
        Me.rbSindicatoSi.TabIndex = 0
        Me.rbSindicatoSi.TabStop = True
        Me.rbSindicatoSi.Text = "Si"
        Me.rbSindicatoSi.UseVisualStyleBackColor = True
        '
        'añosServicioGB
        '
        Me.añosServicioGB.BackColor = System.Drawing.Color.Gainsboro
        Me.añosServicioGB.Controls.Add(Me.rbServicio10)
        Me.añosServicioGB.Controls.Add(Me.rbServicio5a10)
        Me.añosServicioGB.Controls.Add(Me.rbServicio5)
        Me.añosServicioGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.añosServicioGB.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.añosServicioGB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.añosServicioGB.Location = New System.Drawing.Point(75, 375)
        Me.añosServicioGB.Margin = New System.Windows.Forms.Padding(4)
        Me.añosServicioGB.Name = "añosServicioGB"
        Me.añosServicioGB.Padding = New System.Windows.Forms.Padding(4)
        Me.añosServicioGB.Size = New System.Drawing.Size(152, 148)
        Me.añosServicioGB.TabIndex = 2
        Me.añosServicioGB.TabStop = False
        Me.añosServicioGB.Text = "Años de servicio"
        '
        'rbServicio10
        '
        Me.rbServicio10.AutoSize = True
        Me.rbServicio10.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServicio10.Location = New System.Drawing.Point(11, 98)
        Me.rbServicio10.Margin = New System.Windows.Forms.Padding(4)
        Me.rbServicio10.Name = "rbServicio10"
        Me.rbServicio10.Size = New System.Drawing.Size(84, 23)
        Me.rbServicio10.TabIndex = 2
        Me.rbServicio10.TabStop = True
        Me.rbServicio10.Text = "> 10 años"
        Me.rbServicio10.UseVisualStyleBackColor = True
        '
        'rbServicio5a10
        '
        Me.rbServicio5a10.AutoSize = True
        Me.rbServicio5a10.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServicio5a10.Location = New System.Drawing.Point(11, 64)
        Me.rbServicio5a10.Margin = New System.Windows.Forms.Padding(4)
        Me.rbServicio5a10.Name = "rbServicio5a10"
        Me.rbServicio5a10.Size = New System.Drawing.Size(97, 23)
        Me.rbServicio5a10.TabIndex = 1
        Me.rbServicio5a10.TabStop = True
        Me.rbServicio5a10.Text = "5 - 10 años"
        Me.rbServicio5a10.UseVisualStyleBackColor = True
        '
        'rbServicio5
        '
        Me.rbServicio5.AutoSize = True
        Me.rbServicio5.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServicio5.Location = New System.Drawing.Point(11, 29)
        Me.rbServicio5.Margin = New System.Windows.Forms.Padding(4)
        Me.rbServicio5.Name = "rbServicio5"
        Me.rbServicio5.Size = New System.Drawing.Size(79, 23)
        Me.rbServicio5.TabIndex = 0
        Me.rbServicio5.TabStop = True
        Me.rbServicio5.Text = "< 5 años"
        Me.rbServicio5.UseVisualStyleBackColor = True
        '
        'nudHijos
        '
        Me.nudHijos.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHijos.Location = New System.Drawing.Point(294, 435)
        Me.nudHijos.Margin = New System.Windows.Forms.Padding(4)
        Me.nudHijos.Name = "nudHijos"
        Me.nudHijos.Size = New System.Drawing.Size(160, 27)
        Me.nudHijos.TabIndex = 3
        '
        'lblNumhijos
        '
        Me.lblNumhijos.AutoSize = True
        Me.lblNumhijos.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumhijos.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblNumhijos.Location = New System.Drawing.Point(290, 406)
        Me.lblNumhijos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumhijos.Name = "lblNumhijos"
        Me.lblNumhijos.Size = New System.Drawing.Size(112, 19)
        Me.lblNumhijos.TabIndex = 4
        Me.lblNumhijos.Text = "Número de Hijos"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(294, 489)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 34)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(419, 489)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 34)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.LightCoral
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(485, 75)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(34, 34)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "X"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(593, 591)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblNumhijos)
        Me.Controls.Add(Me.nudHijos)
        Me.Controls.Add(Me.añosServicioGB)
        Me.Controls.Add(Me.afiliadoGB)
        Me.Controls.Add(Me.claseTrabajadorGB)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Nóminas"
        Me.claseTrabajadorGB.ResumeLayout(False)
        Me.claseTrabajadorGB.PerformLayout()
        Me.afiliadoGB.ResumeLayout(False)
        Me.afiliadoGB.PerformLayout()
        Me.añosServicioGB.ResumeLayout(False)
        Me.añosServicioGB.PerformLayout()
        CType(Me.nudHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents claseTrabajadorGB As GroupBox
    Friend WithEvents afiliadoGB As GroupBox
    Friend WithEvents añosServicioGB As GroupBox
    Friend WithEvents nudHijos As NumericUpDown
    Friend WithEvents lblNumhijos As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents rbProfesional As RadioButton
    Friend WithEvents rbTecnico As RadioButton
    Friend WithEvents rbAdministrativo As RadioButton
    Friend WithEvents rbObrero As RadioButton
    Friend WithEvents rbSindicatoNo As RadioButton
    Friend WithEvents rbSindicatoSi As RadioButton
    Friend WithEvents rbServicio5a10 As RadioButton
    Friend WithEvents rbServicio5 As RadioButton
    Friend WithEvents rbServicio10 As RadioButton
End Class
