using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    //Вывести сумму чисел в диапозоне от a до b которые без остатка делятся на 7, учитывая то, что b может быть меньше a
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            if (a > b)
            {
                (a, b) = (b, a);

            }
            for (int i = a; b >= i; i++)
            
            {
                if (i % 7 == 0)
                {
                    sum += i; 

                }
            } 
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
