using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите минимальное чило ");
                int countMin = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальное чило ");
                int countMax = int.Parse(Console.ReadLine());
                int p = luckyCount(countMin,countMax);
                Console.WriteLine($"Счастливых чисел в данном диапазоне {p}");
                Console.ReadKey();
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
        static int luckyCount(int a, int b)
        {
            int j = 0;
            for (int i = a; i <= b; i++)
            {
                if (i / 100000 + i / 10000 % 10 + i / 1000 % 10 == i / 100 % 10 + i / 10 % 10 + i % 10)
                {
                    Console.WriteLine(i + " ");
                    j++;
                }
                  
            }
            return j;
        }
    }
}
