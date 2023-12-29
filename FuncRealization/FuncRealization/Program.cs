using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncRealization
{
    public class Program
    {
        public static double func(double c, double b, double x)
        {
            return Math.Exp(Math.Sqrt(c * c - 3 * c + 2) / (b - 10) * x);
        }
        static void Main(string[] args)
        {
            double b, c, x1, x2, step;
            int n, maxn = 20;
            bool error = false;
            string path = Console.ReadLine();
            Console.WriteLine("Enter values: ");
            do
            {
                Console.Write("b (!=10) = ");
                b = Convert.ToDouble(Console.ReadLine());
                if (b == 10)
                {
                    error = true;
                    Console.WriteLine("b must not be 10");
                }
                else error = false;
            } while (error);
            do
            {
                Console.Write("c (>1 and <4) = ");
                c = Convert.ToDouble(Console.ReadLine());
                if (c > 1 && c < 4)
                {
                    error = true;
                    Console.WriteLine("c must be >1 and <4");
                }
                else error = false;
            } while (error);
            do {
                Console.Write("beginning of range x1 = ");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("end of range x2 = ");
                x2 = Convert.ToDouble(Console.ReadLine());
                if (x1 > x2)
                {
                    string yn;
                    error = true;
                    Console.WriteLine("end (x2) must be greater than beginning (x1) of range");
                    Console.WriteLine("Do you want to swap values? (y - yes, any other - no, enter new values): ");
                    yn = Console.ReadLine();
                    if (yn == "y")
                    {
                        double buff;
                        buff = x1;
                        x1 = x2;
                        x2 = buff;
                        error = false;
                    }
                }
                else error = false;
            } while (error);
            do
            {
                Console.Write("count of x-values = ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > maxn) 
                {
                    error = true;
                    Console.WriteLine("n must be <", maxn);
                }
            } while (error);

            step = (x2 - x1) / (n - 1);
            string filePath = "D:\\Projects\\123.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделение строки на значения по заданным разделителям
                    string[] values = line.Split("\n");

                    // Обработка извлеченных значений
                    foreach (string value in values)
                    {
                        c.Append(Convert.ToDouble(value));
                    }
                }
            }
        }
    }
}
