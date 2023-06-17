using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework4__
{
    internal class Program
    {
        static void SwapOfRows(int[,] mas,int colums, int rows) 
        {
            
            int[] LastRow = new int[colums];
            int[] holder1 = new int[colums];
            int[] holder2 = new int[colums];

            for (int i = rows - 1; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    LastRow[j] = mas[i, j];
                }
            }

            Console.WriteLine("Swapped array:");

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    
                    if (i == 0)
                    {
                        holder1[j] = mas[i, j];
                        mas[i, j] = LastRow[j];
                    } else
                    {
                        holder2[j] = mas[i, j];
                        mas[i, j] = holder1[j];
                        holder1[j] = holder2[j];
                    }
                    Console.Write($"{mas[i, j]} "); 
                    
                }
                Console.WriteLine();
            }        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of colums");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, colums];
            Random rnd = new Random();

            Console.WriteLine("Array:");
            for (int i =  0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    array[i, j] = rnd.Next(1, 20);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            SwapOfRows(array, colums, rows);

            Console.ReadKey();
        }
    }
}
