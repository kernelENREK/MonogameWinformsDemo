Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework

Namespace ParticleEngine

    Public Class Particle
        Public Property Texture As Texture2D
        Public Property Position As Vector2
        Public Property Velocity As Vector2
        Public Property Angle As Single
        Public Property AngularVelocity As Single
        Public Property Color As Color
        Public Property Size As Single
        Public Property Life As Integer

        Public Sub New(_texture As Texture2D, _position As Vector2, _velocity As Vector2, _angle As Single, _angularVelocity As Single, _color As Color, _size As Single, _life As Integer)
            Texture = _texture
            Position = _position
            Velocity = _velocity
            Angle = _angle
            AngularVelocity = _angularVelocity
            Color = _color
            Size = _size
            Life = _life
        End Sub

        Public Sub Update()
            Life -= 1
            Position += Velocity
            Angle += AngularVelocity

            If (EngineSettings.Grows) Then
                Size += 0.075F
                'Else
                '    Size -= 0.075F
                '    If Size < 0 Then Size = 0
            End If

            Dim AlphaColor As Color = Color
            Dim alpByte As Int16 = Color.A

            If (alpByte - 10 > 0) Then
                AlphaColor.A -= Convert.ToByte(10)
            End If

            Color = AlphaColor
        End Sub

        Public Sub Draw(spriteBatch As SpriteBatch)
            Dim sourceRectangle As New Rectangle(0, 0, Texture.Width, Texture.Height)
            Dim origin As New Vector2(Convert.ToSingle(Texture.Width / 2), Convert.ToSingle(Texture.Height / 2))

            spriteBatch.Draw(Texture, Position, sourceRectangle, Color, Angle, origin, Size, SpriteEffects.None, 0.0F)
        End Sub
    End Class

End Namespace
