using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2_2
{
    class Square : Content
    {
        public int Length { get; set; }
        private int _e;
        public void Draw()
        {
            PreDraw();
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < Length; i++)
                {
                    Console.Write($"{Symbol}");
                }
                Console.SetCursorPosition(X, Y + Length - 1);
            }
            Console.SetCursorPosition(X,Y);
            _e = Y;
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < Length; i++)
                {
                    Console.Write($"{Symbol}");
                    Console.SetCursorPosition(X,++_e);
                }
                _e = Y;
                Console.SetCursorPosition(X + Length - 1, Y);
            }
            Console.ReadLine();
        }
    }
}
