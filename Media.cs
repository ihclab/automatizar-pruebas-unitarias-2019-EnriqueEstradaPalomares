using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasUnitarias
{
    class Media
    {
        public static double MediaAritmetica (int[] vals)
        {
            double total = Convert.ToDouble(vals.Length);
            double suma = 0.0;
            for(int i = 0; i < vals.Length; i++)
            {
                suma += Convert.ToDouble(vals[i]);
            }
            return suma/total;
        }

        public double raizEnesima(double x, int n)
        {
            return Math.Pow(x, (1 / Convert.ToDouble(n)));
        }
    }
}
