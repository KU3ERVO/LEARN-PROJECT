<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CongresoForm
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
        btnAtras = New Button()
        btnSalir = New Button()
        btnGuardar = New Button()
        panelTitulo.SuspendLayout()
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
        panelTitulo.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Harlow Solid Italic", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(186, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(438, 34)
        Label1.TabIndex = 8
        Label1.Text = "Seleccione su tipo de Evento a Reservar"
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
        btnSiguiente.Location = New Point(331, 354)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(199, 62)
        btnSiguiente.TabIndex = 19
        btnSiguiente.Text = "SIGUIENTE"
        btnSiguiente.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.IndianRed
        Panel1.Location = New Point(183, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(499, 240)
        Panel1.TabIndex = 18
        ' 
        ' btnAtras
        ' 
        btnAtras.BackColor = Color.IndianRed
        btnAtras.FlatAppearance.BorderColor = Color.Black
        btnAtras.FlatStyle = FlatStyle.Flat
        btnAtras.Font = New Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAtras.ForeColor = Color.Transparent
        btnAtras.Location = New Point(9, 416)
        btnAtras.Name = "btnAtras"
        btnAtras.Size = New Size(117, 41)
        btnAtras.TabIndex = 16
        btnAtras.Text = "ATRAS"
        btnAtras.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.IndianRed
        btnSalir.FlatAppearance.BorderColor = Color.Black
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.Transparent
        btnSalir.Location = New Point(758, 416)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(43, 41)
        btnSalir.TabIndex = 15
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
        btnGuardar.Location = New Point(548, 354)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(199, 62)
        btnGuardar.TabIndex = 20
        btnGuardar.Text = "SIGUIENTE"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' CongresoForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.jungle
        ClientSize = New Size(800, 450)
        Controls.Add(btnGuardar)
        Controls.Add(panelTitulo)
        Controls.Add(btnSiguiente)
        Controls.Add(Panel1)
        Controls.Add(btnAtras)
        Controls.Add(btnSalir)
        Name = "CongresoForm"
        Text = "CongresoForm"
        panelTitulo.ResumeLayout(False)
        panelTitulo.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
End Class
