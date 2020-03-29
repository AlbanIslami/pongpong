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

        #region krocka
        protected bool vänster(bilder sprites)
        {
            return this.rec.Right + this.hastighet.X < bilder.Rectangle.Left &&
                this.rec.Left < bilder.Rectangle.Left &&
                this.rec.Bottom < bilder.Rectangle.Top &&
                this.rec.Top < bilder.Rectangle.Bottom &&;
        }

        protected bool höger(bilder sprites)
        {
            return this.rec.Left + this.hastighet.X < bilder.Rectangle.Right &&
                this.rec.Top < bilder.Rectangle.Top &&
                this.rec.Right < bilder.Rectangle.Left &&
                this.rec.Left < bilder.Rectangle.Right &&;

        }
        protected bool toppen(bilder sprites)
        {
            return this.rec.Bottom + this.hastighet.Y < texture.Rectangle.Top &&
                this.rec.Top < texture.Rectangle.Top &&
                this.rec.Right < texture.Rectangle.Left &&
                this.rec.Left < texture.Rectangle.Right &&;
        }
        protected bool botten(bilder sprites)
        {
            return this.rec.Top + this.hastighet.Y < bilder.Rectangle.Bottom &&
                this.rec.Bottom < texture.Rectangle.Bottom &&
                this.rec.Right < texture.Rectangle.Left &&
                this.rec.Left < texture.Rectangle.Right &&;
        }
        #endregion

    }
}
