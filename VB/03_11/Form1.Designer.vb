<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        panelTitulo = New Panel()
        Label2 = New Label()
        lblNombre = New Label()
        btnAgregar = New Button()
        gbxDatos = New GroupBox()
        cbxSexo = New ComboBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtDni = New TextBox()
        txtNombre = New TextBox()
        lblSexo = New Label()
        lblDireccion = New Label()
        lblTfn = New Label()
        lblDni = New Label()
        btnSalir = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnGuardar = New Button()
        dgvDatos = New DataGridView()
        ColumnNombre = New DataGridViewTextBoxColumn()
        ColumnDni = New DataGridViewTextBoxColumn()
        ColumnTfn = New DataGridViewTextBoxColumn()
        ColumnDireccion = New DataGridViewTextBoxColumn()
        ColumnSexo = New DataGridViewTextBoxColumn()
        ErrorProvider1 = New ErrorProvider(components)
        panelTitulo.SuspendLayout()
        gbxDatos.SuspendLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelTitulo
        ' 
        panelTitulo.BackColor = Color.Maroon
        panelTitulo.BackgroundImageLayout = ImageLayout.None
        panelTitulo.Controls.Add(Label2)
        panelTitulo.Dock = DockStyle.Top
        panelTitulo.Location = New Point(0, 0)
        panelTitulo.Name = "panelTitulo"
        panelTitulo.Size = New Size(816, 79)
        panelTitulo.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Maroon
        Label2.Font = New Font("Elephant", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(314, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 41)
        Label2.TabIndex = 1
        Label2.Text = "AGENDA"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Bauhaus 93", 15.75F)
        lblNombre.ForeColor = Color.White
        lblNombre.Location = New Point(42, 43)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(90, 24)
        lblNombre.TabIndex = 0
        lblNombre.Text = "NOMBRE"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnAgregar.Cursor = Cursors.Hand
        btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Bauhaus 93", 12F)
        btnAgregar.ForeColor = Color.White
        btnAgregar.Location = New Point(654, 136)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(111, 45)
        btnAgregar.TabIndex = 5
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' gbxDatos
        ' 
        gbxDatos.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        gbxDatos.Controls.Add(cbxSexo)
        gbxDatos.Controls.Add(txtDireccion)
        gbxDatos.Controls.Add(txtTelefono)
        gbxDatos.Controls.Add(txtDni)
        gbxDatos.Controls.Add(txtNombre)
        gbxDatos.Controls.Add(lblSexo)
        gbxDatos.Controls.Add(lblDireccion)
        gbxDatos.Controls.Add(lblTfn)
        gbxDatos.Controls.Add(lblDni)
        gbxDatos.Controls.Add(lblNombre)
        gbxDatos.FlatStyle = FlatStyle.Flat
        gbxDatos.Font = New Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbxDatos.ForeColor = Color.White
        gbxDatos.Location = New Point(42, 103)
        gbxDatos.Name = "gbxDatos"
        gbxDatos.Size = New Size(576, 304)
        gbxDatos.TabIndex = 2
        gbxDatos.TabStop = False
        gbxDatos.Tag = "Datos"
        gbxDatos.Text = "datos"
        ' 
        ' cbxSexo
        ' 
        cbxSexo.FlatStyle = FlatStyle.Flat
        cbxSexo.FormattingEnabled = True
        cbxSexo.Location = New Point(244, 245)
        cbxSexo.Name = "cbxSexo"
        cbxSexo.Size = New Size(303, 32)
        cbxSexo.TabIndex = 4
        ' 
        ' txtDireccion
        ' 
        txtDireccion.BorderStyle = BorderStyle.None
        txtDireccion.Location = New Point(244, 196)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(303, 31)
        txtDireccion.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.BorderStyle = BorderStyle.None
        txtTelefono.Location = New Point(244, 145)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(303, 31)
        txtTelefono.TabIndex = 2
        ' 
        ' txtDni
        ' 
        txtDni.BorderStyle = BorderStyle.None
        txtDni.Location = New Point(244, 94)
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(303, 31)
        txtDni.TabIndex = 1
        ' 
        ' txtNombre
        ' 
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.Location = New Point(244, 43)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(303, 31)
        txtNombre.TabIndex = 0
        ' 
        ' lblSexo
        ' 
        lblSexo.AutoSize = True
        lblSexo.Font = New Font("Bauhaus 93", 15.75F)
        lblSexo.ForeColor = Color.White
        lblSexo.Location = New Point(42, 248)
        lblSexo.Name = "lblSexo"
        lblSexo.Size = New Size(55, 24)
        lblSexo.TabIndex = 4
        lblSexo.Text = "SEXO"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Bauhaus 93", 15.75F)
        lblDireccion.ForeColor = Color.White
        lblDireccion.Location = New Point(42, 197)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(122, 24)
        lblDireccion.TabIndex = 3
        lblDireccion.Text = "DIRECCION"
        ' 
        ' lblTfn
        ' 
        lblTfn.AutoSize = True
        lblTfn.Font = New Font("Bauhaus 93", 15.75F)
        lblTfn.ForeColor = Color.White
        lblTfn.Location = New Point(42, 146)
        lblTfn.Name = "lblTfn"
        lblTfn.Size = New Size(102, 24)
        lblTfn.TabIndex = 2
        lblTfn.Text = "TELEFONO"
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Font = New Font("Bauhaus 93", 15.75F)
        lblDni.ForeColor = Color.White
        lblDni.Location = New Point(42, 95)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(44, 24)
        lblDni.TabIndex = 1
        lblDni.Text = "DNI"
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Bauhaus 93", 12F)
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(654, 341)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(111, 45)
        btnSalir.TabIndex = 9
        btnSalir.Text = "EXIT"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.Enabled = False
        btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Bauhaus 93", 12F)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(654, 290)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(111, 45)
        btnEliminar.TabIndex = 8
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnModificar.Cursor = Cursors.Hand
        btnModificar.Enabled = False
        btnModificar.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.Font = New Font("Bauhaus 93", 12F)
        btnModificar.ForeColor = Color.White
        btnModificar.Location = New Point(654, 239)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(111, 45)
        btnModificar.TabIndex = 7
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Bauhaus 93", 12F)
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(654, 188)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(111, 45)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' dgvDatos
        ' 
        dgvDatos.AllowUserToAddRows = False
        dgvDatos.BackgroundColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDatos.Columns.AddRange(New DataGridViewColumn() {ColumnNombre, ColumnDni, ColumnTfn, ColumnDireccion, ColumnSexo})
        dgvDatos.GridColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        dgvDatos.Location = New Point(42, 442)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDatos.Size = New Size(723, 187)
        dgvDatos.TabIndex = 10
        ' 
        ' ColumnNombre
        ' 
        ColumnNombre.HeaderText = "NOMBRE"
        ColumnNombre.Name = "ColumnNombre"
        ' 
        ' ColumnDni
        ' 
        ColumnDni.HeaderText = "DNI"
        ColumnDni.Name = "ColumnDni"
        ' 
        ' ColumnTfn
        ' 
        ColumnTfn.HeaderText = "TFNO"
        ColumnTfn.Name = "ColumnTfn"
        ' 
        ' ColumnDireccion
        ' 
        ColumnDireccion.HeaderText = "DIRECCION"
        ColumnDireccion.Name = "ColumnDireccion"
        ' 
        ' ColumnSexo
        ' 
        ColumnSexo.HeaderText = "SEXO"
        ColumnSexo.Name = "ColumnSexo"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        ClientSize = New Size(816, 670)
        Controls.Add(dgvDatos)
        Controls.Add(btnGuardar)
        Controls.Add(btnModificar)
        Controls.Add(btnEliminar)
        Controls.Add(btnSalir)
        Controls.Add(gbxDatos)
        Controls.Add(btnAgregar)
        Controls.Add(panelTitulo)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(816, 670)
        MinimumSize = New Size(816, 670)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agenda"
        panelTitulo.ResumeLayout(False)
        panelTitulo.PerformLayout()
        gbxDatos.ResumeLayout(False)
        gbxDatos.PerformLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelTitulo As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents gbxDatos As GroupBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTfn As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cbxSexo As ComboBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDni As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTfn As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDireccion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSexo As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
