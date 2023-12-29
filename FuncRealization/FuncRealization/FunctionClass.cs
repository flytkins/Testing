using System;
using System.Collections.Generic;
using System.IO;
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
        public static double[] Razb(double x1, double x2, int n, double c, double b)
        {
            double[] diapazone = new double[n];
            double h = (x2 - x1) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                diapazone[i] = func(c, b, x1 + h * i);
            }
            return diapazone;
        }
        public static void PrintArrayToFile(double[] array, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    writer.WriteLine(array[i]);
                }
            }
        }
    }
}
