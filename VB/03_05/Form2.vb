Public Class Form2
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub btnInicio_Hover(sender As Object, e As EventArgs) Handles btnInicio.MouseHover
        btnInicio.BackColor = Color.FromArgb(255, 0, 0)
        btnInicio.ForeColor = Color.FromArgb(255, 0, 0)

    End Sub
    Private Sub btnInicio_Leave(sender As Object, e As EventArgs) Handles btnInicio.MouseLeave
        btnInicio.BackColor = Color.White
        btnInicio.ForeColor = Color.Black
    End Sub
End Class