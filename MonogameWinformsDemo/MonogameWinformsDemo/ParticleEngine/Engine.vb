Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework

Namespace ParticleEngine
    Public Class Engine
        Private random As Random
        Public Property EmitterLocation() As Vector2
        Private particles As List(Of Particle)
        Private textures As List(Of Texture2D)

        Public Sub New(textures As List(Of Texture2D), location As Vector2)
            EmitterLocation = location
            Me.textures = textures
            Me.particles = New List(Of Particle)
            random = New Random()
        End Sub

        Public Sub Update()
            Dim total As Integer = EngineSettings.InitialEmision

            For i As Integer = 0 To total - 1
                particles.Add(GenerateNewParticle())
            Next

            For i As Integer = 0 To particles.Count - 1
                particles(i).Update()
            Next

            particles.RemoveAll(Function(c) c.Life <= 0 And c.Color.A <= 10)
        End Sub

        Private Function GenerateNewParticle() As Particle
            Dim texture As Texture2D = textures(random.Next(textures.Count))
            Dim position As Vector2 = EmitterLocation
            Dim velocity As New Vector2(0.9F * Convert.ToSingle(random.NextDouble() * 2 - 1), 1.0F * Convert.ToSingle(random.NextDouble() * 2 - 1))
            Dim angle As Single = 0
            Dim angularVelocity As Single = 0.1F * Convert.ToSingle(random.NextDouble() * 2 - 1)

            Dim color As New Color(255, 255, 255)

            If (EngineSettings.Color) Then
                color = New Color(Convert.ToSingle(random.NextDouble()), Convert.ToSingle(random.NextDouble()), Convert.ToSingle(random.NextDouble()))
            End If

            Dim size As Single = Convert.ToSingle(random.NextDouble() + 0.55F)
            Dim life As Integer = EngineSettings.InitialLife + random.Next(40)

            Return New Particle(texture, position, velocity, angle, angularVelocity, color, size, life)
        End Function

        Public Sub Draw(spriteBatch As SpriteBatch)
            If (EngineSettings.BlendStateAdditive) Then
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Additive)
            Else
                spriteBatch.Begin()
            End If

            For index As Integer = 0 To particles.Count - 1
                particles(index).Draw(spriteBatch)
            Next

            spriteBatch.End()
        End Sub
    End Class

End Namespace
