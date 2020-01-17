using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Strukturos_1
{
    struct Mokinys
    {
        public string vardas;
        public string pavarde;
        public string kursoPradziosData;
        public string kursoPabaigosData;

        public Mokinys(string vard, string pavard, string kursoPrad, string kursoPab)
        {
            vardas = vard;
            pavarde = pavard;
            kursoPradziosData = kursoPrad;
            kursoPabaigosData = kursoPab;
        }
        public void ParodytiDuomenis()
        {
            Console.WriteLine($"Vardas: {vardas}\n" +
                $"Pavarde: {pavarde}\n" +
                $"Kurso pradzios data: {kursoPradziosData}\n" +
                $"Kurso pabaigos data: {kursoPabaigosData}");
        }
    }
}
