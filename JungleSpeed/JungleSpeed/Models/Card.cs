using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    class Card : GameObject
    {
        private char symbol;
        private ConsoleColor color;
        public Card(IRenderer renderer, Position pos, char symbol, ConsoleColor color)
               : base(renderer, pos)
        {
            this.symbol = symbol;
            this.color = color;
        }
        public override void Draw()
        {
            Renderer.WriteAtPosition(symbol.ToString(), Pos);
            throw new NotImplementedException();
        }
    }
}
