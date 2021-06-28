using JungleSpeed.Core.Contracts;
using JungleSpeed.IO;
using JungleSpeed.IO.Contracts;
using JungleSpeed.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Core
{
    class Manager : IManager
    {
        private IList<Player> players;
        private int fieldHeight;
        private int fieldWidth;
        private Totem totem;

        public Manager()
        {
            players = new List<Player>();
            fieldHeight = 100;
            fieldWidth = 100;
            totem = new Totem(new ConsoleRenderer(), new Position(fieldWidth / 2, fieldHeight / 2));
        }
        public void initialisePlayers(int playerCount)
        {
            players = new List<Player>(playerCount);

            int firstRow = playerCount / 2 + playerCount % 2;
            int secondRow = playerCount / 2;

            int posWidth = fieldWidth / 2 - firstRow;
            int firstRowY = 3;
            int secondRowY = fieldHeight - 3;

            for (int i = 0; i < firstRow; i++)
                players.Add(new Player(new ConsoleRenderer(), new Position(posWidth + i * 2, firstRowY), -1));


            for (int i = 0; i < secondRow; i++)
                players.Add(new Player(new ConsoleRenderer(), new Position(posWidth + i * 2, secondRowY), 1));
        }

    }
}
