using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Unittestas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zodis Zodziai = new Zodis();
            Zodziai.zodis = "Kosmonautas";
            string apverstasZodis = Zodziai.ApverstiZodi(Zodziai.zodis);

            Zodziai.ParodytiRezultata(Zodziai.zodis, apverstasZodis);

            Console.ReadLine();
        }
    }
}
