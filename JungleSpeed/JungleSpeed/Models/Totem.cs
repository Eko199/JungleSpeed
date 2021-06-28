using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JungleSpeed.Models
{
    class Totem : GameObject
    {
        public Totem(IRenderer renderer, Position pos)
            : base(renderer, pos)
        {
        }
        public override void Draw()
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
            Renderer.WriteAtPosition(sb.ToString(), Pos);
        }
    }
}
