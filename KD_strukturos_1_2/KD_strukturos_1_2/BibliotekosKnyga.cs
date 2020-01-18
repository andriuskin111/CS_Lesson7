using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_strukturos_1_2
{
    struct BibliotekosKnyga
    {
        int id;
        string pavadinimas;
        string skaitytojoVardas;
        DateTime paemimoData;

        public BibliotekosKnyga( int _id, string pavad, string vardas, DateTime data)
        {
            id = _id;
            pavadinimas = pavad;
            skaitytojoVardas = vardas;
            paemimoData = data;
        }

        public int GrazintiSkaitymoDienuSkaiciu()
        {
            int skaitymoDienuSkaicius = DateTime.Now.DayOfYear - paemimoData.DayOfYear;
            return skaitymoDienuSkaicius;
        }

        public void ParodytiSkaitytojoInformacija(int dienuSkaicius)
        {
            Console.WriteLine($"Knygos ID: {id}\n" +
                $"Knygos pavadinimas: {pavadinimas}\n" +
                $"Skaitytojo vardas: {skaitytojoVardas}\n" +
                $"Skaito dienu: {dienuSkaicius}");
        }
    }
}
