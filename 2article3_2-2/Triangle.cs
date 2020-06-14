using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2_2
{
    class Triangle: Content
    {
        public int Lenghth { get; set; }
        private int _q;
        private int _e;
        public void Draw()
        {
            _q = X;
            _e = Y;
            PreDraw();
            for(int i =0; i<Lenghth; i++)
            {
                
                Console.Write($"{Symbol}");
                _q = _q - 1;
                _e = _e + 1;
                Console.SetCursorPosition(_q, _e);
            }
            Console.SetCursorPosition(X, Y);
            for (int i =0; i<Lenghth; i++)
            {
                Console.Write($"{Symbol}");
                X = X + 1;
                Y = Y + 1;
                Console.SetCursorPosition(X,Y);
            }
            //Основание
            Console.SetCursorPosition(_q+1, _e-1);
            for (int i = 0; i < (Lenghth * 2)-1; i++)
            {
                Console.Write($"{Symbol}");
            }
            Console.ReadLine();
        }
    }
}
