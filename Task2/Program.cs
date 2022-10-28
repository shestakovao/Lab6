using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.");
            string startString = Console.ReadLine();
            startString = startString.Replace(" ", "");//удаляем пробелы из строки
            startString = startString.ToLower();//переводим все символы в нижний регистр
            string convertString = "";
            foreach (char c in startString)//получаем обратную строку
            {
                convertString = c + convertString;
            }

            if (convertString == startString)//сравниваем обе строки
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение НЕ является палиндромом");
            }

            Console.ReadKey();  
        }
    }
}
