Public Class FormInicio
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        FormPrestamo.lbBienvenida.Text = "Welcome, " + txtNombre.Text
        FormPrestamo.Show()
        Me.Hide()
    End Sub
End Class
