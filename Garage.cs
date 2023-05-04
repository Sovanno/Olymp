using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Timers;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace ConsoleApp4
{
    public delegate int WashAll();
    public class Car
    {
        public string mark { get; set; }
        public string numer { get; set; }

    }

    public class Garage
    {
        public List<Car> cars = new List<Car>();
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }
    }

    public class CarWash
    {
        private Garage garage;
        public CarWash(Garage garage)
        {
            this.garage = garage;
        }

        public void Wash(Car car)
        {
            Console.WriteLine($"Помыли машину {car.mark}");
        }
        public void WashAll()
        {
            foreach (Car car in garage.cars)
            {
                Console.WriteLine($"Помыли машину {car.mark}");
            }
        }
    }


    class tests
    {
        static void Main()
        {
            Car car1 = new Car { mark = "Toyota", numer = "00001"};
            Car car2 = new Car { mark = "Honda", numer = "12345"};
            Car car3 = new Car { mark = "Chevrolet", numer = "41242"};
            Garage garage = new Garage();
            garage.AddCar(car1);
            garage.AddCar(car2);
            garage.AddCar(car3);
            CarWash carWash = new CarWash(garage);
            carWash.Wash(car1);
            Console.WriteLine();
            carWash.WashAll();
            garage.RemoveCar(car3);
            Console.WriteLine();
            carWash.WashAll();
        }
    }
}
