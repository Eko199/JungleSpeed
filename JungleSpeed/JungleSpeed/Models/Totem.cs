using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JungleSpeed.Models
{
    class Totem : GameObject
    {
        private string skin;
        private int height;
        private int width;
        public Totem(IRenderer renderer, Position pos)
            : base(renderer, pos)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader("../../../Totem.txt"))
            {
                string line = reader.ReadLine();
                width = line.Length;
                height = 0;
                while (line != null)
                {
                    height++;
                    sb.AppendLine(line);
                    line = reader.ReadLine();
                }
            }
            skin = sb.ToString();

        }
        public override void Draw()
        {
            
            Renderer.WriteAtPosition(skin, new Position(Pos.X - width / 2, Pos.Y - height / 2));
        }
    }
}
