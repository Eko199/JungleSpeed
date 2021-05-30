using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.IO.Contracts
{
    class ConsoleRenderer : IRenderer

    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteAtPosition(string message, Position position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.WriteLine(message);
        }
    }
}
