using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод Рунге-Кутты 1 совокупность формул");
            Console.WriteLine();
            //начальные данные
            Console.WriteLine("Введите начало отрезка:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка:");
            double b = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("Введите шаг разбиения функции h:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x0:");
            double x0= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y0:");
            double y0 = Convert.ToDouble(Console.ReadLine());            
            double i = (b - a) / h;
            Console.WriteLine("Параметр i: " + i);
            //i += 1;
            for(int j = 0; j <= i; j++)
            {
                double f = Math.Sqrt(x0) * y0;
                double r1 = h * f;
                double x2 = x0 + h / 2;
                double y2 = y0 + r1 / 2;
                double r2 = h * (Math.Sqrt(x2) * y2);
                double x3 = x0 + h;
                double y3 = y0 - r1 + 2 * r2;
                double r3 = h * (Math.Sqrt(x3) * y3);
                Console.WriteLine("| " + j + "\t|" + x0 + "\t|" + y0 + "\t|" + f + "\t|" + r1 + "\t|" + x2 + "\t|" + y2 + "\t|" + r2 + "\t|" + x3 + "\t|" + y3 + "\t|" + r3 + "\t|");
                x0 += h;
                y0 += 1 / 6 * (r1 + 4 * r2 + r3);
            }

            Console.ReadKey();
        }
        
    }
}
