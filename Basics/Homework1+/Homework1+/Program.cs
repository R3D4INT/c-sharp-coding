using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть трьохзначне число");
            int num = Convert.ToInt32(Console.ReadLine()); ; 
            List<int> numbers = new List<int>();
            string ResultHolder = "";
            int result;
            // Цей код працює і для інших чисел, але завдання полягало саме у трьохзначних, тому є закоментований код саме для трьохзначних чисел
           //while (num < 99 || num > 999)
           // {
           //     Console.WriteLine("Введене число не є трьохзначим, введiть трьохзначне число");
           //     num = Convert.ToInt32(Console.ReadLine()); ;
           // }          
            do
            {
                if (num < 10)
                {
                    numbers.Add(num);
                    break;
                }
                int holder = num % 10;
                    numbers.Add(holder);
                    num = num - holder;
                    num /= 10;
                   
            } while (num > 0);
                numbers.Sort();
                numbers.Reverse();           
                for (int i = 0;  i < numbers.Count; i++)
               {
                ResultHolder = ResultHolder + numbers[i];
               }
            result = Convert.ToInt32(ResultHolder);
            Console.Write($"Максимальне можливе число: {result}");

            Console.ReadKey();
        }
    }
}
