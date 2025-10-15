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
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.lbPedido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTele = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.lbxLista = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnPedido = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbTitulo.Location = New System.Drawing.Point(32, 26)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(403, 38)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Pili y Mili Pedidos Express"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(68, 170)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(53, 16)
        Me.lbNombre.TabIndex = 1
        Me.lbNombre.Text = "Nombre:"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.Location = New System.Drawing.Point(68, 207)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(25, 16)
        Me.lbTelefono.TabIndex = 2
        Me.lbTelefono.Text = "Tfn:"
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDireccion.Location = New System.Drawing.Point(68, 246)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(60, 16)
        Me.lbDireccion.TabIndex = 3
        Me.lbDireccion.Text = "Dirección:"
        '
        'lbPedido
        '
        Me.lbPedido.AutoSize = True
        Me.lbPedido.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPedido.Location = New System.Drawing.Point(68, 283)
        Me.lbPedido.Name = "lbPedido"
        Me.lbPedido.Size = New System.Drawing.Size(49, 16)
        Me.lbPedido.TabIndex = 4
        Me.lbPedido.Text = "Pedido:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(136, 162)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 21)
        Me.txtNombre.TabIndex = 5
        '
        'txtTele
        '
        Me.txtTele.BackColor = System.Drawing.Color.White
        Me.txtTele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTele.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTele.Location = New System.Drawing.Point(136, 204)
        Me.txtTele.Name = "txtTele"
        Me.txtTele.Size = New System.Drawing.Size(100, 21)
        Me.txtTele.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(136, 243)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 21)
        Me.txtDireccion.TabIndex = 7
        '
        'txtPedido
        '
        Me.txtPedido.BackColor = System.Drawing.Color.White
        Me.txtPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPedido.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.Location = New System.Drawing.Point(136, 283)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(100, 21)
        Me.txtPedido.TabIndex = 8
        '
        'lbxLista
        '
        Me.lbxLista.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxLista.FormattingEnabled = True
        Me.lbxLista.ItemHeight = 16
        Me.lbxLista.Location = New System.Drawing.Point(499, 42)
        Me.lbxLista.Name = "lbxLista"
        Me.lbxLista.Size = New System.Drawing.Size(213, 372)
        Me.lbxLista.TabIndex = 9
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(322, 246)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnPedido
        '
        Me.btnPedido.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedido.Location = New System.Drawing.Point(322, 200)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnPedido.TabIndex = 11
        Me.btnPedido.Text = "PEDIDO"
        Me.btnPedido.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(742, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(46, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "EXIT"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPedido)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lbxLista)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTele)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbPedido)
        Me.Controls.Add(Me.lbDireccion)
        Me.Controls.Add(Me.lbTelefono)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitulo As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents lbDireccion As Label
    Friend WithEvents lbPedido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTele As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents lbxLista As ListBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnPedido As Button
    Friend WithEvents btnSalir As Button
End Class
