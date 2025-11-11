<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicio))
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelGaleria = New System.Windows.Forms.Panel()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.btnFotos = New System.Windows.Forms.Button()
        Me.btnGaleria = New System.Windows.Forms.Button()
        Me.PanelArchivo = New System.Windows.Forms.Panel()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnArchivo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelHijo = New System.Windows.Forms.Panel()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelGaleria.SuspendLayout()
        Me.PanelArchivo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHijo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelPrincipal.Controls.Add(Me.btnSalir)
        Me.PanelPrincipal.Controls.Add(Me.PanelGaleria)
        Me.PanelPrincipal.Controls.Add(Me.btnGaleria)
        Me.PanelPrincipal.Controls.Add(Me.PanelArchivo)
        Me.PanelPrincipal.Controls.Add(Me.btnArchivo)
        Me.PanelPrincipal.Controls.Add(Me.Panel2)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(165, 448)
        Me.PanelPrincipal.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Lime
        Me.btnSalir.Location = New System.Drawing.Point(0, 403)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(15, 0, 35, 0)
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalir.Size = New System.Drawing.Size(165, 45)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PanelGaleria
        '
        Me.PanelGaleria.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelGaleria.Controls.Add(Me.btnVideo)
        Me.PanelGaleria.Controls.Add(Me.btnFotos)
        Me.PanelGaleria.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelGaleria.Location = New System.Drawing.Point(0, 315)
        Me.PanelGaleria.Name = "PanelGaleria"
        Me.PanelGaleria.Size = New System.Drawing.Size(165, 88)
        Me.PanelGaleria.TabIndex = 11
        '
        'btnVideo
        '
        Me.btnVideo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVideo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVideo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVideo.Location = New System.Drawing.Point(0, 44)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Padding = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.btnVideo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVideo.Size = New System.Drawing.Size(165, 44)
        Me.btnVideo.TabIndex = 10
        Me.btnVideo.Text = "Videos"
        Me.btnVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVideo.UseVisualStyleBackColor = False
        '
        'btnFotos
        '
        Me.btnFotos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFotos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFotos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFotos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFotos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFotos.Location = New System.Drawing.Point(0, 0)
        Me.btnFotos.Name = "btnFotos"
        Me.btnFotos.Padding = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.btnFotos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFotos.Size = New System.Drawing.Size(165, 44)
        Me.btnFotos.TabIndex = 9
        Me.btnFotos.Text = "Fotos"
        Me.btnFotos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFotos.UseVisualStyleBackColor = False
        '
        'btnGaleria
        '
        Me.btnGaleria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGaleria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGaleria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGaleria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGaleria.ForeColor = System.Drawing.Color.Lime
        Me.btnGaleria.Location = New System.Drawing.Point(0, 273)
        Me.btnGaleria.Name = "btnGaleria"
        Me.btnGaleria.Padding = New System.Windows.Forms.Padding(15, 0, 35, 0)
        Me.btnGaleria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGaleria.Size = New System.Drawing.Size(165, 42)
        Me.btnGaleria.TabIndex = 10
        Me.btnGaleria.Text = "Galería"
        Me.btnGaleria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGaleria.UseVisualStyleBackColor = False
        '
        'PanelArchivo
        '
        Me.PanelArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelArchivo.Controls.Add(Me.btnImportar)
        Me.PanelArchivo.Controls.Add(Me.btnGuardar)
        Me.PanelArchivo.Controls.Add(Me.btnBuscar)
        Me.PanelArchivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelArchivo.Location = New System.Drawing.Point(0, 141)
        Me.PanelArchivo.Name = "PanelArchivo"
        Me.PanelArchivo.Size = New System.Drawing.Size(165, 132)
        Me.PanelArchivo.TabIndex = 2
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImportar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImportar.Location = New System.Drawing.Point(0, 88)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Padding = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.btnImportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnImportar.Size = New System.Drawing.Size(165, 44)
        Me.btnImportar.TabIndex = 4
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(0, 44)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGuardar.Size = New System.Drawing.Size(165, 44)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(0, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBuscar.Size = New System.Drawing.Size(165, 44)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnArchivo
        '
        Me.btnArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnArchivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArchivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivo.ForeColor = System.Drawing.Color.Lime
        Me.btnArchivo.Location = New System.Drawing.Point(0, 99)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Padding = New System.Windows.Forms.Padding(15, 0, 35, 0)
        Me.btnArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnArchivo.Size = New System.Drawing.Size(165, 42)
        Me.btnArchivo.TabIndex = 1
        Me.btnArchivo.Text = "Archivo"
        Me.btnArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArchivo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 99)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._03_10.My.Resources.Resources.Spotify_icon_svg
        Me.PictureBox1.Location = New System.Drawing.Point(30, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.AxWindowsMediaPlayer)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(165, 403)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(746, 45)
        Me.Panel3.TabIndex = 1
        '
        'AxWindowsMediaPlayer
        '
        Me.AxWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AxWindowsMediaPlayer.Enabled = True
        Me.AxWindowsMediaPlayer.Location = New System.Drawing.Point(0, -14)
        Me.AxWindowsMediaPlayer.Name = "AxWindowsMediaPlayer"
        Me.AxWindowsMediaPlayer.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer.Size = New System.Drawing.Size(746, 59)
        Me.AxWindowsMediaPlayer.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global._03_10.My.Resources.Resources.logobombom
        Me.PictureBox2.Location = New System.Drawing.Point(306, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 173)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PanelHijo
        '
        Me.PanelHijo.Controls.Add(Me.PictureBox2)
        Me.PanelHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHijo.Location = New System.Drawing.Point(165, 0)
        Me.PanelHijo.Name = "PanelHijo"
        Me.PanelHijo.Size = New System.Drawing.Size(746, 403)
        Me.PanelHijo.TabIndex = 4
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(911, 448)
        Me.Controls.Add(Me.PanelHijo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.MaximumSize = New System.Drawing.Size(927, 487)
        Me.MinimumSize = New System.Drawing.Size(927, 487)
        Me.Name = "FormInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPRODUCTOR"
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelGaleria.ResumeLayout(False)
        Me.PanelArchivo.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHijo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents btnArchivo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelArchivo As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnImportar As Button
    Friend WithEvents AxWindowsMediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelGaleria As Panel
    Friend WithEvents btnVideo As Button
    Friend WithEvents btnFotos As Button
    Friend WithEvents btnGaleria As Button
    Friend WithEvents PanelHijo As Panel
End Class
