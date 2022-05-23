using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Računalo računalo = new Računalo("PC", "16 GB", "i5", "Win 10", "WD 1 TB", "500W", "Gigabyte", 5000);

            računalo.IspišiDetalje();
            računalo.OdrediKategorijuRačunala();
            Console.ReadLine();
        }
    }
}
