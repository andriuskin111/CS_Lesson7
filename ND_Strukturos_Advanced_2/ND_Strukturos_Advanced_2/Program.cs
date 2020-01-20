using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Rinkejas> rinkejasPirmaApylinke = new List<Rinkejas>();
            Rinkejas rinkejas = new Rinkejas();

            Random rnd = new Random();

            for (int i = 1; i <= 10; i++)
            {
                rinkejasPirmaApylinke.Add(new Rinkejas(i, Convert.ToBoolean(rnd.Next(2))));
            }

            rinkejas.ParodytiBalsavimoStatistika(rinkejasPirmaApylinke);
                     
            Console.ReadLine();
            
        }
       
    }
}
