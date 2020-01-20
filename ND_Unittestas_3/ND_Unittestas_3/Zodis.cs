using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Unittestas_3
{
    public struct Zodis
    {
        public string zodis;

        public Zodis(string zod)
        {
            zodis = zod;
        }

        public string ApverstiZodi(string aZodis)
        {
            string rezultatas = "";

            for (int i = aZodis.Length - 1; i >=0 ; i--)
            {
                rezultatas += aZodis[i];
            }
            return rezultatas;
        }

        public void ParodytiRezultata(string aZodisOriginalus, string aZodisApverstas)
        {
            Console.WriteLine($"{aZodisOriginalus}\n{aZodisApverstas}");
        }
    }
}
