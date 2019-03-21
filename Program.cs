using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasUnitarias
{
    class Program
    {
        static void Main(string[] args)
        {
            Media med = new Media();
            int[] vec = { 1, 2, 3, 4 };
            Console.WriteLine(Media.MediaAritmetica(vec).ToString());
            Console.WriteLine(med.raizEnesima(3, 4));
            Console.ReadKey();
        }
    }
}
