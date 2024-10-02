using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortform
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10,
                y = 20;
            Console.WriteLine($"Az x eredeti értéke: {x}");
            Console.WriteLine($"Az x értke '++x ' iratással {++x}");
            Console.WriteLine($"Az x értéke kiíratás után: {x}");
            Console.WriteLine($"\nAz y eredeti értéke: {y}");
            Console.WriteLine($"Az y értke 'y++ ' iratással {y++}");
            Console.WriteLine($"Az y értéke kiíratás után: {y}");

            Console.ReadKey();
        }
    }
}
