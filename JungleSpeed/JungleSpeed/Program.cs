using JungleSpeed.Core;
using System;
using System.Text;

namespace JungleSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine((IManager) new ConsoleManager(2));
            engine.Run();
        }
    }
}
