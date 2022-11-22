using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {//Вывести энное чило последовательности фибоначи
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int fb1 = 1;
            int fb2 = 1;
            int sum = 0;



            for (int i = 1; i <= n; i++)
            {
                fb1 = fb2;
                fb2 = sum;
                sum = fb1 + fb2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
