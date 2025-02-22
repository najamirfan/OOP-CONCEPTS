using System;

namespace OOPINHERITANCE1
{
    class Vehicle
    {
        protected string CompanyName { get; set; }
        public string Color { get; set; }
        public double CC { get; set; }
        public string Vehicle_Type { get; set; }

        public Vehicle(string company_name, string color, double cc, string vehicletype)
        {
            CompanyName = company_name;
            Color = color;
            CC = cc;
            Vehicle_Type = vehicletype;

        }

        public virtual string GetDetails()
        {
            return $" Color:{Color}\nCC:{CC}\nType:{Vehicle_Type}\n Company Name:{CompanyName}\n";
        }
    }

    class Car: Vehicle
    {
        public Car(string color, double cc) : base("Honda", color, cc, "Car") { }

    }

    class Truck: Vehicle
    {
        public Truck(string color, double cc) : base("Honda", color, cc, "Truck") { }

    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car("Red", 1500);
            Console.WriteLine("CAR CLASS");
            Console.WriteLine(myCar.GetDetails()); // Print all details

            Truck mytruc = new Truck("black", 3000);
            Console.WriteLine("TRUCK CLASS");
            Console.WriteLine(mytruc.GetDetails()); //print all detail using truck class
        }
    }
}
