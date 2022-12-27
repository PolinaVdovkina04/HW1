using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском языке");
            UserInput();//считывать пользовательский текст
            Console.WriteLine("Перевод на Leet:" + Translating());
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
            TranslatedInput = TranslatedInput.Replace("A","4");
            TranslatedInput = TranslatedInput.Replace("B","8");
            TranslatedInput = TranslatedInput.Replace("C","(");
            TranslatedInput = TranslatedInput.Replace("D","|)");
            TranslatedInput = TranslatedInput.Replace("E","3");
            TranslatedInput = TranslatedInput.Replace("F","|=");
            TranslatedInput = TranslatedInput.Replace("G","6");
            TranslatedInput = TranslatedInput.Replace("H","|-|");
            TranslatedInput = TranslatedInput.Replace("I","!");
            TranslatedInput = TranslatedInput.Replace("J",")");
            TranslatedInput = TranslatedInput.Replace("K","|<");
            TranslatedInput = TranslatedInput.Replace("L","1");
            TranslatedInput = TranslatedInput.Replace("M","|\\/|");
            TranslatedInput = TranslatedInput.Replace("N","|\\|");
            TranslatedInput = TranslatedInput.Replace("O","0");
            TranslatedInput = TranslatedInput.Replace("P","|>");
            TranslatedInput = TranslatedInput.Replace("Q","9");
            TranslatedInput = TranslatedInput.Replace("R","|2");
            TranslatedInput = TranslatedInput.Replace("S","5");
            TranslatedInput = TranslatedInput.Replace("T","7");
            TranslatedInput = TranslatedInput.Replace("U","|_|");
            TranslatedInput = TranslatedInput.Replace("V","\\/");
            TranslatedInput = TranslatedInput.Replace("W","\\/\\/");
            TranslatedInput = TranslatedInput.Replace("X","><");
            TranslatedInput = TranslatedInput.Replace("Y","'/");
            TranslatedInput = TranslatedInput.Replace("Z","2");
            return TranslatedInput;
        }
        
    }
}
