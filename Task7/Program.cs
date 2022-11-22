using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {//Наибольший общий делитель методом Евклида
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            Console.WriteLine($"Наибольший общий делитель - {a}");
        }
    }
}
