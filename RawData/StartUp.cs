using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];

                List<Tire> tires = ReadTires(input);
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            var command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType == "fragile")
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Pressure<1)
                            {
                                Console.WriteLine($"{car.Model}");
                                break;
                            }
                        }
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType == "flamable" && car.Engine.Power >250)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
        }

        private static List<Tire> ReadTires(string[] input)
        {
            List<Tire> tires = new List<Tire>();

            for (int i = 5; i < input.Length; i=i+2)
            {
                double tirePressure = double.Parse(input[i]);
                int tireAge = int.Parse(input[i+1]);
                var tire = new Tire(tirePressure, tireAge);
                tires.Add(tire);
            }
            return tires;
        }
    }
}
