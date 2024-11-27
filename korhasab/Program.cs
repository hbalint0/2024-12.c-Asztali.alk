using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class Program
    {
        static void Main(string[] args)
         // Háromszög oldalainak tárolása
        private double oldal1, oldal2, oldal3;

        // Konstruktor
        public HTipus(double oldal1, double oldal2, double oldal3)
        {
            this.oldal1 = oldal1;
            this.oldal2 = oldal2;
            this.oldal3 = oldal3;
        }

        // Háromszög oldalainak érvényességi ellenőrzése
        public bool EllenorizHaromszog()
        {
            // Háromszög-egyenlőtlenség
            return (oldal1 + oldal2 > oldal3) && (oldal1 + oldal3 > oldal2) && (oldal2 + oldal3 > oldal1);
        }

        // Derékszögű háromszög ellenőrzése
        public bool DerekszoguHaromszog()
        {
            double[] oldalak = { oldal1, oldal2, oldal3 };
            Array.Sort(oldalak);  // Rendezés, hogy az átfogó a leghosszabb oldal legyen
            return Math.Pow(oldalak[2], 2) == Math.Pow(oldalak[0], 2) + Math.Pow(oldalak[1], 2);
        }

        // Egyenlő szárú háromszög ellenőrzése
        public bool EgyenloSzaruHaromszog()
        {
            return (oldal1 == oldal2 || oldal2 == oldal3 || oldal1 == oldal3);
        }

        // Egyenlő oldalú háromszög ellenőrzése
        public bool EgyenloOldaluHaromszog()
        {
            return (oldal1 == oldal2 && oldal2 == oldal3);
        }

        // Kimenet generálása
        public void Kiir()
        {
            if (!EllenorizHaromszog())
            {
                Console.WriteLine("Az adatok nem alkotnak háromszöget.");
            }
            else
            {
                Console.WriteLine("Az adatok megfelelnek egy háromszög oldalainak.");

                if (DerekszoguHaromszog())
                {
                    Console.WriteLine("A háromszög derékszögű.");
                }

                if (EgyenloSzaruHaromszog())
                {
                    Console.WriteLine("A háromszög egyenlő szárú.");
                }

                if (EgyenloOldaluHaromszog())
                {
                    Console.WriteLine("A háromszög egyenlő oldalú.");
                }
            }
        }
}
