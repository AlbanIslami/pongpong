using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Models;

namespace Template.sprites
{
    public class bilder
    {
        protected Texture2D texture;

        public Vector2 position;
        public Vector2 hastighet;
        public float snabb;
        public röra röra;

        public Rectangle rec
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            }
        }

        public bilder(Texture2D texture)
        {
            texture = texture;
        }

        public virtual void Update(GameTime gameTime, List<bilder> sprites)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.BlueViolet);
        }


       
    }
}
