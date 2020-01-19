using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_3
{
    class ZoologijosSodas
    {
        public string zoologijosSodoPavadinimas;
        public string zoologijosSodoAdresas;
        public List<Gyvunas> gyvunas;

        public ZoologijosSodas(string pavad, string adres)
        {
            zoologijosSodoPavadinimas = pavad;
            zoologijosSodoAdresas = adres;
            gyvunas = new List<Gyvunas>();
        }

        public void PridetiGyvuna(string vard, string rus)
        {
           gyvunas.Add(new Gyvunas(vard, rus));
        }

        public void ParodytiGyvunus()
        {
            int krokodilas = 0;
            int liutas = 0;
            int bezdzione = 0;
            int smauglys = 0;
            int nezinomaRusis = 0;

            foreach (var item in gyvunas)
            {               

                if(item.rusis == "Krokodilas")
                {
                    krokodilas++;
                }
                else if(item.rusis == "Liutas")
                {
                    liutas++;
                }
                else if(item.rusis == "Bezdzione")
                {
                    bezdzione++;
                }
                else if(item.rusis == "Smauglys")
                {
                    smauglys++;
                }
                else
                {
                    nezinomaRusis++;
                }
                
            }

            Console.WriteLine($"Viso gyvunu yra: {gyvunas.Count}\n" +
                    $"Krokodilu yra: {krokodilas}\n" +
                    $"Liutu yra: {liutas}\n" +
                    $"Bezdzioniu yra: {bezdzione}\n" +
                    $"Smaugliu yra: {smauglys}\n" +
                    $"Nezinomos rusies:{nezinomaRusis}");
        }
    }
}
