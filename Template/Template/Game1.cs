using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Template.sprites;
using Template.Models;
using System;
using System.Collections.Generic;

namespace Template
{
   
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch SpriteBatch;
  
        public static int ScreenWidth;
        public static int ScreenHeight;
        public static int Random Random;

        private poäng points;
        private List<bilder> bilders;

        
        
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            ScreenWidth = graphics.PreferredBackBufferWidth;
            ScreenHeight = graphics.PreferredBackBufferHeight;
            Random = new Random();

            base.Initialize();
        }

      
        protected override void LoadContent()
        {
            
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            var Hand = Content.Load<Texture2D>("hand");
            var boll = Content.Load<Texture2D>("boll");

            points = new poäng(Content.Load<SpriteFont>("font"));








        }

     
        protected override void UnloadContent()
        {
        }

        
        protected override void Update(GameTime gameTime)
        {
            foreach (var sprite in bilders)
            {
                sprite.Update(gameTime, bilders); 
            }
            base.Update(gameTime);
        }


        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            SpriteBatch.Begin();

            foreach (var sprite in bilders)
                bilder.Draw(SpriteBatch);

            points.Draw(SpriteBatch);


            
            SpriteBatch.End();


            base.Draw(gameTime);

        }
    }



}
