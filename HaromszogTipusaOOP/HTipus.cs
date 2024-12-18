﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOP
{
    class HTipus
    {
        private int a, b, c;

        public HTipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool ErvenyesHaromszog()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public bool DerekszoguHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            int[] oldalak = { a, b, c };
            Array.Sort(oldalak);
            return (oldalak[0] * oldalak[0] + oldalak[1] * oldalak[1] == oldalak[2] * oldalak[2]);
        }

        public bool EgyenloSzaruHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) || (a == c) || (b == c);
        }

        public bool EgyenloOldaluHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) && (b == c);
        }

        public double Terulet()
        {
            if (!ErvenyesHaromszog()) return 0.0;
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            
        }

        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivetelkezeles");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám: {0}", szam);


        }
        public void KivKezAlt()

        {
            Console.WriteLine("Hiba");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A berírt szám: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();


        }


    }


}
