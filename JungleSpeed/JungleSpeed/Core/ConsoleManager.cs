using JungleSpeed.Core.Contracts;
using JungleSpeed.IO;
using JungleSpeed.IO.Contracts;
using JungleSpeed.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Core
{
    class ConsoleManager
    {
        private IList<Player> players;
        private int fieldHeight;
        private int fieldWidth;
        private Totem totem;

        public ConsoleManager(int playerCount)
        {
            players = new List<Player>(playerCount);
            fieldHeight = 100;
            fieldWidth = 100;
            totem = new Totem(new ConsoleRenderer(), new Position(fieldWidth / 2, fieldHeight / 2));

            initialisePlayers();
        }
        public void initialisePlayers()
        {
            int firstRow = players.Count / 2 + players.Count % 2;
            int secondRow = players.Count / 2;

            int posWidth = fieldWidth / 2 - firstRow;
            int firstRowY = 3;
            int secondRowY = fieldHeight - 3;

            for (int i = 0; i < firstRow; i++)
            {
                players[i].Pos.X = posWidth + i * 2;
                players[i].Pos.Y = firstRowY;

            }

            for (int i = 0; i < secondRow; i++)
            {
                players[i].Pos.X = posWidth + i * 2;
                players[i].Pos.Y = secondRowY;
            }
        }

    }
}
