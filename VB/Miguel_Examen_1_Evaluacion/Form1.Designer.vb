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
        btnReserva = New Button()
        lblTitle = New Label()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' btnReserva
        ' 
        btnReserva.BackColor = Color.IndianRed
        btnReserva.FlatAppearance.BorderColor = Color.IndianRed
        btnReserva.FlatStyle = FlatStyle.Flat
        btnReserva.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReserva.ForeColor = Color.Transparent
        btnReserva.Location = New Point(318, 202)
        btnReserva.Name = "btnReserva"
        btnReserva.Size = New Size(199, 62)
        btnReserva.TabIndex = 0
        btnReserva.Text = "RESERVAR"
        btnReserva.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Bernard MT Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.LightCoral
        lblTitle.Location = New Point(220, 48)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(381, 76)
        lblTitle.TabIndex = 1
        lblTitle.Text = "SALON HAVANA"
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.IndianRed
        btnSalir.FlatAppearance.BorderColor = Color.IndianRed
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.Transparent
        btnSalir.Location = New Point(761, 436)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(43, 41)
        btnSalir.TabIndex = 3
        btnSalir.Text = "X"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.jungle
        ClientSize = New Size(816, 489)
        Controls.Add(btnSalir)
        Controls.Add(lblTitle)
        Controls.Add(btnReserva)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(816, 489)
        MinimumSize = New Size(816, 489)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RESERVAR"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReserva As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSalir As Button

End Class
