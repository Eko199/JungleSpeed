using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Speed {
    class Program {
        static void PrintTable(string[][] table) {
            foreach (string[] sym in table) {
                Array.ForEach(sym, Console.Write);
                Console.Write('\n');
            }
        }
        static void Main(string[] args) {
            bool inGame = true;
            Console.OutputEncoding = Encoding.UTF8;
            string a = "\u2592";
            string[][] table = new string[11][];
            for (int i=0; i<11; i++) {
                table[i] = new string[21];
                for (int j = 0; j < 21; j++) {
                    table[i][j] = a;
                }
            }
            while(inGame) {
                Console.Clear();
                PrintTable(table);
                Console.ReadLine();
            }
        }
    }
}
