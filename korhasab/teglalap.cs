﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class teglalap
    {
        //Az osztály feladata a sugárból kiszámítja a kör kerületét, területét
        protected double sugar,
            kerulet,
            terulet;

        //Objektum példát hoz létre, konstruktor
        public teglalap(){ }

        public teglalap(double r)
        {
            this.sugar = r;
        }

        //metódus, van visszatérési érték
        //formális és aktuális paraméter
        public void ReadSugar(double r)
        {
            this.sugar = r;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }
        public void SetTerulet()
        {
            double eredmeny1 = 0.0,
                eredmeny2 = 1.0;

            eredmeny1= this.terulet = this.sugar * this.sugar  * Math.PI;

            eredmeny2 = Math.Pow(this.sugar, 2) * Math.PI;
            if (eredmeny1 == eredmeny2)
            {
                this.terulet = eredmeny1;
            }
            else
            {
                Console.WriteLine($"Eredmény: {eredmeny1} != Eredmény2 {eredmeny2} ");
            }
            
        }
        public double GetKerulet() { return this.kerulet; }

        public double GetTerulet() { return this.terulet; }

        public double GetSugar() { return this.sugar; }
    }
}
