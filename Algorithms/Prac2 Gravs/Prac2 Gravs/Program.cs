using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2_Gravs
{
    internal class Program
    {
        public static int[,] mas = new int[6, 6]
        {
            {0, 7, 9, 0, 0, 14 },
            {7, 0, 10, 15, 0, 0 },
            {9, 10, 0, 11, 0, 1 },
            {0, 15, 11, 0 , 6 ,0 },
            {0, 0, 0, 6, 0, 9 },
            {14, 0, 2, 0, 9, 0},
        };

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

        public static void dijkstra(int start, int[,] mas)
        {
            start--;
            const int n = 6;
            int[] dist = new int[n];
            int[] parent = new int[n];

            bool[] processed = new bool[n] { false, false, false, false, false, false};
            for (int i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
            }

            dist[start] = 0;
            int cur = start;
            parent[start] = start;

            while (!processed[cur])
            {
                processed[cur] = true;
                for (int i = 0; i < n; i++)
                {
                    if (mas[cur, i] != 0)
                    {
                        int d = dist[cur] + mas[cur, i];
                        if (d < dist[i])
                        {
                            dist[i] = d;
                            parent[i] = cur;
                        }
                    }
                }

                int min_dist = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    if (!processed[i] && dist[i] < min_dist)
                    {
                        cur = i;
                        min_dist = dist[i];
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Вiдстань вiд вершини {start + 1} до {i + 1} дорiвнює {dist[i]}");
                int finish = i;
                Console.Write($"{finish + 1}");

                while (parent[finish] != start)
                {
                    finish = parent[finish];
                    Console.Write($" <= {finish + 1}");
                }
                Console.WriteLine($" <= {start + 1}");
            }

           
        }
        static void Main(string[] args)
        {

              int[,] mas = new int[6, 6]
            {
            {0, 7, 9, 0, 0, 14 },
            {7, 0, 10, 15, 0, 0 },
            {9, 10, 0, 11, 0, 1 },
            {0, 15, 11, 0 , 6 ,0 },
            {0, 0, 0, 6, 0, 9 },
            {14, 0, 2, 0, 9, 0},
            };
            matrixprint(mas);
            Console.WriteLine("Введiть номер стартової вершини");
            int start = int.Parse(Console.ReadLine());
            dijkstra(start, mas);
            Console.ReadKey();

        }
    }
}
