using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    class Card : GameObject
    {
        public Card(IRenderer renderer)
               : base(renderer)
        {
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
