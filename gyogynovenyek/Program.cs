using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyogynovenyek
{
    class Program
    {
        static List<novenyek> lista = new List<novenyek>();
        static void Beolvasas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                lista.Add(new novenyek(file.ReadLine()));
            }
          file.Close();
        }
        static void Szamolas()
        {
            Console.WriteLine("1. Feladat: Növények száma: {0}",lista.Count);
        }
        static Dictionary<string,int> szamol = new Dictionary<string, int>();
        static void Gyujtheto()
        {
            Console.WriteLine();
            foreach (var i in lista)
            {
                if (!szamol.ContainsKey(i.Resz))
                {
                    szamol.Add(i.Resz, 0);
                }               
            }
            foreach (var i in lista)
            {
                szamol[i.Resz]++;
            }
            foreach (var i in szamol)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
        static void Legtobb()
        {
            
            int max = 0;
            foreach (var i in lista)
            {
                if (max < i.Idotartam)
                {
                    max = i.Idotartam;
                }           
            }
            Console.Write("3. feladat: legtöbb ideig gyűjthető növények: {0},", max);
            foreach (var i in lista)
            {
                if (i.Idotartam==max)
                {
                    Console.WriteLine(" "+ i.Nev);
                }
            }        
        }
        static void Osszegzes()
        {
            double sum = 0;
            foreach (var i in lista)
            {
                sum += i.Idotartam;
            }
            Console.WriteLine($"Átlagosan gyűjthető időtartam: {sum/lista.Count()}");
        }
        static void Main(string[] args)
        {       
            Beolvasas();
            Szamolas();
            Gyujtheto();
            Legtobb();
            Osszegzes();
            //foreach (var i in lista)
            //{
            //    Console.WriteLine(i.Nev);
            //}

            Console.ReadKey();
        }
    }
}
