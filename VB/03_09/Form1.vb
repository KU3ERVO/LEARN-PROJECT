PublicClass Form1
Dim memoria1 As Double = 0.0
Dim memoria2 As Double = 0.0
Dim signo As String

'Botones del 0 – 9

Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
    txtResultado.Text = txtResultado.Text & "0"
    ' txtResultado.Text  &=  "0"
End Sub


Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
    txtResultado.Text = txtResultado.Text & "1"
End Sub

Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
    txtResultado.Text = txtResultado.Text & "2"
End Sub

Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
    txtResultado.Text = txtResultado.Text & "3"
End Sub

Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
    txtResultado.Text = txtResultado.Text& "4"
End Sub

Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
    txtResultado.Text = txtResultado.Text& "5"
End Sub

Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
    txtResultado.Text = txtResultado.Text & "6"
End Sub

Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
    txtResultado.Text = txtResultado.Text & "7"
End Sub

Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
    txtResultado.Text = txtResultado.Text & "8"
End Sub

Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
    txtResultado.Text = txtResultado.Text & "9"
End Sub

'Botones suma, resta, multiplicación, raíz, potencia y porcentaje

Private Sub btnSuma_Click(sender As Object, e As EventArgs) HandlesbtnSuma.Click

If txtResultado.Text Then
        memoria1 = Val(txtResultado.Text)
        signo = "+"
        txtResultado.Clear()
    End If

End Sub

Private Sub btnResta_Click(sender As Object, e As EventArgs) HandlesbtnResta.Click

If txtResultado.Text Then
        memoria1 = Val(txtResultado.Text)
        signo = "-"
        txtResultado.Clear()
    End If

End Sub

Private Sub btnMulti_Click(sender As Object, e As EventArgs) HandlesbtnMulti.Click

If txtResultado.Text Then
        memoria1 = Val(txtResultado.Text)
        signo = "*"
        txtResultado.Clear()
    End If

End Sub

Private Sub btnDivision_Click(sender As Object, e As EventArgs) HandlesbtnDivision.Click

If txtResultado.Text Then
        memoria1 = Val(txtResultado.Text)
        signo = "/"
        txtResultado.Clear()
    End If

End Sub

Private Sub btnRaiz_Click(sender As Object, e As EventArgs) HandlesbtnRaiz.Click

If txtResultado.Text Then
        memoria1 = Val(txtResultado.Text)
        signo = "raiz"
        txtResultado.Clear()
    End If

End Sub

Private Sub btnPotencia_Click(sender As Object, e As EventArgs) HandlesbtnPotencia.Click

If txtResultado.Text Then
        memoria1 = Val(txtResultado.Text)
        signo = "exponente"
        txtResultado.Clear()
    End If

End Sub

Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) HandlesbtnPorcentaje.Click

If txtResultado.Text Then
        memoria1 = Val(txtResultado.Text)
        signo = "%"
        txtResultado.Clear()
    End If

End Sub

'Botón Borrar 

Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) HandlesbtnBorrarTodo.Click

txtResultado.Clear()
    memoria1 = 0.0
    memoria2 = 0.0
    signo = String.Empty

End Sub

'Botón Borrar derecha

Private Sub btnBorrarDerecha_Click(sender As Object, e As EventArgs) Handles btnBorrarDerecha.Click

    Dim largo As Integer

    IftxtResultado.Text<> "" Then
largo = txtResultado.Text.Length
txtResultado.Text = Mid(txtResultado.Text, 1, largo - 1)
End If

End Sub

‘Botón +/-

Private Sub btnMasMenos_Click(sender As Object, e As EventArgs) HandlesbtnMasMenos.Click

If txtResultado.Text <> "" Then
txtResultado.Text = txtResultado.Text * (-1)
End If

End Sub

‘Botón Inversa

Private Sub btnInversa_Click(sender As Object, e As EventArgs) HandlesbtnInversa.Click

If txtResultado.Text <> "" Then
txtResultado.Text = 1 / (txtResultado.Text)
EndIf

End Sub

‘Botón del punto decimal, la segunda opción es más completa
‘Primera opción

Private Sub btnPunto_Click(sender As Object, e As EventArgs) HandlesbtnPunto.Click
If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
txtResultado.Text&= "0."
End If
End Sub


‘Segunda opción

    'Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click

    '    If txtResultado.Text = "" Then
    '        txtResultado.Text = "0."
    '    ElseIfexistepunto(txtResultado.Text) = False Then
    '        txtResultado.Text = txtResultado.Text& "."
    '    EndIf

    'End Sub

‘Botón igual

Private Sub btnIgual_Click(sender As Object, e As EventArgs) HandlesbtnIgual.Click

If txtResultado.Text <>  "" And memoria1 <> 0.0 Then
                memoria2 = txtResultado.Text
calculadora()
EndIf

End Sub

‘función para la segunda opción

    'Private Function existepunto(ByVal cadena As String) As Boolean
    '    Dim largo As Integer
    '    Dim respuesta As Boolean = False
    '    largo = cadena.Length

    '    For i As Integer = 1 To largo Step 1
    '        If Mid(cadena, i, 1) = "." Then
    '            respuesta = True
    '        EndIf
    '    Next
    '    Return respuesta

    'EndFunction

Private Sub calculadora()
Select Case signo
            Case "+"
txtResultado.Text = memoria1 + memoria2
            Case "-"
txtResultado.Text = memoria1 - memoria2
            Case "*"
txtResultado.Text = memoria1 * memoria2
            Case "/"
txtResultado.Text = memoria1 / memoria2
            Case "raiz"
txtResultado.Text = memoria1 ^ (1 / memoria2)
            Case "exponente"
txtResultado.Text = memoria1 ^ memoria2
            Case "%"
txtResultado.Text = (memoria1 * memoria2) / 100
            Case Else
                	MsgBox("Error")
EndSelect
End Sub

EndClass