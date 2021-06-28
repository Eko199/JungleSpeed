using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    class Card : GameObject
    {
        private string symbol;
        public Card(IRenderer renderer, Position pos)
               : base(renderer, pos)
        {
        }
        public override void Draw()
        {
            Renderer.WriteAtPosition(symbol, Pos);
            throw new NotImplementedException();
        }
    }
}
