using JungleSpeed.Core.Contracts;
using JungleSpeed.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Core
{
    class Engine : IEngine
    {
        private IManager manager;
        private int playerCount = 5;
        public Engine()
        {
            
        }
        public void Run()
        {
            //Console.WriteLine("Boqn go kefi i raboti.");

            manager = new Manager(new ConsoleRenderer());
            manager.InitialiseCards();
            manager.ShuffleCards();
            manager.InitialisePlayers(playerCount);   
                
        }
    }
}
