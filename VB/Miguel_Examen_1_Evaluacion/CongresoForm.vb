Public Class CongresoForm


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

        Private Sub CongresoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FindParentIfNeeded()

            If Me.Controls.ContainsKey("nudHabitaciones") AndAlso Me.Controls.ContainsKey("chkHabitaciones") Then
                CType(Me.Controls("nudHabitaciones"), NumericUpDown).Enabled = CType(Me.Controls("chkHabitaciones"), CheckBox).Checked
            End If
        End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        FindParentIfNeeded()

        Dim nombre As String = If(parentRef IsNot Nothing, parentRef.txtNombre.Text.Trim(), "")
        Dim tfn As String = If(parentRef IsNot Nothing, parentRef.txtTFN.Text.Trim(), "")
        Dim fecha As Date = If(parentRef IsNot Nothing, parentRef.dtpFecha.Value, Date.Now)

        Dim cocina As String = If(parentRef IsNot Nothing AndAlso parentRef.cmbCocina.SelectedItem IsNot Nothing, parentRef.cmbCocina.SelectedItem.ToString(), "")

        Dim dias As Integer = 0
        If Me.Controls.ContainsKey("nudDias") Then dias = CInt(CType(Me.Controls("nudDias"), NumericUpDown).Value)
        Dim necesita As Boolean = False
        If Me.Controls.ContainsKey("chkHabitaciones") Then necesita = CType(Me.Controls("chkHabitaciones"), CheckBox).Checked
        Dim numHabs As Integer = 0
        If necesita AndAlso Me.Controls.ContainsKey("nudHabitaciones") Then numHabs = CInt(CType(Me.Controls("nudHabitaciones"), NumericUpDown).Value)


    End Sub



End Class