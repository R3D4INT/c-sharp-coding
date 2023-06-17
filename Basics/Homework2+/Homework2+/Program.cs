using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            uint num = Convert.ToUInt32(Console.ReadLine());
            uint result =  0;
            List<uint> numbers = new List<uint>();
            do
            {              
                uint holder = num % 10;
                numbers.Add(holder);
                num = num - holder;
                num /= 10;
            } while (num > 0);

            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine($"Сумма цифр данного числа: {result}");

            Console.ReadKey();
        }
    }
}
