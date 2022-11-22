using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_3
{//Вывести число, которое получается при возведении в степень b числа a
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int s=1;

            Console.WriteLine("Введите число 1");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=b; i++)
            {
                s *= a;
            }

            Console.WriteLine($"Число 1 в степени числа 2 = {s}");
        }
    }
}
