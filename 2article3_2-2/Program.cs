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

            Rectangle rectangle = new Rectangle();
            rectangle.X = 10;
            rectangle.Y = 10;
            rectangle.Color = ConsoleColor.Blue;
            rectangle.Width = 5;
            rectangle.Height = 3;
            rectangle.Symbol = "*";
            rectangle.Draw();

            Triangle triangle = new Triangle();
            triangle.X = 20;
            triangle.Y = 20;
            triangle.Color = ConsoleColor.Green;
            triangle.Lenghth = 4;
            triangle.Symbol = "+";
            triangle.Draw();
        }
    }
}
