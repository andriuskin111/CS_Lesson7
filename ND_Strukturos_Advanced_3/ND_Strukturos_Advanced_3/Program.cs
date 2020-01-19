using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ZoologijosSodas sodas = new ZoologijosSodas("Sodas", "Kaunas");
            sodas.PridetiGyvuna("Gena", "Krokodilas");
            sodas.PridetiGyvuna("Vasia", "Krokodilas");
            sodas.PridetiGyvuna("Mazutis", "Krokodilas");
            sodas.PridetiGyvuna("Pukis", "Liutas");
            sodas.PridetiGyvuna("Murka", "Liutas");
            sodas.PridetiGyvuna("Atlepausis", "Bezdzione");
            sodas.PridetiGyvuna("Desra", "Smauglys");
            sodas.PridetiGyvuna("Sasyska", "Smauglys");
            sodas.PridetiGyvuna("X", "Spermatozauras");

            sodas.ParodytiGyvunus();

            Console.ReadLine();
        }
    }
}
