Public Class Form1
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        Dim Total As Decimal = txtPrecioSinIVA.Text

        If (chbIva.Checked = True) Then
            Total = txtPrecioConIVA.Text
        End If

        If (chbDescuento.Checked = True) Then
            Total -= txtDescuento.Text
        End If

        txtTotalPago.Text = Total

    End Sub

    Private Sub txtPrecioSinIVA_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioSinIVA.TextChanged

        Dim Precio As Decimal = txtPrecioSinIVA.Text

        txtPrecioConIVA.Text = Precio + (Precio * 0.21)

        Select Case Precio
            Case Is <= 100
                txtDescuento.Text = 0
            Case 101 To 500
                txtDescuento.Text = Precio * 0.05
            Case 501 To 1000
                txtDescuento.Text = Precio * 0.1
            Case Is > 1000
                txtDescuento.Text = Precio * 0.15
        End Select


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDescuento.Text = 0
        txtTotalPago.Text = 0
        txtPrecioSinIVA.Text = 0
        txtPrecioConIVA.Text = 0
    End Sub
End Class
