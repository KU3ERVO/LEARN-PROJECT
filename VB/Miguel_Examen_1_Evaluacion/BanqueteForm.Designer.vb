<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BanqueteForm
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
        panelTitulo = New Panel()
        Label1 = New Label()
        lblTitle = New Label()
        btnSiguiente = New Button()
        Panel1 = New Panel()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        btnVolver = New Button()
        btnSalir = New Button()
        btnGuardar = New Button()
        panelTitulo.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelTitulo
        ' 
        panelTitulo.BackColor = Color.IndianRed
        panelTitulo.Controls.Add(Label1)
        panelTitulo.Controls.Add(lblTitle)
        panelTitulo.Dock = DockStyle.Top
        panelTitulo.Location = New Point(0, 0)
        panelTitulo.Name = "panelTitulo"
        panelTitulo.Size = New Size(800, 81)
        panelTitulo.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Harlow Solid Italic", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(348, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 34)
        Label1.TabIndex = 8
        Label1.Text = "Banquete"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Bernard MT Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.LightCoral
        lblTitle.Location = New Point(218, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(381, 76)
        lblTitle.TabIndex = 7
        lblTitle.Text = "SALON HAVANA"
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.BackColor = Color.IndianRed
        btnSiguiente.FlatAppearance.BorderColor = Color.IndianRed
        btnSiguiente.FlatStyle = FlatStyle.Flat
        btnSiguiente.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSiguiente.ForeColor = Color.Transparent
        btnSiguiente.Location = New Point(184, 361)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(199, 62)
        btnSiguiente.TabIndex = 14
        btnSiguiente.Text = "SIGUIENTE"
        btnSiguiente.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.IndianRed
        Panel1.Controls.Add(RadioButton3)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Location = New Point(184, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(499, 240)
        Panel1.TabIndex = 13
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(288, 106)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(97, 19)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(284, 75)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(291, 42)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.IndianRed
        btnVolver.FlatAppearance.BorderColor = Color.Black
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.Transparent
        btnVolver.Location = New Point(10, 423)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(117, 41)
        btnVolver.TabIndex = 11
        btnVolver.Text = "ATRAS"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.IndianRed
        btnSalir.FlatAppearance.BorderColor = Color.Black
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.Transparent
        btnSalir.Location = New Point(759, 423)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(43, 41)
        btnSalir.TabIndex = 10
        btnSalir.Text = "X"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.IndianRed
        btnGuardar.FlatAppearance.BorderColor = Color.IndianRed
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.Transparent
        btnGuardar.Location = New Point(475, 361)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(199, 62)
        btnGuardar.TabIndex = 15
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' BanqueteForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.jungle
        ClientSize = New Size(800, 450)
        Controls.Add(btnGuardar)
        Controls.Add(panelTitulo)
        Controls.Add(btnSiguiente)
        Controls.Add(Panel1)
        Controls.Add(btnVolver)
        Controls.Add(btnSalir)
        Name = "BanqueteForm"
        Text = "BanqueteForm"
        panelTitulo.ResumeLayout(False)
        panelTitulo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
