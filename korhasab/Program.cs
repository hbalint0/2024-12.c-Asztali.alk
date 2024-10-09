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
            Console.ReadKey();
        }
    }
}
