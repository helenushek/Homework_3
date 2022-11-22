using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{//Вывести все числа от 1 до 1000, которые делятся на a
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            

            Console.WriteLine("Введите число a");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 1000; i++) 

            {
                if (i % a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
