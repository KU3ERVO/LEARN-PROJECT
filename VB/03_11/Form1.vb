Imports System.IO

Public Class Form1


    ' Variables globales (se usan sólo temporalmente en los handlers)
    Dim nombre, dni, telefono, direccion, sexo As String
        Dim validadosCampos, dniValidado As Boolean
        Dim filaActual As Integer

        ' Ruta del fichero de datos; lo ponemos en la carpeta de la aplicación
        Private ReadOnly datosPath As String = Path.Combine(Application.StartupPath, "datos.txt")

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Inicializaciones de controles (por si no se configuran en diseñador)
            With dgvDatos
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
            End With

        ' Rellenar ComboBox sexo si no está hecho en diseñador
        If cbxSexo.Items.Count = 0 Then
            cbxSexo.Items.AddRange(New String() {"Masculino", "Femenino", "Otro"})
        End If

        ' Carga datos desde fichero al grid
        CargarDatosDesdeFichero()
            ActivarBotones()
        End Sub

        Private Sub CargarDatosDesdeFichero()
            dgvDatos.Rows.Clear()
            Try
                If File.Exists(datosPath) Then
                    Using sr As New StreamReader(datosPath)
                        While Not sr.EndOfStream
                            Dim linea As String = sr.ReadLine()
                            If String.IsNullOrWhiteSpace(linea) Then Continue While
                            Dim dato As String() = linea.Split(";"c)
                            ' Asegurar al menos 5 elementos (si hay ; final puede traer uno vacío)
                            If dato.Length >= 5 Then
                                dgvDatos.Rows.Add(dato(0), dato(1), dato(2), dato(3), dato(4))
                            End If
                        End While
                    End Using
                Else
                    ' Si no existe, crearlo vacío para evitar errores al guardar más adelante
                    Using fs As FileStream = File.Create(datosPath)
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
            nombre = txtNombre.Text.Trim()
            dni = txtDni.Text.Trim()
            telefono = txtTelefono.Text.Trim()
            direccion = txtDireccion.Text.Trim()
        sexo = cbxSexo.Text.Trim()

        validadosCampos = validarCampos(nombre, dni, telefono, direccion, sexo)

            If validadosCampos Then
                dniValidado = validarDNI(dni, -1) ' -1 indica que es creación (no excluir ninguna fila)
                If dniValidado Then
                    dgvDatos.Rows.Add(nombre, dni, telefono, direccion, sexo)
                    MessageBox.Show("Se agregó el nuevo contacto correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                End If
            End If
        End Sub

        Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
            If e.RowIndex < 0 Then Return
            filaActual = e.RowIndex
            txtNombre.Text = Convert.ToString(dgvDatos.Rows(filaActual).Cells("ColumnNombre").Value)
            txtDni.Text = Convert.ToString(dgvDatos.Rows(filaActual).Cells("ColumnDni").Value)
            txtTelefono.Text = Convert.ToString(dgvDatos.Rows(filaActual).Cells("ColumnTelefono").Value)
            txtDireccion.Text = Convert.ToString(dgvDatos.Rows(filaActual).Cells("ColumnDireccion").Value)
        cbxSexo.Text = Convert.ToString(dgvDatos.Rows(filaActual).Cells("ColumnSexo").Value)
        DesactivarBotones()
        End Sub

        Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
            If dgvDatos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione una fila para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            nombre = txtNombre.Text.Trim()
            dni = txtDni.Text.Trim()
            telefono = txtTelefono.Text.Trim()
            direccion = txtDireccion.Text.Trim()
        sexo = cbxSexo.Text.Trim()

        validadosCampos = validarCampos(nombre, dni, telefono, direccion, sexo)
            filaActual = dgvDatos.CurrentRow.Index

            If validadosCampos Then
                ' Si el DNI ha cambiado, validar que no exista en otra fila
                If dni <> Convert.ToString(dgvDatos.Rows(filaActual).Cells("ColumnDni").Value) Then
                    dniValidado = validarDNI(dni, filaActual)
                Else
                    dniValidado = True
                End If

                If dniValidado Then
                    dgvDatos.Rows(filaActual).Cells("ColumnNombre").Value = nombre
                    dgvDatos.Rows(filaActual).Cells("ColumnDni").Value = dni
                    dgvDatos.Rows(filaActual).Cells("ColumnTelefono").Value = telefono
                    dgvDatos.Rows(filaActual).Cells("ColumnDireccion").Value = direccion
                    dgvDatos.Rows(filaActual).Cells("ColumnSexo").Value = sexo
                    MessageBox.Show("El contacto se ha modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ActivarBotones()
                    limpiar()
                End If
            End If
        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            If dgvDatos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione una fila para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim respuesta = MessageBox.Show("¿Estás seguro/a que deseas eliminar este contacto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                filaActual = dgvDatos.CurrentRow.Index
                dgvDatos.Rows.RemoveAt(filaActual)
                MessageBox.Show("El contacto se ha eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ActivarBotones()
                limpiar()
            End If
        End Sub

        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            GuardarDatos()
        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        ' Validación de campos
        Function validarCampos(parnombre As String, pardni As String, partelefono As String, pardireccion As String, parsexo As String) As Boolean
            If String.IsNullOrWhiteSpace(parnombre) Then
                MessageBox.Show("Debe introducir un nombre para el contacto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ErrorProvider1.SetError(txtNombre, "Introduzca un nombre para el contacto")
                Return False
            End If

            If String.IsNullOrWhiteSpace(pardni) Then
                MessageBox.Show("Debe introducir un dni para el contacto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ErrorProvider1.SetError(txtDni, "Introduzca un dni para el contacto")
                Return False
            End If

            If String.IsNullOrWhiteSpace(partelefono) Then
                MessageBox.Show("Debe introducir un teléfono para el contacto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ErrorProvider1.SetError(txtTelefono, "Introduzca un teléfono para el contacto")
                Return False
            End If

            If String.IsNullOrWhiteSpace(pardireccion) Then
                MessageBox.Show("Debe introducir una dirección para el contacto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ErrorProvider1.SetError(txtDireccion, "Introduzca una dirección para el contacto")
                Return False
            End If

            If String.IsNullOrWhiteSpace(parsexo) Then
                MessageBox.Show("Debe introducir un sexo para el contacto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ErrorProvider1.SetError(cbxSexo, "Introduzca un sexo para el contacto")
            Return False
            End If

            ' Si todo OK, limpiar errores y retornar true
            ErrorProvider1.SetError(txtNombre, "")
            ErrorProvider1.SetError(txtDni, "")
            ErrorProvider1.SetError(txtTelefono, "")
            ErrorProvider1.SetError(txtDireccion, "")
        ErrorProvider1.SetError(cbxSexo, "")
        Return True
        End Function

        ' Validar que el DNI no esté repetido. excludeRowIndex indica una fila a ignorar (al modificar)
        Function validarDNI(parDNI As String, excludeRowIndex As Integer) As Boolean
            For i As Integer = 0 To dgvDatos.RowCount - 1
                If i = excludeRowIndex Then Continue For
                Dim cellVal = Convert.ToString(dgvDatos.Rows(i).Cells("ColumnDni").Value)
                If String.Equals(parDNI, cellVal, StringComparison.OrdinalIgnoreCase) Then
                    MessageBox.Show("Ya existe un usuario con el DNI introducido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ErrorProvider1.SetError(txtDni, "Ingrese otro DNI")
                    Return False
                End If
            Next
            ErrorProvider1.SetError(txtDni, "")
            Return True
        End Function

        Private Sub limpiar()
            txtNombre.Clear()
            txtDni.Clear()
            txtTelefono.Clear()
            txtDireccion.Clear()
        cbxSexo.SelectedIndex = -1
    End Sub

        Private Sub DesactivarBotones()
            btnAgregar.Enabled = False
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End Sub

        Private Sub ActivarBotones()
            btnAgregar.Enabled = True
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End Sub

        Private Sub GuardarDatos()
            Try
                Using sw As New StreamWriter(datosPath, False)
                    For Each row As DataGridViewRow In dgvDatos.Rows
                        ' Omitir filas nuevas/vacías
                        If row.IsNewRow Then Continue For
                        Dim linea As String = String.Format("{0};{1};{2};{3};{4};",
                                                      Convert.ToString(row.Cells("ColumnNombre").Value),
                                                      Convert.ToString(row.Cells("ColumnDni").Value),
                                                      Convert.ToString(row.Cells("ColumnTelefono").Value),
                                                      Convert.ToString(row.Cells("ColumnDireccion").Value),
                                                      Convert.ToString(row.Cells("ColumnSexo").Value))
                        sw.WriteLine(linea)
                    Next
                End Using
                MessageBox.Show("Los datos se han guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al guardar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub



End Class
