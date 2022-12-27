using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string WordToChange = "апельсин";

            string ChangedWord1 = WordToChange[5] + WordToChange[1] + WordToChange[0] + WordToChange[7] + WordToChange[6] + WordToChange[2] + WordToChange.Trim(new char[] { 'а', 'п', 'е', 'с', 'и', 'н' });
            Console.WriteLine(ChangedWord1);

            string ChangedWord2 = WordToChange.Remove(3, 5) + WordToChange[7] + WordToChange[4];
            Console.WriteLine(ChangedWord2.Substring(1));
        }
    }
}
