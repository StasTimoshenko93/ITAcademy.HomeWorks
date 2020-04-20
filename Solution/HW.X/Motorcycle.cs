using System;
using System.Collections.Generic;
using System.Text;

namespace HW.X
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Odometr { get; set; }

        public Motorcycle(int id, string name, string model, DateTime year, int odometr)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometr = odometr;
        }

    }
}
