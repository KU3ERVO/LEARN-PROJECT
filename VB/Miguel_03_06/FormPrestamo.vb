Public Class FormPrestamo
    Dim cuota As Double
    Dim raza As Double
    Dim origen As Double
    Dim monto As Double
    Private Sub lbBienvenida_Click(sender As Object, e As EventArgs) Handles lbBienvenida.VisibleChanged

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormInicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        FormSolucion.txtCuota.Text = cuota + raza + origen + monto
        FormSolucion.Show()
        Me.Hide()

    End Sub

    Private Sub CbxRaza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxRaza.SelectedIndexChanged
        Select Case CbxRaza.Text
            Case "HUMANO"
                raza = 1000
            Case "GOBLIN"
                raza = 10000
            Case "DEMENTOR"
                raza = -5000
            Case "TROLL"
                raza = -500
        End Select
    End Sub

    Private Sub cbxOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrigen.SelectedIndexChanged
        Select Case cbxOrigen.Text
            Case "Hogwarts"
                origen = 100
            Case "Beauxbuttons"
                origen = -100
            Case "Otro"
                origen = -100
        End Select
    End Sub

    Private Sub cbxCuotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCuotas.SelectedIndexChanged
        Select Case cbxCuotas.Text
            Case "3"
                cuota = 3
            Case "6"
                cuota = 6
            Case "12"
                cuota = 12
            Case "18"
                cuota = 18
            Case "24"
                cuota = 24
        End Select
    End Sub

    Private Sub txtMontoPrestamo_TextChanged(sender As Object, e As EventArgs) Handles txtMontoPrestamo.TextChanged
        monto = txtMontoPrestamo.Text
    End Sub
End Class