Public Class Form1

    Dim ruta = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\fichero.txt"
    Private Sub lbxLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxLista.SelectedIndexChanged

    End Sub

    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click

        lbxLista.Items.Add(txtNombre.Text)
        lbxLista.Items.Add(txtTele.Text)
        lbxLista.Items.Add(txtDireccion.Text)
        lbxLista.Items.Add(txtPedido.Text)
        lbxLista.Items.Add(DateAndTime.Now)

        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "Nombre: " & txtNombre.Text & " Teléfono: " & txtTele.Text & " Dirección: " & txtDireccion.Text & " Pedido: " & txtPedido.Text & vbCrLf, True)

        MessageBox.Show("Información del pedido se ha guardado")

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDireccion.Text = ""
        txtTele.Text = ""
        txtPedido.Text = ""
        txtNombre.Text = ""
        lbxLista.Text = ""
        lbxLista.Items.Clear()
    End Sub


End Class
