using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Strukturos_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Staciakampis staciakampis1 = new Staciakampis(1, 1.2, 3.8);
            Staciakampis staciakampis2 = new Staciakampis(2, 2.3, 4.6);
            Staciakampis staciakampis3 = new Staciakampis(3, 3.2, 5.4);

            staciakampis1.ParodytiStaciakampioPlota();
            staciakampis2.ParodytiStaciakampioPlota();
            staciakampis3.ParodytiStaciakampioPlota();

            Console.ReadLine();
        }
    }
}
