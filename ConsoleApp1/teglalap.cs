using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Téglalaphasab
{
    class Teglalapszamitasok
    {
        private double aoldal,
            boldal,
            Terulet,
            Kerulet;

        public Teglalapszamitasok()
        {

        }
        public Teglalapszamitasok(double a, double b)
        {
            this.aoldal = a;
            this.boldal = b;
        }
        //Metódusok
        public void Readaoldal(double aoldal)
        {
            this.aoldal = aoldal;
        }
        public void Readboldal(double boldal)
        {
            this.boldal = boldal;
        }
        
        public void Getaoldal
        { }


        public void TeruletSzam()
        {
            this.Terulet = this.aoldal * this.boldal;
        }
        public void KeruletSzam()
        {
            this.Kerulet = (this.aoldal + this.boldal) * 2;
        }
        public double GetKerulet() { return Kerulet; }
        public double GetTerulet() { return Terulet; }


    }
}



