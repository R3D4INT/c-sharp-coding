using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fhgdhf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix = new int[6, 6];
            int[,] matrix1 = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                int[] Graph = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = Graph[j];
                }
            }

            Floyd(6, matrix, matrix1);
        }
        static void Floyd(int n, int[,] ShortestPath, int[,] matrix)
        {
            int i, j, k;
            int Max_Sum = 0;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    Max_Sum += ShortestPath[i, j];
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    if (ShortestPath[i, j] == 0 && i != j)
                    {

                        ShortestPath[i, j] = Max_Sum;
                    }

            for (k = 0; k < n; k++)
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        if ((ShortestPath[i, k] + ShortestPath[k, j]) <
                             ShortestPath[i, j])
                        {
                            ShortestPath[i, j] = ShortestPath[i, k] + ShortestPath[k, j];
                            matrix[i, j] = k;
                        }

            Console.WriteLine(ShortestPath[4, 3] + " ");
            Console.WriteLine(matrix[4, 3]);
        }
    }
}
