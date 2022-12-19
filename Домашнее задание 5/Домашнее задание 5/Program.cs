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

            double a = Program.Formula(2, 5);
            double b = Program.Formula(3, 7);
            double c = Program.Formula(5,11);

            double x = a + b + c;

            Console.WriteLine(Math.Round(x, 2));

        }
        static double Formula(double y, double z)
        {
            return (y + Math.Sin(y)) / (z + Math.Cos(z));
        }
    }
}
