Public Class FinalForm

    Inherits Form

        Private bookings As System.Collections.Generic.List(Of String)

        Public Sub New(listOfLines As System.Collections.Generic.List(Of String))
            InitializeComponent()
            bookings = listOfLines
        End Sub

        Private Sub FinalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If dgvBookings.Columns.Count = 0 Then
                dgvBookings.Columns.Add("Tipo", "Tipo")
                dgvBookings.Columns.Add("Nombre", "Nombre")
                dgvBookings.Columns.Add("TFN", "TFN")
                dgvBookings.Columns.Add("FechaHora", "FechaHora")
                dgvBookings.Columns.Add("Asistentes", "Asistentes")
                dgvBookings.Columns.Add("Cocina", "Cocina")
                dgvBookings.Columns.Add("Detalle1", "Detalle1")
                dgvBookings.Columns.Add("Detalle2", "Detalle2")
            End If

            dgvBookings.Rows.Clear()

            For Each line As String In bookings
                If String.IsNullOrWhiteSpace(line) Then Continue For
                Dim parts = line.Split("|"c)
                Dim row(7) As String
                If parts.Length >= 11 Then
                    row(0) = parts(0)
                    row(1) = parts(1)
                    row(2) = parts(2)
                    row(3) = parts(3)
                    row(4) = parts(4)
                    row(5) = parts(5)
                    If parts(0) = "Banquete" Then
                        row(6) = "Mesa: " & parts(6)
                        row(7) = "Pers/mesa: " & parts(7)
                    ElseIf parts(0) = "Congreso" Then
                        row(6) = "Días: " & parts(8)
                        row(7) = "Hab.: " & parts(10)
                    Else
                        row(6) = ""
                        row(7) = ""
                    End If
                Else
                    For i As Integer = 0 To Math.Min(parts.Length - 1, 7)
                        row(i) = parts(i)
                    Next
                End If
                dgvBookings.Rows.Add(row)
            Next
        End Sub

        Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
            Me.Close()
        End Sub

    End Class