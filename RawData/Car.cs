using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; }

        public Car(string model, Engine engine, Cargo cargo,List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Model} {Engine.Speed} {Engine.Power} {Cargo.Weight} {Cargo.CargoType} ");
            for (int i = 0; i < Tires.Count; i++)
            {
                sb.Append($"{Tires[i].Pressure} {Tires[i].Age}");
            }
            return sb.ToString();
        }
    }
}
