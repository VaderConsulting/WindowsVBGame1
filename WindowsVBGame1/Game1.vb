#Region " Imports "

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Audio
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.GamerServices
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.Media
Imports Microsoft.Xna.Framework.Net
Imports Microsoft.Xna.Framework.Storage

#End Region

Namespace WindowsGame1
    ''' <summary>
    ''' This is the main type for your game
    ''' </summary>
    Public Class Game1
        Inherits Microsoft.Xna.Framework.Game
        Private Graphics As GraphicsDeviceManager
        Private SpriteBatch As SpriteBatch

        Public Sub New()
            Graphics = New GraphicsDeviceManager(Me)
            Content.RootDirectory = "Content"
        End Sub

        ''' <summary>
        ''' Allows the game to perform any initialization it needs to before starting to run.
        ''' This is where it can query for any required services and load any non-graphic
        ''' related content. Calling base.Initialize will enumerate through any components
        ''' and initialize them as well.
        ''' </summary>
        Protected Overloads Overrides Sub Initialize()
            ' TODO: Add your initialization logic here

            MyBase.Initialize()
        End Sub

        ''' <summary>
        ''' LoadContent will be called once per game and is the place to load
        ''' all of your content.
        ''' </summary>
        Protected Overloads Overrides Sub LoadContent()
            ' Create a new SpriteBatch, which can be used to draw textures.

            ' TODO: use this.Content to load your game content here
            SpriteBatch = New SpriteBatch(GraphicsDevice)
        End Sub

        ''' <summary>
        ''' UnloadContent will be called once per game and is the place to unload
        ''' all content.
        ''' </summary>
        Protected Overloads Overrides Sub UnloadContent()
            ' TODO: Unload any non ContentManager content here
        End Sub

        ''' <summary>
        ''' Allows the game to run logic such as updating the world,
        ''' checking for collisions, gathering input, and playing audio.
        ''' </summary>
        ''' <param name="gameTime">Provides a snapshot of timing values.</param>
        Protected Overloads Overrides Sub Update(ByVal gameTime As GameTime)
            ' Allows the game to exit
            If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed Then
                Me.[Exit]()
            End If

            ' TODO: Add your update logic here

            MyBase.Update(gameTime)
        End Sub

        ''' <summary>
        ''' This is called when the game should draw itself.
        ''' </summary>
        ''' <param name="gameTime">Provides a snapshot of timing values.</param>
        Protected Overloads Overrides Sub Draw(ByVal gameTime As GameTime)
            GraphicsDevice.Clear(Color.CornflowerBlue)

            ' TODO: Add your drawing code here

            MyBase.Draw(gameTime)
        End Sub
    End Class
End Namespace