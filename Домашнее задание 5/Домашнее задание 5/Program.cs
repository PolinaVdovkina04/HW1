using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Formula(2, 5, 5) + Formula(3, 7, 5) + Formula(5, 11, 11);

            Console.WriteLine(Math.Round(x, 3));
        }
        static double Formula(double y, double z, double w)
        {
            return (y + Math.Sin(y)) / (z + Math.Cos(w));
        }
    }
}
