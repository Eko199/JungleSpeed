using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    class Card : GameObject
    {
        private string symbol;
        public Card(IRenderer renderer)
               : base(renderer)
        {
        }
        public override void Draw(Position pos)
        {
            Renderer.WriteAtPosition(symbol, pos);
            throw new NotImplementedException();
        }
    }
}
