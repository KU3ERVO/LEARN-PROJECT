Public Class Form1

    Private angulo As Double = 0
    Private radioOrbita As Integer = 150
    Private centroX As Integer
    Private centroY As Integer
    Private listaPlanets As List(Of PictureBox)
    Private cambio As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        centroX = btnMover.Left + btnMover.Width \ 2
        centroY = btnMover.Top + btnMover.Height \ 2

        listaPlanets = New List(Of PictureBox) From {
            pbxGalaxia1, pbxTierra1, pbxJupiter1, pbxLuna1,
            pbxTierra2, pbxGalaxia2, pbxLuna2, pbxJupiter2
        }


        Timer.Interval = 50 ' 

    End Sub


    Private Sub btnMover_Hover(sender As Object, e As EventArgs) Handles btnMover.MouseHover

        btnMover.BackColor = Color.DarkRed
        Timer.Start()

    End Sub

    Private Sub btnMover_HoverLeave(sender As Object, e As EventArgs) Handles btnMover.MouseLeave

        btnMover.BackColor = Color.Transparent
        Timer.Stop()

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        angulo += 0.1

        If cambio = True Then
            radioOrbita -= 1
            If radioOrbita <= 150 Then
                cambio = False
            End If
        Else
            radioOrbita += 1
            If radioOrbita >= 200 Then
                cambio = True
            End If
        End If


        Dim angleStep As Double = (2 * Math.PI) / listaPlanets.Count

        For i As Integer = 0 To listaPlanets.Count - 1
            Dim anguloActual As Double = angulo + (i * angleStep)

            Dim x As Integer = centroX + radioOrbita * Math.Cos(anguloActual) - listaPlanets(i).Width \ 2
            Dim y As Integer = centroY + radioOrbita * Math.Sin(anguloActual) - listaPlanets(i).Height \ 2

            listaPlanets(i).Left = x
            listaPlanets(i).Top = y
        Next
    End Sub

End Class
