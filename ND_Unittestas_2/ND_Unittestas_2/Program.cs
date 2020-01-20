using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Unittestas_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 2;

            Console.WriteLine(PalygintiArSkaiciusLyginis(skaicius));

            Console.ReadLine();
            
        }

        public static bool PalygintiArSkaiciusLyginis(int aSkaicius)
        {
            bool rezultatas;

            if(aSkaicius % 2 == 0)
            {
                rezultatas = true;
            }
            else
            {
                rezultatas = false;
            }

            return rezultatas;
        }
    }
}
