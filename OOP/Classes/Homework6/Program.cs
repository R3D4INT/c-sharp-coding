using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Car
    {
        private string name;
        private int maxspeed;

        public Car (string name, int maxspeed)
        {
            this.name = name;
            this.maxspeed = maxspeed;
        } 

        public Car ()
        {
            
        }
        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxspeed;
            }

            set
            {
               if (value > 0)
                {
                    maxspeed = value;
                } else
                {
                    Console.WriteLine("Error!");
                }
            }
        }

        public static void MaxSpeedCompare (Car car1, Car car2)
        {
             if (car1.MaxSpeed > car2.MaxSpeed)
            {
                Console.WriteLine($"{car1.Name} is faster than {car2.Name}");
            } else
            {
                Console.WriteLine($"{car2.Name} is faster than {car1.Name}");
            }
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();

            Console.WriteLine("Enter the name of first car");
            car1.Name = Console.ReadLine();
            Console.WriteLine("Enter the name of second car");
            car2.Name = Console.ReadLine();
            Console.WriteLine("Enter the maxspeed of first car");
            car1.MaxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maxspeed of the second car");
            car2.MaxSpeed = Convert.ToInt32(Console.ReadLine());

            Car.MaxSpeedCompare(car1, car2);

            Console.ReadKey();
        }
    }
}
