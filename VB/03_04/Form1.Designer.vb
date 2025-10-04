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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtPrecioConIVA = New System.Windows.Forms.TextBox()
        Me.txtPrecioSinIVA = New System.Windows.Forms.TextBox()
        Me.lbPrecioSinIVA = New System.Windows.Forms.Label()
        Me.lbPrecioIVA = New System.Windows.Forms.Label()
        Me.lbDescuento = New System.Windows.Forms.Label()
        Me.lbTotalPago = New System.Windows.Forms.Label()
        Me.chbIva = New System.Windows.Forms.CheckBox()
        Me.chbDescuento = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(210, 116)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(15, 213)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = " "
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(404, 213)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtTotalPago
        '
        Me.txtTotalPago.Location = New System.Drawing.Point(198, 185)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPago.TabIndex = 3
        Me.txtTotalPago.Text = "0"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(379, 31)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 4
        Me.txtDescuento.Text = "0"
        '
        'txtPrecioConIVA
        '
        Me.txtPrecioConIVA.Location = New System.Drawing.Point(198, 31)
        Me.txtPrecioConIVA.Name = "txtPrecioConIVA"
        Me.txtPrecioConIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioConIVA.TabIndex = 5
        Me.txtPrecioConIVA.Text = "0"
        '
        'txtPrecioSinIVA
        '
        Me.txtPrecioSinIVA.Location = New System.Drawing.Point(12, 31)
        Me.txtPrecioSinIVA.Name = "txtPrecioSinIVA"
        Me.txtPrecioSinIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioSinIVA.TabIndex = 6
        Me.txtPrecioSinIVA.Text = "0"
        '
        'lbPrecioSinIVA
        '
        Me.lbPrecioSinIVA.AutoSize = True
        Me.lbPrecioSinIVA.Location = New System.Drawing.Point(12, 15)
        Me.lbPrecioSinIVA.Name = "lbPrecioSinIVA"
        Me.lbPrecioSinIVA.Size = New System.Drawing.Size(73, 13)
        Me.lbPrecioSinIVA.TabIndex = 7
        Me.lbPrecioSinIVA.Text = "Precio sin IVA"
        '
        'lbPrecioIVA
        '
        Me.lbPrecioIVA.AutoSize = True
        Me.lbPrecioIVA.Location = New System.Drawing.Point(195, 15)
        Me.lbPrecioIVA.Name = "lbPrecioIVA"
        Me.lbPrecioIVA.Size = New System.Drawing.Size(78, 13)
        Me.lbPrecioIVA.TabIndex = 8
        Me.lbPrecioIVA.Text = "Precio con IVA"
        '
        'lbDescuento
        '
        Me.lbDescuento.AutoSize = True
        Me.lbDescuento.Location = New System.Drawing.Point(376, 15)
        Me.lbDescuento.Name = "lbDescuento"
        Me.lbDescuento.Size = New System.Drawing.Size(59, 13)
        Me.lbDescuento.TabIndex = 9
        Me.lbDescuento.Text = "Descuento"
        '
        'lbTotalPago
        '
        Me.lbTotalPago.AutoSize = True
        Me.lbTotalPago.Location = New System.Drawing.Point(195, 169)
        Me.lbTotalPago.Name = "lbTotalPago"
        Me.lbTotalPago.Size = New System.Drawing.Size(71, 13)
        Me.lbTotalPago.TabIndex = 10
        Me.lbTotalPago.Text = "Total a Pagar"
        '
        'chbIva
        '
        Me.chbIva.AutoSize = True
        Me.chbIva.Location = New System.Drawing.Point(198, 66)
        Me.chbIva.Name = "chbIva"
        Me.chbIva.Size = New System.Drawing.Size(97, 17)
        Me.chbIva.TabIndex = 11
        Me.chbIva.Text = "Precio con IVA"
        Me.chbIva.UseVisualStyleBackColor = True
        '
        'chbDescuento
        '
        Me.chbDescuento.AutoSize = True
        Me.chbDescuento.Location = New System.Drawing.Point(379, 66)
        Me.chbDescuento.Name = "chbDescuento"
        Me.chbDescuento.Size = New System.Drawing.Size(78, 17)
        Me.chbDescuento.TabIndex = 12
        Me.chbDescuento.Text = "Descuento"
        Me.chbDescuento.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 255)
        Me.Controls.Add(Me.chbDescuento)
        Me.Controls.Add(Me.chbIva)
        Me.Controls.Add(Me.lbTotalPago)
        Me.Controls.Add(Me.lbDescuento)
        Me.Controls.Add(Me.lbPrecioIVA)
        Me.Controls.Add(Me.lbPrecioSinIVA)
        Me.Controls.Add(Me.txtPrecioSinIVA)
        Me.Controls.Add(Me.txtPrecioConIVA)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtTotalPago)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtTotalPago As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtPrecioConIVA As TextBox
    Friend WithEvents txtPrecioSinIVA As TextBox
    Friend WithEvents lbPrecioSinIVA As Label
    Friend WithEvents lbPrecioIVA As Label
    Friend WithEvents lbDescuento As Label
    Friend WithEvents lbTotalPago As Label
    Friend WithEvents chbIva As CheckBox
    Friend WithEvents chbDescuento As CheckBox
End Class
