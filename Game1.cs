using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Reflection.Emit;

namespace Monogame_lesson_1___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D backgroundTexture, curlyTexture, jimmyTexture, mouthwashTexture, eyeTexture;

        Random generator = new Random();

        int background;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 1422, 800);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            this.Window.Title = "Mouthwashing";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            background = generator.Next(1, 4);

            if (background == 1)
            {
                backgroundTexture = Content.Load<Texture2D>("MoutwashingBackground");
            }
            else if (background == 2)
            {
                backgroundTexture = Content.Load<Texture2D>("Cockpit");
            }
            else if (background == 3)
            {
                backgroundTexture = Content.Load<Texture2D>("Creepy ass hallway");
            }

                curlyTexture = Content.Load<Texture2D>("PainkillersTransparent (3)");
            jimmyTexture = Content.Load<Texture2D>("Jimbabwe (1)");
            mouthwashTexture = Content.Load<Texture2D>("DragonbreathMouthwash (1)");
            eyeTexture = Content.Load<Texture2D>("MouthwashingEye (1)");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture, new Vector2(0, 0), Color.White);

            _spriteBatch.Draw(curlyTexture, new Vector2(200, 75), Color.White);
            _spriteBatch.Draw(jimmyTexture, new Vector2(1025, 200), Color.White);
            _spriteBatch.Draw(mouthwashTexture, new Vector2(500, 75), Color.White);

            for (int i = 0; i <= 30; i++)
            {
                _spriteBatch.Draw(eyeTexture, new Vector2((i * 46), 0), Color.White);
                _spriteBatch.Draw(eyeTexture, new Vector2((i * 46), 750), Color.White);
            }

            for (int i = 0; i <= 250; i++)
            {
                //_spriteBatch.Draw(eyeTexture, new Vector2(generator.Next(-100, 1500), generator.Next(-100, 800)), Color.White);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
