using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2_2
{
    class Content
    {
        public int X { get; set; }
        public int Y { get; set; }
        public System.ConsoleColor Color { get; set; }
        public string Symbol { get; set; }
        public void PreDraw()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = Color;    
        }
        

    }
}
