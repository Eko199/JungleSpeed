using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models {
    class Player : GameObject {
        private Queue<Card> deck;
        private Stack<Card> playedCards;
        public int deckPos;
        public Player(IRenderer renderer, Position pos, int deckPosition, IEnumerable<Card> initialDeck)
            : base(renderer, pos) {
            playedCards = new Stack<Card>();
            deck = new Queue<Card>(initialDeck);
            deckPos = deckPosition;
        }
        public override void Draw() {
            playedCards.Peek().Draw();
            Renderer.WriteAtPosition(deck.Count.ToString(), new Position(Pos.X, Pos.Y + deckPos));
        }
        public void DrawCard() {
            playedCards.Push(deck.Dequeue());
            playedCards.Peek().Pos = Pos;
        }
    }
}
