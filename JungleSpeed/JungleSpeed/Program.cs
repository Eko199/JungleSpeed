using JungleSpeed.Core;
using System;
using System.Text;

namespace JungleSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new Manager());
            engine.Run();
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("____________");
            //sb.AppendLine("\\          /");
            //sb.AppendLine(" \\        /");
            //sb.AppendLine("  \\      /");
            //sb.AppendLine("   \\    /");
            //sb.AppendLine("   /    \\");
            //sb.AppendLine("  /      \\");
            //sb.AppendLine("  \\      /");
            //sb.AppendLine("   \\    /");
            //sb.AppendLine("   /    \\");
            //sb.AppendLine("  /      \\");
            //sb.AppendLine(" /        \\");
            //sb.AppendLine("/__________\\");
            //Console.WriteLine(sb.ToString());
        }
    }
}
