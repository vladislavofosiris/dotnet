using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Car
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private int _carId;
        public int CarId
        {
            get
            {
                return _carId;

            }
            set
            {
                _carId = value;
            }

        }
        private string _number;
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        private object _date;
        public object Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public Car(string _name, int _carId, string _number, object date)
        {
            Name = _name;
            CarId = _carId;
            Number = _number;
            Date = _date;
        }
        static void Voice(int a)
        {
            if (a == 1)
            {
                Console.WriteLine($"Bip Bip Bip");
            }

        }
        static void Speed(int step)
        {
            int speed = 0;
            do
            {

                Console.WriteLine(speed);
                speed += step;
                Console.ReadKey();
                try
                {
                    if (speed >= 100)
                    {
                        throw new Exception("Speed limit is broken");

                    }
                    else if (speed < 70)
                    {
                        throw new Exception("You move slowly");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Warning:" + ex.Message);
                }
            }
            while (speed < 120);

            do
            {
                Console.WriteLine(speed);
                speed -= step;
                Console.ReadKey();

            }
            while (speed >= 100);
            }
    }
    class Factory
    {
       static void CreateNewCar()         
        {
            Console.WriteLine($"Name:");
            string n=Console.ReadLine();
            Console.WriteLine($"ID:");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number");
            string N=Console.ReadLine();
            Console.WriteLine($"Day:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Month:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Year:");
            int y = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(d, m, y);
            object D= date;
            Car c1 = new Car(n,id,N,D);
      
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Choose option");
            Console.WriteLine($"1.Make a Voice");
            Console.WriteLine($"2.Run");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine($"Push 1 for make a voice");
                int a = Convert.ToInt32(Console.ReadLine());
                Voice(a);
            }
            if (op == 2)
            {
                Console.WriteLine($"Set a step");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Let`s GO");
                Speed(b);
                
            }
            Console.ReadKey();
        }
        static void Voice(int a)
        {
        if (a==1)
            {
                Console.WriteLine($"Bip Bip Bip");
            }

        }
        static void Speed(int step)
        {
            int speed = 0;
            do
            {

                Console.WriteLine(speed);
                speed += step;
                Console.ReadKey();
                try
                {
                    if (speed >= 100)
                    {
                        throw new Exception("Speed limit is broken");
                        
                    }
                    else if (speed<70)
                    {
                        throw new Exception("You move slowly");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Warning:" + ex.Message);
                }
            }
            while (speed < 120);

            do
            {
                Console.WriteLine(speed);
                speed-=step;
                Console.ReadKey();

            }
            while (speed >= 100);

            

                        
                             
            

            

        }
    }
}
