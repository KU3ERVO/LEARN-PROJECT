Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Num1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Num2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Resultado.Click

    End Sub

    Private Sub MultiplyBtn_Click(sender As Object, e As EventArgs) Handles MultiBtn.Click
        ResulTxt.Text = Val(Num1Txt.Text) * Val(Num2Txt.Text)
    End Sub

    Private Sub DividirBtn_Click(sender As Object, e As EventArgs) Handles DiviBtn.Click
        ResulTxt.Text = Val(Num1Txt.Text) / Val(Num2Txt.Text)
    End Sub

    Private Sub SumarBtn_Click(sender As Object, e As EventArgs) Handles SumaBtn.Click
        ResulTxt.Text = Val(Num1Txt.Text) + Val(Num2Txt.Text)

    End Sub

    Private Sub LimpiarBtn_Click(sender As Object, e As EventArgs) Handles LimpiarBtn.Click
        Num1Txt.Clear()
        Num2Txt.Clear()
        ResulTxt.Clear()

    End Sub

    Private Sub RestarBtn_Click(sender As Object, e As EventArgs) Handles RestaBtn.Click
        ResulTxt.Text = Val(Num1Txt.Text) - Val(Num2Txt.Text)
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ResulTxt_TextChanged(sender As Object, e As EventArgs) Handles ResulTxt.TextChanged

    End Sub

    Private Sub Num1Txt_TextChanged(sender As Object, e As EventArgs) Handles Num1Txt.TextChanged

    End Sub

    Private Sub Num2Txt_TextChanged(sender As Object, e As EventArgs) Handles Num2Txt.TextChanged

    End Sub
End Class
