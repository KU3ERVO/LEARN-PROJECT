Public Class Form1

    Dim memoria1 As Double = 0.0
    Dim memoria2 As Double = 0.0
    Dim signo As String

    '--- Botones del 0–9 ---
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResultado.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResultado.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtResultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtResultado.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtResultado.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResultado.Text &= "9"
    End Sub


    '--- Botones de operaciones ---
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        If txtResultado.Text <> "" Then
            memoria1 = Val(txtResultado.Text)
            signo = "+"
            txtResultado.Clear()
        End If
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        If txtResultado.Text <> "" Then
            memoria1 = Val(txtResultado.Text)
            signo = "-"
            txtResultado.Clear()
        End If
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        If txtResultado.Text <> "" Then
            memoria1 = Val(txtResultado.Text)
            signo = "*"
            txtResultado.Clear()
        End If
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        If txtResultado.Text <> "" Then
            memoria1 = Val(txtResultado.Text)
            signo = "/"
            txtResultado.Clear()
        End If
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        If txtResultado.Text <> "" Then
            memoria1 = Val(txtResultado.Text)
            signo = "raiz"
            txtResultado.Clear()
        End If
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        If txtResultado.Text <> "" Then
            memoria1 = Val(txtResultado.Text)
            signo = "exponente"
            txtResultado.Clear()
        End If
    End Sub

    Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        If txtResultado.Text <> "" Then
            memoria1 = Val(txtResultado.Text)
            signo = "%"
            txtResultado.Clear()
        End If
    End Sub


    '--- Botón Borrar Todo ---
    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarTodo.Click
        txtResultado.Clear()
        memoria1 = 0.0
        memoria2 = 0.0
        signo = String.Empty
    End Sub


    '--- Botón Borrar Derecha ---
    Private Sub btnBorrarDerecha_Click(sender As Object, e As EventArgs) Handles btnBorrarDerecha.Click
        If txtResultado.Text <> "" Then
            txtResultado.Text = Mid(txtResultado.Text, 1, txtResultado.Text.Length - 1)
        End If
    End Sub


    '--- Botón +/- ---
    Private Sub btnMasMenos_Click(sender As Object, e As EventArgs) Handles btnMasMenos.Click
        If txtResultado.Text <> "" Then
            txtResultado.Text = (Val(txtResultado.Text) * -1).ToString()
        End If
    End Sub


    '--- Botón Inversa ---
    Private Sub btnInversa_Click(sender As Object, e As EventArgs) Handles btnInversa.Click
        If txtResultado.Text <> "" Then
            txtResultado.Text = (1 / Val(txtResultado.Text)).ToString()
        End If
    End Sub


    '--- Botón Punto Decimal ---
    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            If txtResultado.Text = "" Then
                txtResultado.Text = "0."
            Else
                txtResultado.Text &= "."
            End If
        End If
    End Sub


    '--- Botón Igual ---
    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If txtResultado.Text <> "" And memoria1 <> 0.0 Then
            memoria2 = Val(txtResultado.Text)
            calculadora()
        End If
    End Sub


    '--- Función principal ---
    Private Sub calculadora()
        Select Case signo
            Case "+"
                txtResultado.Text = (memoria1 + memoria2).ToString()
            Case "-"
                txtResultado.Text = (memoria1 - memoria2).ToString()
            Case "*"
                txtResultado.Text = (memoria1 * memoria2).ToString()
            Case "/"
                txtResultado.Text = (memoria1 / memoria2).ToString()
            Case "raiz"
                txtResultado.Text = (memoria1 ^ (1 / memoria2)).ToString()
            Case "exponente"
                txtResultado.Text = (memoria1 ^ memoria2).ToString()
            Case "%"
                txtResultado.Text = ((memoria1 * memoria2) / 100).ToString()
            Case Else
                MsgBox("Error")
        End Select
    End Sub

End Class
