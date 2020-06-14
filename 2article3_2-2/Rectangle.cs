using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2_2
{
    class Rectangle : Content
    {
        public int Height { get; set; }
        public int Width { get; set; }
        int _e;
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
            bool trigger = false;
            _e = Y;
            Console.SetCursorPosition(X, Y);
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < Height; i++)
                {
                    Console.Write($"{Symbol}");
                    if (!trigger) Console.SetCursorPosition(X, ++_e);
                    else
                    {
                        _e = Y;
                        Console.SetCursorPosition(X + Width - 1, ++_e);
                    }

                }
                trigger = true;
                Console.SetCursorPosition(X + Width - 1, Y);
            }
            Console.ReadLine();
        }
    }
}
