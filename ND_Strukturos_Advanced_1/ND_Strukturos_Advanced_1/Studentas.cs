using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Strukturos_Advanced_1
{
    struct Studentas
    {
        public int pirmoTrimestroPazymiai;
        public int antroTrimestroPazymiai;
        public int trecioTrimestroPazymiai;

        public Studentas(int pirmasTr, int antrasTr, int treciasTr)
        {
            pirmoTrimestroPazymiai = pirmasTr;
            antroTrimestroPazymiai = antrasTr;
            trecioTrimestroPazymiai = treciasTr;
        }

        //public List<int> lstPirmoTrimestroPazymiai
        //{
        //    get { return pirmoTrimestroPazymiai; }
        //    set { pirmoTrimestroPazymiai = value; }
        //}

        //public List<int> lstAntroTrimestroPazymiai
        //{
        //    get { return antroTrimestroPazymiai; }
        //    set { antroTrimestroPazymiai = value; }
        //}

        //public List<int> lstTrecioTrimestroPazymiai
        //{
        //    get { return trecioTrimestroPazymiai; }
        //    set { trecioTrimestroPazymiai = value; }
        //}

        public void IsvestiPirmoTrimestroVidurki(List<int> pirmoTrimestroPazymiai)
        {
            double resultatas = 0;
            foreach (var item in pirmoTrimestroPazymiai)
            {
                resultatas += item; 
            }
            Console.WriteLine("Pirmo trimestro vidurkis: {0:0.00}", (resultatas / pirmoTrimestroPazymiai.Count));
        }
        public void IsvestiAntroTrimestroVidurki(List<int> antroTrimestroPazymiai)
        {
            double resultatas = 0;
            foreach (var item in antroTrimestroPazymiai)
            {
                resultatas += item;
            }
            Console.WriteLine("Antro trimestro vidurkis: {0:0.00}", (resultatas / antroTrimestroPazymiai.Count));
        }

        public void IsvestiTrecioTrimestroVidurki(List<int> trecioTrimestroPazymiai)
        {
            double resultatas = 0;
            foreach (var item in trecioTrimestroPazymiai)
            {
                resultatas += item;
            }
            Console.WriteLine("Trecio trimestro vidurkis: {0:0.00}", (resultatas / trecioTrimestroPazymiai.Count));
        }

        public void IsvestiMetiniusVidurkius(List<int> pirmoTrimestroPazymiai, List<int> antroTrimestroPazymiai, List<int> trecioTrimestroPazymiai)
        {
            double rezultatas1 = 0;
            double rezultatas2 = 0;
            double rezultatas3 = 0;

            foreach (var item in pirmoTrimestroPazymiai)
            {
                rezultatas1 += item;
            }

            rezultatas1 = rezultatas1 / pirmoTrimestroPazymiai.Count;

            foreach (var item in antroTrimestroPazymiai)
            {
                rezultatas2 += item;
            }

            rezultatas2 = rezultatas2 / antroTrimestroPazymiai.Count;

            foreach (var item in trecioTrimestroPazymiai)
            {
                rezultatas3 += item;
            }

            rezultatas3 = rezultatas3 / trecioTrimestroPazymiai.Count;

            Console.WriteLine("Metinis vidurkis: {0:0.00}", (rezultatas1 + rezultatas2 + rezultatas3) / 3);
        }
    }
}
