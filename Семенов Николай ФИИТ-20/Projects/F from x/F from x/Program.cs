using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace F_from_x
{
    public class Program
    {
        public static double Func(double x, double a, double d)
        {
            return (5 / (d * d * d - 25)) * x * x * x + (7 / Math.Sqrt(a * a - 20 * a - 69)) * x * x - 3 * x - 20;
        }
        public static double[] Razb(double x1, double x2, int n, double a, double d)
        {
            double[] diapazone = new double[n];
            double h = (x2 - x1) / n - 1;
            for (int i = 0; i < n; i++)
            {
                diapazone[i] = Func(x1 + h * i, a, d);
            }
            return diapazone;
        }
        static void Main(string[] args)
        {
            double a, d;
            //Console.WriteLine("Write x:");
            //x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write d:");
            d = Convert.ToDouble(Console.ReadLine());
            //Func(x, a, d);
            double x1, x2;
            int n;
            Console.WriteLine("Write x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write n:");
            n = Convert.ToInt32(Console.ReadLine());
            double[] diapazone = Razb(x1, x2, n, a, d);
            for (int i = 0; i < n; i++)
            {
                Console.Write(diapazone[i] + " ");
            }
        }
    }
}
