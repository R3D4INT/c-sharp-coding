using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Graphs
{
    internal class Program
    {


        public static void matrixprint(int[,] mas)
        {
            Console.WriteLine("Матриця суміжності :");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)

                    Console.Write("{0, 4}", mas[i, j]);
                Console.WriteLine();

                Console.WriteLine();
            }
        }
        static int[,] Floyd_Fesher(int[,] mas)
        {
            

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (i != j && mas[i, j] == 0)
                    {
                        mas[i, j] = 100000000;
                    }                
                }
            }

            for (int p = 0; p < mas.GetLength(0); p++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(0); j++)
                    {
                        if (mas[i, p] + mas[p, j] < mas[i, j])
                        {
                            mas[i, j] = mas[i, p] + mas[p, j];
                        }
                    }
                }
            }
            return mas;
        }

            static void Main(string[] args)
            {

                int[,] mas = new int[6, 6]
               {
            {0, 7, 9, 0, 0, 14 },
            {7, 0, 10, 15, 0, 0 },
            {9, 10, 0, 11, 0, 2 },
            {0, 15, 11, 0 , 6 ,0 },
            {0, 0, 0, 6, 0, 9 },
            {14, 0, 2, 0, 9, 0},
               };

                matrixprint(mas);
                matrixprint(Floyd_Fesher(mas));

                Console.ReadKey();


            }
         
    }
}
