Public Class Form1
    Private Sub btnMouseEnter_Enter(sender As Object, e As EventArgs) Handles btnMouseEnter.MouseEnter
        MsgBox("ENTER")
    End Sub
    Private Sub btnMouseUp_Up(sender As Object, e As EventArgs) Handles btnMouseUp.MouseUp
        btnMouseUp.BackColor = Color.Green
        btnMouseDown.BackColor = Color.Green
    End Sub
    Private Sub btnMouseMove_Leave(sender As Object, e As EventArgs) Handles btnMouseMove.MouseMove
        btnMouseMove.BackColor = Color.BlueViolet
    End Sub
    Private Sub btnMouseWheel_Wheel(sender As Object, e As EventArgs) Handles btnMouseWheel.MouseWheel
        btnMouseWheel.BackColor = Color.Yellow
    End Sub

    Private Sub btnHoverLeave_Hover(sender As Object, e As EventArgs) Handles btnHoverLeave.MouseHover
        btnHoverLeave.BackColor = Color.Red
    End Sub
    Private Sub btnHoverLeave_Leave(sender As Object, e As EventArgs) Handles btnHoverLeave.MouseLeave
        btnHoverLeave.BackColor = Color.Black
    End Sub
    Private Sub btnPressKey_PressedKey(sender As Object, e As EventArgs) Handles btnPressKey.KeyPress

        Select Case New Random().Next(1, 4)
            Case 1
                btnPressKey.BackColor = Color.Red
            Case 2
                btnPressKey.BackColor = Color.Yellow
            Case 3
                btnPressKey.BackColor = Color.BlueViolet
        End Select

    End Sub

    Private Sub btnMouseDown_Down(sender As Object, e As EventArgs) Handles btnMouseDown.MouseDown

        btnMouseDown.BackColor = Color.Blue
        btnMouseUp.BackColor = Color.Blue
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

