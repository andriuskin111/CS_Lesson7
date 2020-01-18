using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_strukturos_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotekosKnyga knyga1 = new BibliotekosKnyga(1, "Roneta", "Andrius", new DateTime(2020, 01, 02));
            BibliotekosKnyga knyga2 = new BibliotekosKnyga(2, "Zvaigzdziu karai", "Vasia", new DateTime(2020, 01, 10));

            knyga1.ParodytiSkaitytojoInformacija(knyga1.GrazintiSkaitymoDienuSkaiciu());
            knyga2.ParodytiSkaitytojoInformacija(knyga2.GrazintiSkaitymoDienuSkaiciu());

            Console.ReadLine();

        }
    }
}
