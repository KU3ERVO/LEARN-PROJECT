<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelPrincipal = New Panel()
        PanelMenu = New Panel()
        btnSalir = New Button()
        btnMaximizar = New Button()
        btnMinimizar = New Button()
        BtnRestaurar = New Button()
        MenuStrip1 = New MenuStrip()
        PanelPrincipal.SuspendLayout()
        PanelMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelPrincipal
        ' 
        PanelPrincipal.BackColor = SystemColors.ControlLight
        PanelPrincipal.BorderStyle = BorderStyle.Fixed3D
        PanelPrincipal.Controls.Add(BtnRestaurar)
        PanelPrincipal.Controls.Add(btnMinimizar)
        PanelPrincipal.Controls.Add(btnMaximizar)
        PanelPrincipal.Controls.Add(btnSalir)
        PanelPrincipal.Dock = DockStyle.Top
        PanelPrincipal.Location = New Point(0, 0)
        PanelPrincipal.Name = "PanelPrincipal"
        PanelPrincipal.Size = New Size(800, 45)
        PanelPrincipal.TabIndex = 0
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = SystemColors.ActiveCaptionText
        PanelMenu.Controls.Add(MenuStrip1)
        PanelMenu.Dock = DockStyle.Top
        PanelMenu.Location = New Point(0, 45)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(800, 44)
        PanelMenu.TabIndex = 1
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(767, 3)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(26, 23)
        btnSalir.TabIndex = 0
        btnSalir.Text = "X"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Location = New Point(736, 3)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(25, 23)
        btnMaximizar.TabIndex = 1
        btnMaximizar.Text = "🗖"
        btnMaximizar.UseVisualStyleBackColor = True
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Location = New Point(706, 3)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(24, 23)
        btnMinimizar.TabIndex = 2
        btnMinimizar.Text = "🗕"
        btnMinimizar.UseVisualStyleBackColor = True
        ' 
        ' BtnRestaurar
        ' 
        BtnRestaurar.Location = New Point(675, 3)
        BtnRestaurar.Name = "BtnRestaurar"
        BtnRestaurar.Size = New Size(25, 23)
        BtnRestaurar.TabIndex = 3
        BtnRestaurar.Text = "🗗"
        BtnRestaurar.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Location = New Point(20, 3)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(202, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(800, 450)
        Controls.Add(PanelMenu)
        Controls.Add(PanelPrincipal)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "EDITOR TEXTO"
        PanelPrincipal.ResumeLayout(False)
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents MenuStrip1 As MenuStrip

End Class
