using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.X = 1;
            square.Y = 1;
            square.Color = ConsoleColor.Red;
            square.Length = 4;
            square.Symbol = "0";
            square.Draw();
        }
    }
}
