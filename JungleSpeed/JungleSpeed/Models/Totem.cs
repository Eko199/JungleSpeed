using JungleSpeed.IO;
using System;
using System.Collections.Generic;
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
            sb.AppendLine("____________");
            sb.AppendLine("\\          /");
            sb.AppendLine(" \\        /");
            sb.AppendLine("  \\      /");
            sb.AppendLine("   \\    /");
            sb.AppendLine("   /    \\");
            sb.AppendLine("  /      \\");
            sb.AppendLine("  \\      /");
            sb.AppendLine("   \\    /");
            sb.AppendLine("   /    \\");
            sb.AppendLine("  /      \\");
            sb.AppendLine(" /        \\");
            sb.AppendLine("/__________\\");
            Renderer.WriteAtPosition(sb.ToString(), pos);
        }
    }
}
