using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template.sprites
{
    class Spelare : bilder
    {   
        public Spelare(Texture2D texture)
            : base(texture)
        {
            hastighet = 5f;
        }

        public override void Update(GameTime gameTime, List<bilder> sprites)
        {
            if (röra == null)
            
                throw new Exception("tryck på någon knapp");

                if (Keyboard.GetState().IsKeyDown(röra.upp))
                    hastighet.Y = -snabb;
                else if (Keyboard.GetState().IsKeyDown(röra.ner))
                    hastighet.Y = snabb;

                position += hastighet;

                position.Y = MathHelper.Clamp(position.Y, 0, Game1.ScreenHeight - texture.Height);

                hastighet = Vector2.Zero;
        }
    }
}
