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
        private int _a;
        private int _d;
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
            _q = _a;
            _e = _d;
            _q = X;
            _e = Y;
            Console.SetCursorPosition(X, Y);
            for (int i =0; i<Lenghth; i++)
            {
                Console.Write($"{Symbol}");
                _q = _q + 1;
                _e = _e + 1;
                Console.SetCursorPosition(_q, _e);
            }
            Console.SetCursorPosition(_a, _d);
            for (int i = 0; i < Lenghth * 2 - 1; i++)
            {
                Console.Write($"{Symbol}");
            }
        }
    }
}
