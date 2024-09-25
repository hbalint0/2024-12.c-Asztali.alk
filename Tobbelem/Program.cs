using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobbelem
{
    class TobbElemosztaly
    {
        private int szam;
        private bool Isparos;
        public TobbElemosztaly()
        {
            szam = 0;
            Isparos = false;
        }
        public void Getszam(int p)
        {
            szam = 0;


        }

        public void Setszamtipus()
        {
            this.Isparos = szam % 2 == 0;
        }

        public bool outszamtipus()
        {
            return Isparos;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            string valasz = string.Empty;
            int paros = 0,
                szam = 0,
            paratlan = 0;
            TobbElemosztaly a = new TobbElemosztaly();
            while(paros + paratlan < 100)
            {
                Console.WriteLine("Adj meg egy egész számot");
                szam = Convert.ToInt32(Console.ReadLine());
                a.Getszam(szam);
                a.Setszamtipus();
                if (a.outszamtipus())
                {
                    valasz = "páros";
                    paros+= szam;
                }
                else
                {
                    valasz = "páratlan";
                    paratlan+=szam;
                }
                valasz = a.outszamtipus() ? "páros" : "paratlan";
                Console.WriteLine($"A szam típusa: {valasz}, eddig {paros + paratlan} számot adott meg");
                Console.ReadLine();
            }
        }
    }
}
