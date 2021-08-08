using JungleSpeed.Core.Contracts;
using JungleSpeed.IO;
using JungleSpeed.IO.Contracts;
using JungleSpeed.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace JungleSpeed.Core
{
	class Manager : IManager
	{
		private IList<Player> players;
		private IList<Card> cards;
		private int fieldHeight;
		private int fieldWidth;
		private Totem totem;
		private IRenderer renderer;
		public Manager(IRenderer renderer)
		{
			players = new List<Player>();
			cards = new List<Card>();
			this.renderer = renderer;
			fieldHeight = 100;
			fieldWidth = 100;
			totem = new Totem(renderer, new Position(fieldWidth / 2, fieldHeight / 2));
		}
		public void InitialiseCards()
		{
			using (StreamReader reader = new StreamReader("../../../../../Symbols.txt"))
			{
				Regex symbols = new Regex(@"[^\s]");
				MatchCollection matches = symbols.Matches(reader.ReadToEnd());
				for (int i = 0; i < matches.Count; i++)
				{
					cards.Add(new Card(renderer, new Position(0, 0), matches[i].Value[0], ConsoleColor.Red));
					cards.Add(new Card(renderer, new Position(0, 0), matches[i].Value[0], ConsoleColor.Yellow));
					cards.Add(new Card(renderer, new Position(0, 0), matches[i].Value[0], ConsoleColor.Green));
					cards.Add(new Card(renderer, new Position(0, 0), matches[i].Value[0], ConsoleColor.Blue));
				}
				for (int i = 0; i < 3; i++)
				{
					cards.Add(new Card(renderer, new Position(0, 0), '1', ConsoleColor.White));
					cards.Add(new Card(renderer, new Position(0, 0), '2', ConsoleColor.White));
				}
				for (int i = 0; i < 2; i++)
				{
					cards.Add(new Card(renderer, new Position(0, 0), '3', ConsoleColor.Magenta));
				}
			}
		}
		public void ShuffleCards()
		{
			Random random = new Random();
			
			for (int i = 0; i < cards.Count; i++)
			{
				int r = i + random.Next(0, cards.Count - i);

				Card card = cards[i];
				cards[i] = cards[r];
				cards[r] = card;
			}
		}

        public void InitialisePlayers(int playerCount)
        {
            int firstRow = playerCount / 2 + playerCount % 2;
            int secondRow = playerCount / 2;

            int posWidth = fieldWidth / 2 - firstRow;
            int firstRowY = 3;
            int secondRowY = fieldHeight - 3;

            int cardsPerPlayer = cards.Count / playerCount;
            int cardsLeft = cards.Count % playerCount;
            int cardCounter = 0;

            for (int i = 0; i < firstRow; i++)
                players.Add(new Player(renderer, new Position(posWidth + i * 2, firstRowY), -1, cards.ToList().GetRange(i * cardsPerPlayer, cardsPerPlayer)));

            for (int i = 0; i < secondRow; i++)
                players.Add(new Player(renderer, new Position(posWidth + i * 2, secondRowY), 1, cards.ToList().GetRange(i * cardsPerPlayer, cardsPerPlayer)));

			totem.AddToStake(cards.ToList().GetRange(cardsPerPlayer * playerCount, cardsLeft));
		}
		public void DrawField()
		{
			foreach (var player in players)
			{
				player.Draw();
			}
			totem.Draw();
		}
    }
}
