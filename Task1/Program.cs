using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение (Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.)");
            String startString = Console.ReadLine();
            String[] strigArray = startString.Split();
            String longestString = strigArray[0];
            foreach (String str in strigArray)
            {
                if (longestString.Length < str.Length)
                { 
                    longestString = str;    
                }
            }

            Console.WriteLine("Саммое длинно слово в предложении:{0}",longestString);   
            Console.ReadKey();
        }
    }
}
