using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{//Вывести наибольший делитель числа а
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = a-1; i > 1; i--)
            {

                if (a % i == 0)
                {
                   
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
        }
    }
}
