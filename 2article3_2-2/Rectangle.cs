using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2_2
{
    class Rectangle : Content
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public void Draw()
        {
            PreDraw();
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < Width; i++)
                {
                    Console.Write($"{Symbol}");
                }
                Console.SetCursorPosition(X, Y + Height - 1);
            }
            Console.SetCursorPosition(X, Y);
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < Height; i++)
                {
                    Console.WriteLine($"{Symbol}");
                }
                Console.SetCursorPosition(X + Width - 1, Y);
            }
        }
    }
}
