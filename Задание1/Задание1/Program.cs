using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Владимир Маяковский");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Послушайте!(отрывок)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nПослушайте!\nВедь если звёзды зажигают -\nзначит - это кому-нибудь нужно?\nЗначит - кто-то хочет, чтобы они были?\nЗначит кто-то называет эти плевочки жемчужиной?");
            Console.ResetColor();
        }
    }
}
