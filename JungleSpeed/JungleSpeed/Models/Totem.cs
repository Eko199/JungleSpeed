using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JungleSpeed.Models
{
    class Totem : GameObject
    {
        public Totem(IRenderer renderer)
            : base(renderer)
        {
        }
        public override void Draw(Position pos)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader("../../../Totem.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    sb.AppendLine(line);
                    line = reader.ReadLine();
                }
            }
            Renderer.WriteAtPosition(sb.ToString(), pos);
        }
    }
}
