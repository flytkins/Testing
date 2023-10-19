using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace F_from_x
{
    public class Program
    {
        public static double Func(double x, double a, double d)
        {
            if (a >= -3 && a <= 23)
            {
                Console.WriteLine("Parameter 'a' entered incorrectly");
                return 0;
            }
            if (d == Math.Pow(25, 1.0 / 3))
            {
                Console.WriteLine("Parameter 'd' entered incorrectly");
                return 0;
            }
            Console.WriteLine((5 / (d * d * d - 25)) * x * x * x + (7 / Math.Sqrt(a * a - 20 * a - 69)) * x * x - 3 * x - 20);
            return 0;
        }
        static void Main(string[] args)
        {
            double x, a, d;
            Console.WriteLine("Write x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write d:");
            d = Convert.ToDouble(Console.ReadLine());
            Func(x, a, d);
        }
    }
}
