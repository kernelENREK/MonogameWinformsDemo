Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Media

Public Class FrmMain

#Region "Variables"

    Private GD As GraphicsDevice
    Private GC As MG_Content.GameContent

    Private _spriteBatch As SpriteBatch

    Private bg As Texture2D
    Private debugfont As SpriteFont
    Private bgMusic As Song
    Private myParticleEngine As ParticleEngine.Engine

    Private tSec As Integer = TimeOfDay.Second
    Private tTicks As Integer = 0
    Private _fps As Integer = 0

    Private IsRunning As Boolean = True

#End Region

    Public Sub New()

        InitializeComponent()

        AddHandler chkCircle.CheckedChanged, AddressOf ParticleTextureEmiter
        AddHandler chkStar.CheckedChanged, AddressOf ParticleTextureEmiter
        AddHandler chkDiamond.CheckedChanged, AddressOf ParticleTextureEmiter
        AddHandler chkExplosion.CheckedChanged, AddressOf ParticleTextureEmiter
        AddHandler chkFire.CheckedChanged, AddressOf ParticleTextureEmiter

    End Sub

#Region "Form Events (FormClosing / Load)"

    Private Sub FrmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        IsRunning = False
        UnloadContent()
        End
    End Sub

    Private Sub FrmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If (Not InitGFX(pbScreen)) Then
            IsRunning = False
            End
        End If

        GLoop()
    End Sub

#End Region

#Region "Initialization Monogame Stuff"

    Private Sub UnloadContent()
        bg.Dispose()
        bgMusic.Dispose()
    End Sub

    Private Function InitGFX(picBoxControl As PictureBox) As Boolean
        Dim bSuccess As Boolean = False

        Try
            Dim PP As New PresentationParameters
            PP.IsFullScreen = False
            PP.PresentationInterval = PresentInterval.Default
            PP.DeviceWindowHandle = picBoxControl.Handle
            PP.BackBufferWidth = picBoxControl.Width
            PP.BackBufferHeight = picBoxControl.Height
            PP.BackBufferFormat = SurfaceFormat.Color
            PP.DepthStencilFormat = DepthFormat.Depth24

            Dim GA As GraphicsAdapter = GraphicsAdapter.Adapters.Item(0)
            GD = New GraphicsDevice(GA, GraphicsProfile.Reach, PP)
            GC = New MG_Content.GameContent(GD)

            _spriteBatch = New SpriteBatch(GD)

            bg = GC.Content.Load(Of Texture2D)("background")
            debugfont = GC.Content.Load(Of SpriteFont)("debugFnt")

            Dim textures As New List(Of Texture2D)
            textures.Add(GC.Content.Load(Of Texture2D)("circle"))

            bgMusic = GC.Content.Load(Of Song)("SecondReality")
            MediaPlayer.Play(bgMusic)

            myParticleEngine = New ParticleEngine.Engine(textures, New Vector2(400, 240))

            bSuccess = True

        Catch ex As Exception
            bSuccess = False
            MessageBox.Show($"Graphics failed to initialize. Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return bSuccess
    End Function

#End Region

    Private Sub GLoop()

        Task.Run(Sub()
                     While IsRunning
                         myParticleEngine.EmitterLocation = New Vector2(pbScreenMouseCoord.X, pbScreenMouseCoord.Y)
                         myParticleEngine.Update()

                         Draw()
                         TickCounter()
                     End While
                 End Sub)

    End Sub

    Private Sub Draw()
        GD.Clear(Color.Black)

        _spriteBatch.Begin()
        If (chkBackground.Checked) Then
            _spriteBatch.Draw(bg, Vector2.Zero, Color.White)
        End If
        _spriteBatch.DrawString(debugfont, $"FPS: {_fps}", New Vector2(4, 4), Color.White)
        _spriteBatch.End()

        myParticleEngine.Draw(_spriteBatch)

        GD.Present()
    End Sub

    Private Sub TickCounter()
        If tSec = TimeOfDay.Second And IsRunning Then
            tTicks += 1
        Else
            _fps = tTicks
            tTicks = 1
            tSec = TimeOfDay.Second
        End If
    End Sub

    Private Sub ParticleTextureEmiter()
        Dim textures As New List(Of Texture2D)

        If (chkCircle.Checked) Then textures.Add(GC.Content.Load(Of Texture2D)("circle"))
        If (chkStar.Checked) Then textures.Add(GC.Content.Load(Of Texture2D)("star"))
        If (chkDiamond.Checked) Then textures.Add(GC.Content.Load(Of Texture2D)("diamond"))
        If (chkExplosion.Checked) Then textures.Add(GC.Content.Load(Of Texture2D)("explosion32"))
        If (chkFire.Checked) Then textures.Add(GC.Content.Load(Of Texture2D)("fire32"))

        If (textures.Count = 0) Then
            chkCircle.Checked = True
        Else
            myParticleEngine = New ParticleEngine.Engine(textures, New Vector2(400, 240))
        End If
    End Sub

    Private pbScreenMouseCoord As Point
    Private Sub pbScreen_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pbScreen.MouseMove
        Dim _tmpP As Point
        _tmpP.X = e.X
        _tmpP.Y = e.Y
        pbScreenMouseCoord = _tmpP
    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As System.EventArgs) Handles TrackBar1.ValueChanged
        ParticleEngine.EngineSettings.InitialEmision = TrackBar1.Value
        LblInitialEmision.Text = ParticleEngine.EngineSettings.InitialEmision.ToString
    End Sub

    Private Sub TrackBar2_ValueChanged(sender As Object, e As System.EventArgs) Handles TrackBar2.ValueChanged
        ParticleEngine.EngineSettings.InitialLife = TrackBar2.Value
        LblParticleLife.Text = ParticleEngine.EngineSettings.InitialLife.ToString
    End Sub

    Private Sub chkColor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkColor.CheckedChanged
        ParticleEngine.EngineSettings.Color = chkColor.Checked
    End Sub

    Private Sub chkBlendState_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkBlendState.CheckedChanged
        ParticleEngine.EngineSettings.BlendStateAdditive = chkBlendState.Checked
    End Sub

    Private Sub chkGrowsUp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGrowsUp.CheckedChanged
        ParticleEngine.EngineSettings.Grows = chkGrowsUp.Checked
    End Sub

End Class