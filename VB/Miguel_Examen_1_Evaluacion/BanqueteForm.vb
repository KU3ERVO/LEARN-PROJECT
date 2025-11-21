Public Class BanqueteForm



    Private parentRef As FormEvento = Nothing

    Public Sub New()
        InitializeComponent()
        FindParentIfNeeded()
    End Sub

    Public Sub New(parentForm As FormEvento)
        InitializeComponent()
        parentRef = parentForm
    End Sub

    Private Sub FindParentIfNeeded()
        If parentRef IsNot Nothing Then Return
        For Each f As Form In Application.OpenForms
            If TypeOf f Is FormEvento Then
                parentRef = CType(f, FormEvento)
                Exit For
            End If
        Next
    End Sub

    Private Sub BanqueteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindParentIfNeeded()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        FindParentIfNeeded()

        Dim nombre As String = If(parentRef IsNot Nothing, parentRef.txtNombre.Text.Trim(), "")
        Dim tfn As String = If(parentRef IsNot Nothing, parentRef.txtTFN.Text.Trim(), "")
        Dim fecha As Date = If(parentRef IsNot Nothing, parentRef.dtpFecha.Value, Date.Now)
        Dim cocina As String = If(parentRef IsNot Nothing AndAlso parentRef.cmbCocina.SelectedItem IsNot Nothing, parentRef.cmbCocina.SelectedItem.ToString(), "")

        Dim mesaForma As String = ""
        If Me.Controls.ContainsKey("rdoCuadrada") AndAlso CType(Me.Controls("rdoCuadrada"), RadioButton).Checked Then mesaForma = "Cuadrada"
        If Me.Controls.ContainsKey("rdoCircular") AndAlso CType(Me.Controls("rdoCircular"), RadioButton).Checked Then mesaForma = "Circular"
        Dim persPorMesa As Integer = 0
        If Me.Controls.ContainsKey("nudPersPorMesa") Then persPorMesa = CInt(CType(Me.Controls("nudPersPorMesa"), NumericUpDown).Value)

        Dim parts As String() = {
        "Banquete",
        nombre,
        tfn,
        fecha.ToString("s"),
        cocina,
        mesaForma,
        persPorMesa.ToString(),
        "0", "False", "0"
    }
        Dim line As String = String.Join("|", parts)

        ' Crear lista minimalista con esta reserva y abrir FinalForm
        Dim list As New System.Collections.Generic.List(Of String) From {line}
        Dim finalF As New FinalForm(list)
        finalF.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub


End Class