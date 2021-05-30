using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.IO
{
    interface IRenderer
    {
        void Clear();
        void Write(string message);
        void WriteAtPosition(string message, Position position);

    }
}
