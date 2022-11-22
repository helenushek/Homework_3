using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{//Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число y");

            int y = Convert.ToInt32(Console.ReadLine());
            

            int left = 0;
            int right = y;
            int middle = right;

            while (y!= Math.Pow(middle, 3))
            {
                if (Math.Pow(middle, 3)>y)
                {
                    right = middle;
                }
                
                else
                {
                    left = middle;
                }
                middle = (left + right) / 2;

            }

            Console.WriteLine($"Это число является кубом числа {middle}");

        }
    }
}
