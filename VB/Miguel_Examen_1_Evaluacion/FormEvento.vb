
Imports System.Text

Public Class FormEvento
    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llenar combos si están vacíos
        If cmbEvento.Items.Count = 0 Then
            cmbEvento.Items.AddRange(New String() {"Banquete", "Convención", "Evento", "Congreso"})
            cmbEvento.SelectedIndex = 0
        End If

        If cmbCocina.Items.Count = 0 Then
            cmbCocina.Items.AddRange(New String() {"Buffet", "Carta", "Pedir cita con el chef", "No precisa"})
            cmbCocina.SelectedIndex = 0
        End If
    End Sub


    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        Dim gNombre As String
        gNombre = txtNombre.Text.Trim()
        Dim gTFN As String
        gTFN = txtTFN.Text.Trim()
        Dim gFechaHora As Date
        gFechaHora = dtpFecha.Value
        Dim gTipoEvento As String
        gTipoEvento = If(cmbEvento.SelectedItem IsNot Nothing, cmbEvento.SelectedItem.ToString(), "")
        Dim gTipoCocina As String
        gTipoCocina = If(cmbCocina.SelectedItem IsNot Nothing, cmbCocina.SelectedItem.ToString(), "")

        ' switch para abrir form específico
        Select Case gTipoEvento
            Case "Banquete"
                Dim f As New BanqueteForm()
                f.Show()
                Me.Hide()
            Case "Congreso"
                Dim f As New CongresoForm()
                f.Show()
                Me.Hide()
            Case "Evento"
                Dim f As New EventoBasicoForm()
                f.Show()
                Me.Hide()
            Case "Convención"
                Dim f As New ConvencionForm()
                f.Show()
                Me.Hide()
            Case Else
                ' nada
        End Select

    End Sub
End Class