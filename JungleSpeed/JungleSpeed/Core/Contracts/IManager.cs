using JungleSpeed.Models;
using System.Collections.Generic;

namespace JungleSpeed.Core
{
    interface IManager
    {
        void InitialisePlayers(int playerCount);
        void DrawField();
        void InitialiseCards();
        void ShuffleCards();
    }

}