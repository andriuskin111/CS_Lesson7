using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirmasTrimestras = new List<int>();
            List<int> antrasTrimestras = new List<int>();
            List<int> treciasTrimestras = new List<int>();

            Studentas studentas1 = new Studentas();
                       
            Random rnd = new Random();
            for (int i = 0; i < 11; i++)
            {
                pirmasTrimestras.Add(rnd.Next(2, 10));
                antrasTrimestras.Add(rnd.Next(2, 10));
                treciasTrimestras.Add(rnd.Next(2, 10));
            }
           
            studentas1.IsvestiPirmoTrimestroVidurki(pirmasTrimestras);
            studentas1.IsvestiAntroTrimestroVidurki(antrasTrimestras);
            studentas1.IsvestiTrecioTrimestroVidurki(treciasTrimestras);
            studentas1.IsvestiMetiniusVidurkius(pirmasTrimestras, antrasTrimestras, treciasTrimestras);

            Console.ReadLine();

        }

    }
}
