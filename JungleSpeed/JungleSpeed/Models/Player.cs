using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models {
    class Player : GameObject {
        private Queue<Card> deck;
        private Stack<Card> playedCards;
        public int deckPos;
        public Player(IRenderer renderer, Position pos, int deckPosition)
            : base(renderer, pos) {
            deckPos = deckPosition;
        }
        public override void Draw() {
            playedCards.Peek().Draw();
            Renderer.WriteAtPosition(deck.Count.ToString(), new Position(Pos.X, Pos.Y + deckPos));

        }
        public void DrawCard() {
            playedCards.Push(deck.Dequeue());
        }
    }
}
