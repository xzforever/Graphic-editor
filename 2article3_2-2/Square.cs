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
        int _e;
        public void Draw()
        {
            PreDraw();
            //Горизонтальные
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
            bool trigger = false;
            //Вертикальные
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < Length; i++)
                {
                    Console.Write($"{Symbol}");
                    if (!trigger) Console.SetCursorPosition(X, ++_e);
                    else Console.SetCursorPosition(X+Length-1, ++_e);

                }
                _e = Y;
                trigger = true;
                Console.SetCursorPosition(X + Length - 1, Y);
            }
            Console.ReadLine();
        }
    }
}
