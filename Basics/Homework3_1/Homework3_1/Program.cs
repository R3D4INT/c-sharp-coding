using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть кiлькiсть рядкiв");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть стовпчикiв");
            int y = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[,] mas = new int[x, y];
            Console.WriteLine("Масив:");           
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i, j] = random.Next(-5000, 5000);
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }

            int MaxNumber = mas[0, 0]; 
            int MinNumber = mas[0,0];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (MaxNumber < mas[i, j])
                    {
                        MaxNumber = mas[i, j];
                    } 
                    
                    if (MinNumber > mas[i, j])
                    {
                        MinNumber = mas[i, j];
                    }
                }              
            }
            int sum = MaxNumber + MinNumber;
            Console.WriteLine($"Максимальний елемент масиву: {MaxNumber} \nМiнiмальний елемент масиву: {MinNumber} \n Сумма цих елементiв: {sum}");


            Console.ReadKey();
        }
    }
}
