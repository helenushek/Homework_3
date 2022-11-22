using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{//Вывести количество целых положительных чисел, квадрат которых меньше a
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            Console.WriteLine("Введите число a");
            a = Convert.ToInt32(Console.ReadLine());

            int counter=0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    {
                        counter++;
                        
                    }

                }
                
            }
            Console.WriteLine($"Количество положительных целых чисел квадрат которых меньше a {counter}");
        }
    }
}
