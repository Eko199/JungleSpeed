using JungleSpeed.Core.Contracts;
using JungleSpeed.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Core
{
    class ConsoleManager
    {
        private IList<Player> players;
        private int fieldLength;
        private int fieldWidth;
        public ConsoleManager(int playerCount)
        {
            players = new List<Player>(playerCount);
            fieldLength = 100;
            fieldWidth = 100;
        }
        public void 
    }
}
