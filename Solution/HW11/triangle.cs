using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    public class Triangle : Shape
    {
        public int Height { get; set; }
        public Triangle(int value, int height)
        {
            Name = "Треугольник";
            Value = value;
            Height = height;
        }
        public override double GetArea()
        {
            return 0.5 * Value*Height;
        }
    }
}
