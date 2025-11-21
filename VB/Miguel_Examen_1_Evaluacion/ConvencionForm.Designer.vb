<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvencionForm
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
        cmbCocina = New ComboBox()
        dtpFecha = New DateTimePicker()
        cmbEvento = New ComboBox()
        Label3 = New Label()
        Fe = New Label()
        Label2 = New Label()
        lblNombre = New Label()
        txtTFN = New TextBox()
        txtNombre = New TextBox()
        btnAtras = New Button()
        btnSalir = New Button()
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
        Panel1.Controls.Add(cmbCocina)
        Panel1.Controls.Add(dtpFecha)
        Panel1.Controls.Add(cmbEvento)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Fe)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblNombre)
        Panel1.Controls.Add(txtTFN)
        Panel1.Controls.Add(txtNombre)
        Panel1.Location = New Point(183, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(499, 240)
        Panel1.TabIndex = 18
        ' 
        ' cmbCocina
        ' 
        cmbCocina.FormattingEnabled = True
        cmbCocina.Location = New Point(335, 198)
        cmbCocina.Name = "cmbCocina"
        cmbCocina.Size = New Size(140, 23)
        cmbCocina.TabIndex = 15
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Location = New Point(173, 145)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(293, 23)
        dtpFecha.TabIndex = 14
        ' 
        ' cmbEvento
        ' 
        cmbEvento.FormattingEnabled = True
        cmbEvento.Location = New Point(173, 198)
        cmbEvento.Name = "cmbEvento"
        cmbEvento.Size = New Size(140, 23)
        cmbEvento.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bernard MT Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(21, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 31)
        Label3.TabIndex = 12
        Label3.Text = "Evento"
        ' 
        ' Fe
        ' 
        Fe.AutoSize = True
        Fe.BackColor = Color.Transparent
        Fe.Font = New Font("Bernard MT Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fe.ForeColor = Color.Black
        Fe.Location = New Point(21, 137)
        Fe.Name = "Fe"
        Fe.Size = New Size(73, 31)
        Fe.TabIndex = 11
        Fe.Text = "Fecha"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bernard MT Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(21, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 31)
        Label2.TabIndex = 10
        Label2.Text = "Telefono"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.BackColor = Color.Transparent
        lblNombre.Font = New Font("Bernard MT Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombre.ForeColor = Color.Black
        lblNombre.Location = New Point(21, 33)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(94, 31)
        lblNombre.TabIndex = 9
        lblNombre.Text = "Nombre"
        ' 
        ' txtTFN
        ' 
        txtTFN.Location = New Point(173, 93)
        txtTFN.Name = "txtTFN"
        txtTFN.Size = New Size(293, 23)
        txtTFN.TabIndex = 1
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(173, 38)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(293, 23)
        txtNombre.TabIndex = 0
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
        ' ConvencionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.jungle
        ClientSize = New Size(800, 450)
        Controls.Add(panelTitulo)
        Controls.Add(btnSiguiente)
        Controls.Add(Panel1)
        Controls.Add(btnAtras)
        Controls.Add(btnSalir)
        MaximumSize = New Size(816, 489)
        MinimumSize = New Size(816, 489)
        Name = "ConvencionForm"
        Text = "ConvencionForm"
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
    Friend WithEvents cmbCocina As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmbEvento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Fe As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtTFN As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSalir As Button
End Class
