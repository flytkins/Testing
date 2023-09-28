using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncRealization
{
    public class FunctionClass
    {
        public static double func(double c, double b, double x)
        {
            return Math.Exp(Math.Sqrt(c * c - 3 * c + 2) / (b - 10) * x);
        }
    }
}
