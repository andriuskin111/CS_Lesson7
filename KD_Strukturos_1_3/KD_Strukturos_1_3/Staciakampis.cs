using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Strukturos_1_3
{
    struct Staciakampis
    {
        public int staciakampioNr;
        public double staciakampioIlgis;
        public double staciakampioPlotis;

        public Staciakampis(int nr, double ilgis, double plotis)
        {
            staciakampioNr = nr;
            staciakampioIlgis = ilgis;
            staciakampioPlotis = plotis;
        }

        public void ParodytiStaciakampioPlota()
        {
            Console.WriteLine($"Staciakampio Nr {staciakampioNr} plotas yra: {staciakampioIlgis * staciakampioPlotis}");
        }
    }

    
}
