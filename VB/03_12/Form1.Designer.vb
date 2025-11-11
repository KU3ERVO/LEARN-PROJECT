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
        components = New ComponentModel.Container()
        btnMover = New Button()
        Timer = New Timer(components)
        pbxTierra1 = New PictureBox()
        pbxLuna1 = New PictureBox()
        pbxJupiter2 = New PictureBox()
        pbxGalaxia2 = New PictureBox()
        pbxGalaxia1 = New PictureBox()
        pbxJupiter1 = New PictureBox()
        pbxLuna2 = New PictureBox()
        pbxTierra2 = New PictureBox()
        CType(pbxTierra1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxLuna1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxJupiter2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxGalaxia2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxGalaxia1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxJupiter1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxLuna2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxTierra2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnMover
        ' 
        btnMover.FlatStyle = FlatStyle.Flat
        btnMover.Font = New Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMover.Location = New Point(196, 179)
        btnMover.Name = "btnMover"
        btnMover.Size = New Size(100, 100)
        btnMover.TabIndex = 0
        btnMover.Text = "HOVER"
        btnMover.UseVisualStyleBackColor = True
        ' 
        ' Timer
        ' 
        ' 
        ' pbxTierra1
        ' 
        pbxTierra1.Image = My.Resources.Resources.plan1
        pbxTierra1.Location = New Point(196, 12)
        pbxTierra1.Name = "pbxTierra1"
        pbxTierra1.Size = New Size(100, 98)
        pbxTierra1.SizeMode = PictureBoxSizeMode.Zoom
        pbxTierra1.TabIndex = 1
        pbxTierra1.TabStop = False
        ' 
        ' pbxLuna1
        ' 
        pbxLuna1.Image = My.Resources.Resources.plan3
        pbxLuna1.Location = New Point(372, 181)
        pbxLuna1.Name = "pbxLuna1"
        pbxLuna1.Size = New Size(100, 98)
        pbxLuna1.SizeMode = PictureBoxSizeMode.Zoom
        pbxLuna1.TabIndex = 2
        pbxLuna1.TabStop = False
        ' 
        ' pbxJupiter2
        ' 
        pbxJupiter2.Image = My.Resources.Resources.plan21
        pbxJupiter2.Location = New Point(12, 179)
        pbxJupiter2.Name = "pbxJupiter2"
        pbxJupiter2.Size = New Size(100, 98)
        pbxJupiter2.SizeMode = PictureBoxSizeMode.Zoom
        pbxJupiter2.TabIndex = 3
        pbxJupiter2.TabStop = False
        ' 
        ' pbxGalaxia2
        ' 
        pbxGalaxia2.Image = My.Resources.Resources.galaxy1
        pbxGalaxia2.Location = New Point(196, 351)
        pbxGalaxia2.Name = "pbxGalaxia2"
        pbxGalaxia2.Size = New Size(100, 98)
        pbxGalaxia2.TabIndex = 4
        pbxGalaxia2.TabStop = False
        ' 
        ' pbxGalaxia1
        ' 
        pbxGalaxia1.Image = My.Resources.Resources.galaxy
        pbxGalaxia1.Location = New Point(12, 12)
        pbxGalaxia1.Name = "pbxGalaxia1"
        pbxGalaxia1.Size = New Size(100, 98)
        pbxGalaxia1.TabIndex = 5
        pbxGalaxia1.TabStop = False
        ' 
        ' pbxJupiter1
        ' 
        pbxJupiter1.Image = My.Resources.Resources.plan2
        pbxJupiter1.Location = New Point(372, 12)
        pbxJupiter1.Name = "pbxJupiter1"
        pbxJupiter1.Size = New Size(100, 98)
        pbxJupiter1.SizeMode = PictureBoxSizeMode.Zoom
        pbxJupiter1.TabIndex = 6
        pbxJupiter1.TabStop = False
        ' 
        ' pbxLuna2
        ' 
        pbxLuna2.Image = My.Resources.Resources.plan31
        pbxLuna2.Location = New Point(12, 351)
        pbxLuna2.Name = "pbxLuna2"
        pbxLuna2.Size = New Size(100, 98)
        pbxLuna2.SizeMode = PictureBoxSizeMode.Zoom
        pbxLuna2.TabIndex = 7
        pbxLuna2.TabStop = False
        ' 
        ' pbxTierra2
        ' 
        pbxTierra2.Image = My.Resources.Resources.plan11
        pbxTierra2.Location = New Point(372, 351)
        pbxTierra2.Name = "pbxTierra2"
        pbxTierra2.Size = New Size(100, 98)
        pbxTierra2.SizeMode = PictureBoxSizeMode.Zoom
        pbxTierra2.TabIndex = 8
        pbxTierra2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 461)
        Controls.Add(pbxTierra2)
        Controls.Add(pbxLuna2)
        Controls.Add(pbxJupiter1)
        Controls.Add(pbxGalaxia1)
        Controls.Add(pbxGalaxia2)
        Controls.Add(pbxJupiter2)
        Controls.Add(pbxLuna1)
        Controls.Add(pbxTierra1)
        Controls.Add(btnMover)
        MaximumSize = New Size(500, 500)
        MinimumSize = New Size(500, 500)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(pbxTierra1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxLuna1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxJupiter2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxGalaxia2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxGalaxia1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxJupiter1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxLuna2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxTierra2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMover As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents pbxTierra1 As PictureBox
    Friend WithEvents pbxLuna1 As PictureBox
    Friend WithEvents pbxJupiter2 As PictureBox
    Friend WithEvents pbxGalaxia2 As PictureBox
    Friend WithEvents pbxGalaxia1 As PictureBox
    Friend WithEvents pbxJupiter1 As PictureBox
    Friend WithEvents pbxLuna2 As PictureBox
    Friend WithEvents pbxTierra2 As PictureBox

End Class
