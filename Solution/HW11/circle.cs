using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
   public class Circle : Shape
    {
      public Circle(int value)
        {
            Value = value;
            Name = "Круг";
        }
        public override double GetArea()
        {
            return Math.PI*Math.Pow(Value,Value);
        }
    }

    
}
