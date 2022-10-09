using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра тетраэдра");
            double a = double.Parse(Console.ReadLine());

            double s = Math.Sqrt(3) * a * a;
            double v = (Math.Sqrt(2) * a * a * a)/12;

            Console.WriteLine("Площадь тэтраэдра: " + s);
            Console.WriteLine("Объем тэтраэдра: " + v);
        }
    }
}
