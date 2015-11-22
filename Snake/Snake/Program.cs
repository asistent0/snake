using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine line1 = new HorizontalLine(1, 78, 1, '+');
            HorizontalLine line2 = new HorizontalLine(1, 78, 24, '+');
            VerticalLine line3 = new VerticalLine(1, 24, 1, '+');
            VerticalLine line4 = new VerticalLine(1, 24, 78, '+');
            line1.Drow();
            line2.Drow();
            line3.Drow();
            line4.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadLine();
        }
    }
}
