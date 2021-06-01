using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    class Player : GameObject
    {
        private Queue<Card> deck;
        private Queue<Card> playedCards;
        public Player(IRenderer renderer)
            : base(renderer)
        {
        }
        public override void Draw()
        {
            playedCards.Seek().DrawAtPosition();
            throw new NotImplementedException();
        }
    }
}
