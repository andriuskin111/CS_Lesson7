using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Rectangle rectangle = new Rectangle();

            point.koordinatesX = 5;
            point.koordinatesY = 8;

            rectangle.TopLeft.koordinatesX = 2;
            rectangle.TopLeft.koordinatesY = 2;
            rectangle.BottomRight.koordinatesX = 40;
            rectangle.BottomRight.koordinatesY = 20;
            

            rectangle.CheckPoint(point.koordinatesX, point.koordinatesY);

            Console.ReadLine();
        }
    }
}
