using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число");
            int a = int.Parse(Console.ReadLine());

            int x = (a % 100) * 10 + (a / 100);

            Console.WriteLine("Полученное число: " + x);
        }
    }
}
