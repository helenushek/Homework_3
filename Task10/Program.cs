using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    //Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int result = 0;
            int count = 0;

            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            int number1 = number;


            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            for (int i = 0; i < number1; i++) 
            {
                while (number1 > 0)
                {
                    if (number1 % 10 == 0)
                    {
                        count++;
                    }
                    number1 /= 10;
                    if (number1 % 10 != 0)
                        break;
                }
               
                   
            } 
            int length = $"{number}".Length;
            string line = $"{number}".PadLeft(length + count);

            Console.WriteLine($"Зеркальное отображение числа - {line}{result}");
        }
    }
}
        
    


    

