using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            double x = double.Parse(Console.ReadLine());

            double y = Math.Sqrt(Math.Pow(2,Math.Pow(x,x)) + Math.Pow(x,Math.Pow(2,x)) + Math.Pow(x,Math.Pow(x,2)));

            Console.WriteLine("y = " + y);
        }
    }
}
