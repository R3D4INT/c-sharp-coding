using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть рядкiв");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть стовпчикiв");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] array  = new int[x, y];
           
            Random random = new Random();
            Console.WriteLine("Масив:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = random.Next(-50, 50);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            //Якщо значення масиву потрібно ввести самотужки

            //Console.WriteLine($"Введiть {x * y} елементiв");
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        array[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            int FirstRow = 0;
            int FirstRowSum = 0;
            do
            {
                FirstRowSum = FirstRowSum + array[0, FirstRow];
                FirstRow++;
            } while (FirstRow < y);

            int sumholder = FirstRowSum;
            int index = 0;
            for (int i = 0; i < x; i++)
            {               
                int sum = 0;
                for(int j = 0; j < y; j++)
                {
                    sum = sum + array[i, j]; 
                }
                if (i == 0)
                {
                    continue;
                } else {
                    if (sumholder < sum)
                    {
                        sumholder = sum;
                        index = i;
                    }
                }

            }

            Console.WriteLine($"Максимальну сумму елементiв має рядок номер {index + 1} (за iндексом) {index}");

            Console.ReadKey();
        }
    }
}
