using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class poäng
    {
        public class points
        {
            public int Point1;
            public int point2;
        }

        private SpriteFont _font;

        public points(SpriteFont font)
        {
            _font = font;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, Point1.Tostring(), new Vector2(320, 70), Color.White);
            spriteBatch.DrawString(_font, Point2.Tostring(), new Vector2(430, 70), Color.White);
        }
    }
}
