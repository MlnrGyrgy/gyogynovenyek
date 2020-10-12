using System;
using System.IO;
namespace gyogynovenyek
{
    class novenyek
    {
        
        public string Nev { get; private set; }

        public string Resz { get; private set; }

        public int Kezd { get; private set; }

        public int Veg { get; private set; }

        public int Idotartam { get; private set; }

        public novenyek(string sor)
        {              
                string[] egy = sor.Split(';');
                Nev = egy[0];
                Resz = egy[1];
                Kezd = int.Parse(egy[2]);
                Veg = int.Parse(egy[3]);
            if (Veg>Kezd)
            {
                Idotartam = Veg - Kezd + 1;
            }
            else
            {
                Idotartam = 12 - Kezd + Veg + 1;
            }
        }
    }
}