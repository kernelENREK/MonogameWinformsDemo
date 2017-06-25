<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.LblParticleLife = New System.Windows.Forms.Label()
        Me.LblInitialEmision = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.chkGrowsUp = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCircle = New System.Windows.Forms.CheckBox()
        Me.chkStar = New System.Windows.Forms.CheckBox()
        Me.chkDiamond = New System.Windows.Forms.CheckBox()
        Me.chkExplosion = New System.Windows.Forms.CheckBox()
        Me.chkFire = New System.Windows.Forms.CheckBox()
        Me.chkBlendState = New System.Windows.Forms.CheckBox()
        Me.chkColor = New System.Windows.Forms.CheckBox()
        Me.chkBackground = New System.Windows.Forms.CheckBox()
        Me.pbScreen = New System.Windows.Forms.PictureBox()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblParticleLife
        '
        Me.LblParticleLife.AutoSize = True
        Me.LblParticleLife.Location = New System.Drawing.Point(902, 427)
        Me.LblParticleLife.Name = "LblParticleLife"
        Me.LblParticleLife.Size = New System.Drawing.Size(19, 13)
        Me.LblParticleLife.TabIndex = 39
        Me.LblParticleLife.Text = "20"
        '
        'LblInitialEmision
        '
        Me.LblInitialEmision.AutoSize = True
        Me.LblInitialEmision.Location = New System.Drawing.Point(902, 363)
        Me.LblInitialEmision.Name = "LblInitialEmision"
        Me.LblInitialEmision.Size = New System.Drawing.Size(19, 13)
        Me.LblInitialEmision.TabIndex = 38
        Me.LblInitialEmision.Text = "10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(820, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Particle Life:"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(815, 443)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(180, 45)
        Me.TrackBar2.TabIndex = 36
        Me.TrackBar2.Value = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(820, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Initial Emision"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(815, 379)
        Me.TrackBar1.Maximum = 40
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(180, 45)
        Me.TrackBar1.TabIndex = 34
        Me.TrackBar1.Value = 10
        '
        'chkGrowsUp
        '
        Me.chkGrowsUp.AutoSize = True
        Me.chkGrowsUp.Location = New System.Drawing.Point(833, 260)
        Me.chkGrowsUp.Name = "chkGrowsUp"
        Me.chkGrowsUp.Size = New System.Drawing.Size(71, 17)
        Me.chkGrowsUp.TabIndex = 33
        Me.chkGrowsUp.Text = "Grows up"
        Me.chkGrowsUp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCircle)
        Me.GroupBox1.Controls.Add(Me.chkStar)
        Me.GroupBox1.Controls.Add(Me.chkDiamond)
        Me.GroupBox1.Controls.Add(Me.chkExplosion)
        Me.GroupBox1.Controls.Add(Me.chkFire)
        Me.GroupBox1.Location = New System.Drawing.Point(823, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 166)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Particles"
        '
        'chkCircle
        '
        Me.chkCircle.AutoSize = True
        Me.chkCircle.Checked = True
        Me.chkCircle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCircle.Location = New System.Drawing.Point(10, 19)
        Me.chkCircle.Name = "chkCircle"
        Me.chkCircle.Size = New System.Drawing.Size(52, 17)
        Me.chkCircle.TabIndex = 2
        Me.chkCircle.Text = "Circle"
        Me.chkCircle.UseVisualStyleBackColor = True
        '
        'chkStar
        '
        Me.chkStar.AutoSize = True
        Me.chkStar.Location = New System.Drawing.Point(10, 42)
        Me.chkStar.Name = "chkStar"
        Me.chkStar.Size = New System.Drawing.Size(45, 17)
        Me.chkStar.TabIndex = 3
        Me.chkStar.Text = "Star"
        Me.chkStar.UseVisualStyleBackColor = True
        '
        'chkDiamond
        '
        Me.chkDiamond.AutoSize = True
        Me.chkDiamond.Location = New System.Drawing.Point(10, 65)
        Me.chkDiamond.Name = "chkDiamond"
        Me.chkDiamond.Size = New System.Drawing.Size(68, 17)
        Me.chkDiamond.TabIndex = 4
        Me.chkDiamond.Text = "Diamond"
        Me.chkDiamond.UseVisualStyleBackColor = True
        '
        'chkExplosion
        '
        Me.chkExplosion.AutoSize = True
        Me.chkExplosion.Location = New System.Drawing.Point(10, 88)
        Me.chkExplosion.Name = "chkExplosion"
        Me.chkExplosion.Size = New System.Drawing.Size(71, 17)
        Me.chkExplosion.TabIndex = 5
        Me.chkExplosion.Text = "Explosion"
        Me.chkExplosion.UseVisualStyleBackColor = True
        '
        'chkFire
        '
        Me.chkFire.AutoSize = True
        Me.chkFire.Location = New System.Drawing.Point(10, 111)
        Me.chkFire.Name = "chkFire"
        Me.chkFire.Size = New System.Drawing.Size(43, 17)
        Me.chkFire.TabIndex = 6
        Me.chkFire.Text = "Fire"
        Me.chkFire.UseVisualStyleBackColor = True
        '
        'chkBlendState
        '
        Me.chkBlendState.AutoSize = True
        Me.chkBlendState.Location = New System.Drawing.Point(833, 306)
        Me.chkBlendState.Name = "chkBlendState"
        Me.chkBlendState.Size = New System.Drawing.Size(119, 17)
        Me.chkBlendState.TabIndex = 31
        Me.chkBlendState.Text = "BlendState.Additive"
        Me.chkBlendState.UseVisualStyleBackColor = True
        '
        'chkColor
        '
        Me.chkColor.AutoSize = True
        Me.chkColor.Checked = True
        Me.chkColor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColor.Location = New System.Drawing.Point(833, 283)
        Me.chkColor.Name = "chkColor"
        Me.chkColor.Size = New System.Drawing.Size(50, 17)
        Me.chkColor.TabIndex = 30
        Me.chkColor.Text = "Color"
        Me.chkColor.UseVisualStyleBackColor = True
        '
        'chkBackground
        '
        Me.chkBackground.AutoSize = True
        Me.chkBackground.Location = New System.Drawing.Point(833, 12)
        Me.chkBackground.Name = "chkBackground"
        Me.chkBackground.Size = New System.Drawing.Size(147, 17)
        Me.chkBackground.TabIndex = 29
        Me.chkBackground.Text = "Show BackGround image"
        Me.chkBackground.UseVisualStyleBackColor = True
        '
        'pbScreen
        '
        Me.pbScreen.Location = New System.Drawing.Point(2, 2)
        Me.pbScreen.Name = "pbScreen"
        Me.pbScreen.Size = New System.Drawing.Size(800, 600)
        Me.pbScreen.TabIndex = 28
        Me.pbScreen.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 608)
        Me.Controls.Add(Me.LblParticleLife)
        Me.Controls.Add(Me.LblInitialEmision)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.chkGrowsUp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkBlendState)
        Me.Controls.Add(Me.chkColor)
        Me.Controls.Add(Me.chkBackground)
        Me.Controls.Add(Me.pbScreen)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monogame inside standard WinForms PictureBox control"
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblParticleLife As Label
    Friend WithEvents LblInitialEmision As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents chkGrowsUp As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCircle As CheckBox
    Friend WithEvents chkStar As CheckBox
    Friend WithEvents chkDiamond As CheckBox
    Friend WithEvents chkExplosion As CheckBox
    Friend WithEvents chkFire As CheckBox
    Friend WithEvents chkBlendState As CheckBox
    Friend WithEvents chkColor As CheckBox
    Friend WithEvents chkBackground As CheckBox
    Friend WithEvents pbScreen As PictureBox
End Class
