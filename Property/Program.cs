﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            
                /*Ez a példa azt mutatja be hogy a property féle deklaráció nem úgy hozza létre a orivét háttér változót hhogy a nagy kezdőbetűt kicsire váltja */
                Person p = new Person();
                p.Name = "Isti";
                p.SetName("Gábor");
                Console.WriteLine($"p.Name:{p.Name}");
                Console.WriteLine($"p.GetName:{p.GetName()}");
                Console.ReadKey();
            
        }
    }
}
