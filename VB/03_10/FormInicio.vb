
Public Class FormInicio

        Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            OcultarSubMenu()
        End Sub

        'Método para ocultar los submenús
        Private Sub OcultarSubMenu()
            PanelArchivo.Visible = False
            PanelGaleria.Visible = False
        End Sub

        'Método para mostrar/ocultar un submenú
        Private Sub MostrarSubMenu(submenu As Panel)
            'Como todos los submenús son paneles, creamos un parámetro de tipo Panel
            If submenu.Visible = False Then
                OcultarSubMenu()
                submenu.Visible = True
            Else
                submenu.Visible = False
            End If
        End Sub

        Private FormularioActual As Form = Nothing 'Variable para almacenar el formulario hijo actual

        'Método para abrir formularios hijos dentro del panel contenedor
        Private Sub AbrirFormulariosHijos(formularioHijo As Form)
            If FormularioActual IsNot Nothing Then
                FormularioActual.Close()
            End If

            FormularioActual = formularioHijo
            formularioHijo.TopLevel = False
            formularioHijo.FormBorderStyle = FormBorderStyle.None
            formularioHijo.Dock = DockStyle.Fill
        PanelHijo.Controls.Add(formularioHijo)
        PanelHijo.Tag = formularioHijo
        formularioHijo.BringToFront()
            formularioHijo.Show()
        End Sub

        'Botones del menú principal
        Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
            MostrarSubMenu(PanelArchivo)
        End Sub

        Private Sub btnGaleria_Click(sender As Object, e As EventArgs) Handles btnGaleria.Click
            MostrarSubMenu(PanelGaleria)
        End Sub

        'Botones del submenú Archivo
        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            AbrirFormulariosHijos(New FormBuscar)
            OcultarSubMenu()
        End Sub

        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            AbrirFormulariosHijos(New FormGuardar)
            OcultarSubMenu()
        End Sub

        Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
            AbrirFormulariosHijos(New FormImportar)
            OcultarSubMenu()
        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            OcultarSubMenu()
            Application.Exit() ' Se usa en lugar de End
        End Sub

    Private Sub btnFotos_Click(sender As Object, e As EventArgs) Handles btnFotos.Click
            OcultarSubMenu()
        End Sub

        Private Sub btnVideo_Click(sender As Object, e As EventArgs) Handles btnVideo.Click
            OcultarSubMenu()
        End Sub

    End Class



