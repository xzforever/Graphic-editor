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
            Square square = new Square(4,1,1,ConsoleColor.Red,"0");
            square.Draw();

            Rectangle rectangle = new Rectangle(3,5,10,10,ConsoleColor.Blue,"*");
            rectangle.Draw();

            Triangle triangle = new Triangle(4,20,20,ConsoleColor.Green, "+");
            triangle.Draw();
        }
    }
}
