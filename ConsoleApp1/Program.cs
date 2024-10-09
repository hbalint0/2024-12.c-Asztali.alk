using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Téglalaphasab
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglalapszamitasok teglaszam = new Teglalapszamitasok();
            teglaszam.Readaoldal(10);
            teglaszam.Readboldal(20);
            teglaszam.TeruletSzam();
            teglaszam.KeruletSzam();
            Console.WriteLine($"Kerület: {teglaszam.GetKerulet()}");
            Console.WriteLine($"A terület: { teglaszam.GetTerulet()}");
            Console.ReadKey();
        }
    }
}
