using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    //Пользователь вводит целое положительное число (N). Выведите числа в диапазоне от 1 до N,
    //сумма четных цифр которых больше суммы нечетных.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum1;
            int sum2;
            int k;


            for (int i = 1; i < n; i++)
            {
                k = i;
                sum1 = 0;
                sum2 = 0;
                while (k > 0)
                {
                    if (k % 2 == 0)
                    {
                        sum1 += k % 10;
                        k /= 10;
                    }

                    else
                    {
                        sum2 += k % 10;
                        k /= 10;
                    }
                }
                if (sum1 > sum2)
                {
                    Console.WriteLine(i);
                }






            }
        }
    }
}


