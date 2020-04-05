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
    class Boll : bilder
    {
        private float _timer = 0f;
        private Vector2? starten = null;
        private float fart;
        private bool rörande;

        public poäng poäng;
        public int SpeedIncrementSpan = 11;

        public Boll(Texture2D texture)
            : base(texture)
        {
            fart = 3f;
        }

        public override void Update(GameTime gametime, List<bilder> bilders)
        {
            if(starten == null)
            {
                starten = position;
                fart = hastighet;
            }
        }


    }
}
