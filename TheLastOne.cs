using System;
using System.Numerics;
using System.Linq;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class Car
    {
        public int Number { get; set; } 
        public List<Driver> Drivers {get; set; }
    }
    class Driver
    {
        public string DriverName { get; set; }
        public string DriverSurename { get; set; }
        public int CarNumber { get; set; }
    }

    class Class1
    {
        static void Main()
        {
            List<Car> cars = new List<Car>
            {
                new Car{Number = 1 },
                new Car{Number = 2 },
                new Car{Number = 3 },
            };
            List<Driver> drivers = new List<Driver>
            {
                new Driver{ DriverName = "Vyacheslav", DriverSurename = "Izengardovich", CarNumber = 3},
                new Driver{ DriverName = "Ivan", DriverSurename = "Ivanov", CarNumber = 1},
                new Driver{ DriverName = "San", DriverSurename = "Sanich", CarNumber = 2},
                new Driver{ DriverName = "Michael", DriverSurename = "Jackeson", CarNumber = 1},
                new Driver{ DriverName = "Janna", DriverSurename = "D'Arck", CarNumber = 3},
            };
            var guys = drivers.Where(m => m.CarNumber == 1);
            foreach (var asd in guys)
            {
                Console.WriteLine(asd.DriverName);
            }
            Driver driver = drivers.FirstOrDefault(d => d.DriverSurename == "Ivanov");
            if (driver != null)
            {
                Car ownerCar = cars.FirstOrDefault(c => c.Number == driver.CarNumber);
                Console.WriteLine(ownerCar.Number);
            }
            var filterSurename = drivers.Where(d => d.DriverSurename.StartsWith("I"));
            foreach(var asd in filterSurename)
            {
                Console.WriteLine(asd.DriverName);
            }
        }
    }
}
