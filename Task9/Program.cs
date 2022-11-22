using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {//Пользователь вводит 1 число. Найти количество нечетных цифр этого числа
       

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int number = 0;

            do
            {
                if (a % 2 != 0)
                {
                    number++;
                    a /= 10;
                }

                else
                {
                    a /= 10;
                }

            } 
            while (a >0);
            
            Console.WriteLine($"Количество нечетных цифр в этом числе - {number}");

        }
    }
}
