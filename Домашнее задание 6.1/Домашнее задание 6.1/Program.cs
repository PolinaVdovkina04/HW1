using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском языке");
            UserInput();
            Console.WriteLine(Translating());
        }
        static string UserInput()
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            return input;
        }
        static string Translating()
        {
            string TranslatedInput = UserInput();
            TranslatedInput = TranslatedInput.Replace("a", "4");
            TranslatedInput = TranslatedInput.Replace("b", "8");
            TranslatedInput = TranslatedInput.Replace("c", "(");
            TranslatedInput = TranslatedInput.Replace("d", "|)");
            TranslatedInput = TranslatedInput.Replace("e", "3");
            TranslatedInput = TranslatedInput.Replace("f", "|=");
            TranslatedInput = TranslatedInput.Replace("g", "6");
            TranslatedInput = TranslatedInput.Replace("h", "|-|");
            TranslatedInput = TranslatedInput.Replace("i", "!");
            TranslatedInput = TranslatedInput.Replace("j", ")");
            TranslatedInput = TranslatedInput.Replace("k", "|<");
            TranslatedInput = TranslatedInput.Replace("l", "1");
            TranslatedInput = TranslatedInput.Replace("m", "|\\/|");
            TranslatedInput = TranslatedInput.Replace("n", "|\\|");
            TranslatedInput = TranslatedInput.Replace("o", "0");
            TranslatedInput = TranslatedInput.Replace("p", "|>");
            TranslatedInput = TranslatedInput.Replace("q", "9");
            TranslatedInput = TranslatedInput.Replace("r", "|2");
            TranslatedInput = TranslatedInput.Replace("s", "5");
            TranslatedInput = TranslatedInput.Replace("t", "7");
            TranslatedInput = TranslatedInput.Replace("u", "|_|");
            TranslatedInput = TranslatedInput.Replace("v", "\\/");
            TranslatedInput = TranslatedInput.Replace("w", "\\/\\/");
            TranslatedInput = TranslatedInput.Replace("x", "><");
            TranslatedInput = TranslatedInput.Replace("y", "'/");
            TranslatedInput = TranslatedInput.Replace("z", "2");
            return TranslatedInput;
        }
    }
}
