using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Homework5_
{
    internal class Program
    {   static void SieveEratosthen(long n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The closest prime number to {n} is 2");
            } else
            {
                bool[] primes = new bool[2 + n * n];
                for (long i = 0; i < primes.Length; i++)
                {
                    if (i <= 1)
                    {
                        primes[i] = false;
                    }
                    else
                    {
                        primes[i] = true;
                    }
                }

                for (long i = 2; i < primes.Length; ++i)
                {
                    if (primes[i])
                    {
                        for (long j = i; i * j < primes.Length; ++j)
                        {
                            primes[i * j] = false;
                        }
                    }
                }

                var PrimeNumbers = new List<long>();
                for (int i = 2; i < primes.Length; i++)
                {
                    if (primes[i])
                    {
                        PrimeNumbers.Add(i);
                    }
                }

                long less = n - 1;
                long more = n + 1;

                do
                {
                    if (PrimeNumbers.Contains(more) == true)
                    {
                        Console.WriteLine($"The closest prime number to {n} is {more}");
                        break;
                    }
                    else if (PrimeNumbers.Contains(less) == true)
                    {
                        Console.WriteLine($"The closest prime number to {n} is {less}");
                        break;
                    }
                    else
                    {
                        ++more;
                        --less;
                    }
                } while (less > 0);
            }

               
            
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            SieveEratosthen(number);
            
            
            Console.ReadKey();
        }
    }
}
