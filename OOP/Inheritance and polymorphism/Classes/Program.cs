using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Automobile
    {
        private string name;
        private int maxSpeed;

        public Automobile(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

        public Automobile()
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set 
            { 
                this.name = value; 
            }
        }

        public int MaxSpeed
        {
            get
            {
                return this.maxSpeed;
            }

            set
            {
                if (value > 0)
                {
                    this.maxSpeed = value;
                } else
                {
                    Console.WriteLine("Error!");
                }
                
            }
        }

        public static void InitializeComponents(Automobile auto)
        {
            Console.WriteLine("Enter the name of the auto");
            auto.name = Console.ReadLine();
            Console.WriteLine("Enter max speed of the auto");
            auto.maxSpeed = int.Parse(Console.ReadLine());
        }
    }

    class Car : Automobile
    {
        private int num;

        public Car (string name, int maxSpeed, int num)
            :base(name, maxSpeed)
        {
            this.num = num;
        }

        public int Num
        {
            get
            {
                return this.num;
            }

            set
            {
                if(value > 0)
                {
                    this.num = value;
                } else
                {
                    Console.WriteLine("Error!");
                }
            }
        }

        public Car()
        {

        }

        public static void InitializeComponents(Car car)
        {
            Console.WriteLine("Enter the name of the car");
            car.Name = Console.ReadLine();
            Console.WriteLine("Enter max speed of the car");
            car.MaxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num of passengers");
            car.Num = int.Parse(Console.ReadLine());

        }

       

    }

    class Vehicle : Automobile
    {
        private int weight;

        public Vehicle (string name, int maxSpeed,int weight)
            :base (name, maxSpeed) 
        {
            this.weight = weight;
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                if (value > 0)
                {
                    this.weight = value;
                } else
                {
                    Console.WriteLine("Error!");
                }
            }
        }

        public Vehicle()
        {

        }
        public static void InitializeComponents(Vehicle vehicle)
        {
            Console.WriteLine("Enter the name of the vehicle");
            vehicle.Name = Console.ReadLine();
            Console.WriteLine("Enter max speed of the vehicle");
            vehicle.MaxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight");
            vehicle.Weight = int.Parse(Console.ReadLine());

        }
    }


    
    internal class Program
    {     
        static void Main(string[] args)
        {

            Automobile[] cars = new Automobile[2];
            Car car = new Car();
            Car.InitializeComponents(car);
            Vehicle vehicle = new Vehicle();
            Vehicle.InitializeComponents(vehicle);
            cars[0] = car;    
            cars[1] = vehicle;

            if (cars[0].MaxSpeed > cars[1].MaxSpeed)
            {
                Console.WriteLine($"The name of the car is: {car.Name} \nMax speed of the car is: {car.MaxSpeed} \nThe car can accommodate {car.Num} people");
            } else
            {
                Console.WriteLine($"The name of the car is: {vehicle.Name} \nMax speed of the car is: {vehicle.MaxSpeed} \nThe weight is luggage which car can carry is: {vehicle.Weight}");
            }
            
         
            Console.ReadKey();
            
            
        }
    }
}
