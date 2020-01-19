using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_4
{
    struct Rectangle
    {
        public Point TopLeft;
        public Point BottomRight;

        public void CheckPoint(double pointX, double pointY)
        {

            if(pointX <= TopLeft.koordinatesX || pointX >= BottomRight.koordinatesX || pointY <= TopLeft.koordinatesY || pointY >= BottomRight.koordinatesY)
            {
                Console.WriteLine("Taskas nera staciakampio viduje");
            }
            else
            {
                Console.WriteLine("Taskas yra staciakampio viduje");
            }

            
        }
    }
}
