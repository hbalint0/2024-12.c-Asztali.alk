using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orokles
{
    /* virtuals jelentése: metódus
        A virtual tagok alapértelmezett viselkedést biztosítanak az ősosztályban, de a 
    származtatott osztályban az override kulcsszóval módisíthatjuk ezt a viselkedést.
    A sealed kulcsszó lezárja az osztályokat vagy metódusokat a további örökléstől.

     */

    /*
     * Abstarctot mutatja be
     * abstract osztály: csak száramztatott osztályon keresztül használható
     * abstract metódus: csak abstract osztályon belül lehet és a származtatott osztályának kötelező megvalósítania
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Allat
    {
        public string Name { get; set; }
        public string Hang { get; set; }

        public Allat()
        {
            this.Name = "Anonim";
            this.Hang = "Én egy állat vagyok";
        }

        public Allat(string name)
        {
            this.Name = name;
            this.Hang = "Én egy állat vagyok";
        }

        public void hangotAd()
        {
            Console.WriteLine("Ezt a Allat.hangotAd() metódus írta ki.");
            Console.ReadKey();
        }

        public virtual void mozog()
        {
            Console.WriteLine("Ezt a virtuális mozog() metódus írta ki.");
            Console.ReadKey();
        }
    }
    class Kutya : Allat
    {
        public Kutya() :base()
        {
            this.Hang = "Én egy kutya vagyok";
            Console.ReadKey();
        }
        public void hangotAd()
        {
            Console.WriteLine("Ezt a Kutya.hangotAd() metódus írta ki.");
            Console.ReadKey();
        }

        public sealed override void mozog()
        {
            Console.WriteLine("Ezt a lezárt mozog() metódust írta ki.");
            Console.ReadKey();
        }

    }

    class Komondor : Kutya
    {
        public Komondor() : base()
        {
            this.Name = "Komondor";
        }
        public void mozog() { }

        sealed class Macska : Allat
        {
            public Macska()
            {
                this.Name = "Cicamica";
            }
        }
    }
}
