using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_2
{
    struct Rinkejas
    {
        public int id;
        public bool arPrabalsavo;

        public Rinkejas(int _id, bool prabalsavo)
        {
            id = _id;
            arPrabalsavo = prabalsavo;
        }

        public void ParodytiBalsavimoStatistika(List<Rinkejas> rinkejas)
        {
            foreach (var item in rinkejas)
            {
                Console.WriteLine($"Rinkejo ID: {item.id}, Ar prabalsavo: {item.arPrabalsavo}");
            }
        }
    }
}
