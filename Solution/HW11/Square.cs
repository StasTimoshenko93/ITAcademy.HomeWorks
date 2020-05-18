using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    public class Square : Shape
    {
        public Square( int value)
        {
            Name = "Квадрат";
            Value = value;
        }
        public override double GetArea()
        {
            return  Math.Pow(Value, Value);
        }
    }
}
