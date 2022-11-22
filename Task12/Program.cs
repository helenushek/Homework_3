using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    //Пользователь вводит 2 числа.
    //Сообщите, есть ли в написании двух чисел одинаковые цифры.
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число A");
            string userEnterA = Console.ReadLine();
            Console.WriteLine("Введите число B");
            string userEnterB = Console.ReadLine();
            char c;
            char d;

            for (int i = 0; i != userEnterA.Length; i++)
            {
                c = userEnterA[i];

                for (int j = 0; j != userEnterB.Length; j++)
                {
                    d = userEnterB[j];
                    if (c == d)
                    {
                        Console.WriteLine("да");
                        return;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
