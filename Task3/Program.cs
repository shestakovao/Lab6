using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку S");
            string s = Console.ReadLine();

            //Проверка совпадает количество открывающих и закрывающих символов
            int countOpen = 0;
            int countClose = 0;
            foreach (char c in s)
            {
                if (c == '{') 
                { 
                    countOpen++; 
                }
                if (c == '}')
                {
                    countClose++;
                }
            }
            //Проверка совпадает количество открывающих и закрывающих символов



            if (countOpen != countClose)
            {
                Console.WriteLine("Не совпадает количество открывающих и закрывающих скобок");
            }
            else
            {
                int findEnd, findStart;

                while ((s.IndexOf("{") > -1)) //пока в строке есть фигурные скобки выполняем цикл
                {
                    findEnd = s.IndexOf("}");
                    findStart = s.IndexOf("{");

                    if (findEnd < findStart)
                    {
                        Console.WriteLine("Открывающая и закрывающая скобки стоят не правильно");
                        findEnd = s.IndexOf("{");
                        findStart = s.IndexOf("}");

                        for (int i = s.IndexOf("}") + 1; i < s.IndexOf("{"); i++) //поиск если между } и { есть ещё закрывающая скобкаа то начало интервала переносим на неё получая тем самым закрытый интервал
                        {
                            if (s[i] == '}')
                            {
                                findStart = i;
                            }
                        }                    
                    }
                    else
                    {
                        for (int i = s.IndexOf("{") + 1; i < s.IndexOf("}"); i++) //поиск если между { и } есть ещё открывающая скобка то начало интервала переносим на неё получая тем самым закрытый интервал
                        {
                            if (s[i] == '{')
                            {
                                findStart = i;
                            }
                        }
                    }

                    //удаляем из строки найденный интервал открывающей и закрывающей скобки ближайщии к друг другу
                    s = s.Remove(findStart, findEnd-findStart+1);   

                }
                 Console.WriteLine(s);
            }
            
            Console.ReadKey();  

        }
    }
}
