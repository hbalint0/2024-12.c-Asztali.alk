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
        {
            #region 1. objektum
            teglalap k1 = new teglalap();
            k1.ReadSugar(15.0);
            k1.SetKerulet();
            k1.SetTerulet();
            Console.WriteLine($"{k1.GetSugar()} sugarú téglalap kerülete {k1.GetKerulet()}, területe: {k1.GetTerulet()} ");
            #endregion EOf 1. objektum
            #region 2.objektum
            teglalap k2 = new teglalap(28.7);
            k2.SetKerulet();
            k2.SetTerulet();
            Console.WriteLine($"{k2.GetSugar()} sugarú téglalap kerülete {k2.GetKerulet()}, területe: {k2.GetTerulet()} ");
            #endregion EOf 2. objektum

            #region kor2 hasznalata
            kor2 k21 = new kor2(26);
            Console.WriteLine($"A kör2 adatai: Sugár= {k21.getsugar()},\n Kerület= {k21.getkerulet()}\n Terület= {k21.getterulet()} ");
            #endregion kor2


            #region henger szamtias
            henger h1 = new henger(15, 30);
            Console.WriteLine($"\n A henger adatai: Sugara= {h1.GetSugar()},\n Magassága= {h1.getmagassag()},\n Alapterülete= {h1.GetTerulet()},\n Térfogata={h1.getterfogat()} ");
            #endregion henger
            Console.ReadKey();
        }
    }
}
