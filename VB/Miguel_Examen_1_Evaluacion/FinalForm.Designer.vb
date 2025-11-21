<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalForm
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
        btnCerrar = New Button()
        lblTitle = New Label()
        dgvBookings = New DataGridView()
        Label1 = New Label()
        CType(dgvBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.IndianRed
        btnCerrar.FlatAppearance.BorderColor = Color.IndianRed
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCerrar.ForeColor = Color.Transparent
        btnCerrar.Location = New Point(745, 414)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(43, 41)
        btnCerrar.TabIndex = 6
        btnCerrar.Text = "X"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Bernard MT Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.LightCoral
        lblTitle.Location = New Point(216, 23)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(381, 76)
        lblTitle.TabIndex = 5
        lblTitle.Text = "SALON HAVANA"
        ' 
        ' dgvBookings
        ' 
        dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookings.Location = New Point(101, 149)
        dgvBookings.Name = "dgvBookings"
        dgvBookings.Size = New Size(593, 234)
        dgvBookings.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bernard MT Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(329, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 34)
        Label1.TabIndex = 8
        Label1.Text = "RESERVAS"
        ' 
        ' FinalForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.jungle
        ClientSize = New Size(816, 489)
        Controls.Add(Label1)
        Controls.Add(dgvBookings)
        Controls.Add(btnCerrar)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(816, 489)
        MinimumSize = New Size(816, 489)
        Name = "FinalForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FinalForm"
        CType(dgvBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents Label1 As Label
End Class
