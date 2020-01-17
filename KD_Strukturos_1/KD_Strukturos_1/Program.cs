using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Strukturos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kursoPradziosData = Convert.ToString(new DateTime(2019, 12, 10).ToShortDateString());
            string kursoPabaigosData = Convert.ToString(new DateTime(2020, 02, 25).ToShortDateString());

            Mokinys mokinys1 = new Mokinys("Andrius", "Geniusas", kursoPradziosData, kursoPabaigosData);
            Mokinys mokinys2 = new Mokinys("Vasia", "Petrov", kursoPradziosData, kursoPabaigosData);

            mokinys1.ParodytiDuomenis();
            mokinys2.ParodytiDuomenis();

            Console.ReadLine();
        }
    }
}
