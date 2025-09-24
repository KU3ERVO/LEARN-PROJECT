<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.SumaBtn = New System.Windows.Forms.Button()
        Me.RestaBtn = New System.Windows.Forms.Button()
        Me.ResulTxt = New System.Windows.Forms.TextBox()
        Me.MultiBtn = New System.Windows.Forms.Button()
        Me.DiviBtn = New System.Windows.Forms.Button()
        Me.LimpiarBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.Num1Txt = New System.Windows.Forms.TextBox()
        Me.Num2Txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Location = New System.Drawing.Point(288, 99)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(41, 13)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "NUM 1"
        '
        'SumaBtn
        '
        Me.SumaBtn.BackColor = System.Drawing.Color.White
        Me.SumaBtn.Location = New System.Drawing.Point(67, 115)
        Me.SumaBtn.Name = "SumaBtn"
        Me.SumaBtn.Size = New System.Drawing.Size(75, 23)
        Me.SumaBtn.TabIndex = 1
        Me.SumaBtn.Text = "+"
        Me.SumaBtn.UseVisualStyleBackColor = False
        '
        'RestaBtn
        '
        Me.RestaBtn.Location = New System.Drawing.Point(67, 172)
        Me.RestaBtn.Name = "RestaBtn"
        Me.RestaBtn.Size = New System.Drawing.Size(75, 23)
        Me.RestaBtn.TabIndex = 2
        Me.RestaBtn.Text = "-"
        Me.RestaBtn.UseVisualStyleBackColor = True
        '
        'ResulTxt
        '
        Me.ResulTxt.Location = New System.Drawing.Point(368, 292)
        Me.ResulTxt.Name = "ResulTxt"
        Me.ResulTxt.Size = New System.Drawing.Size(100, 20)
        Me.ResulTxt.TabIndex = 3
        '
        'MultiBtn
        '
        Me.MultiBtn.Location = New System.Drawing.Point(67, 229)
        Me.MultiBtn.Name = "MultiBtn"
        Me.MultiBtn.Size = New System.Drawing.Size(75, 23)
        Me.MultiBtn.TabIndex = 4
        Me.MultiBtn.Text = "x"
        Me.MultiBtn.UseVisualStyleBackColor = True
        '
        'DiviBtn
        '
        Me.DiviBtn.Location = New System.Drawing.Point(67, 292)
        Me.DiviBtn.Name = "DiviBtn"
        Me.DiviBtn.Size = New System.Drawing.Size(75, 23)
        Me.DiviBtn.TabIndex = 5
        Me.DiviBtn.Text = "/"
        Me.DiviBtn.UseVisualStyleBackColor = True
        '
        'LimpiarBtn
        '
        Me.LimpiarBtn.Location = New System.Drawing.Point(381, 318)
        Me.LimpiarBtn.Name = "LimpiarBtn"
        Me.LimpiarBtn.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarBtn.TabIndex = 6
        Me.LimpiarBtn.Text = "LIMPIAR"
        Me.LimpiarBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(713, 415)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 7
        Me.ExitBtn.Text = "EXIT"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Location = New System.Drawing.Point(496, 99)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(41, 13)
        Me.Num2.TabIndex = 8
        Me.Num2.Text = "NUM 2"
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Location = New System.Drawing.Point(383, 276)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(73, 13)
        Me.Resultado.TabIndex = 9
        Me.Resultado.Text = "RESULTADO"
        '
        'Num1Txt
        '
        Me.Num1Txt.Location = New System.Drawing.Point(259, 115)
        Me.Num1Txt.Name = "Num1Txt"
        Me.Num1Txt.Size = New System.Drawing.Size(100, 20)
        Me.Num1Txt.TabIndex = 10
        '
        'Num2Txt
        '
        Me.Num2Txt.Location = New System.Drawing.Point(465, 115)
        Me.Num2Txt.Name = "Num2Txt"
        Me.Num2Txt.Size = New System.Drawing.Size(100, 20)
        Me.Num2Txt.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Num2Txt)
        Me.Controls.Add(Me.Num1Txt)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.LimpiarBtn)
        Me.Controls.Add(Me.DiviBtn)
        Me.Controls.Add(Me.MultiBtn)
        Me.Controls.Add(Me.ResulTxt)
        Me.Controls.Add(Me.RestaBtn)
        Me.Controls.Add(Me.SumaBtn)
        Me.Controls.Add(Me.Num1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Num1 As Label
    Friend WithEvents SumaBtn As Button
    Friend WithEvents RestaBtn As Button
    Friend WithEvents ResulTxt As TextBox
    Friend WithEvents MultiBtn As Button
    Friend WithEvents DiviBtn As Button
    Friend WithEvents LimpiarBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Num2 As Label
    Friend WithEvents Resultado As Label
    Friend WithEvents Num1Txt As TextBox
    Friend WithEvents Num2Txt As TextBox
End Class
