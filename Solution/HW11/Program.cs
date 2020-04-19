using System;
using System.Collections.Generic;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info(System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName);
            Logger.Log.Info("Create objects");
            Circle circle = new Circle(4);
            Square square = new Square(5);
            Triangle triangle = new Triangle(5, 4);
            List<Shape> listobj = new List<Shape> { circle, square, triangle };
            Logger.Log.Info("The process of outputting data to the Console has begun");

            try
            {
                foreach (var item in listobj)
                {

                    Console.WriteLine($"This is {item.Name}. CLR Type is {item.GetType()}. Square is {item.GetArea()}");
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            Logger.Log.Info("Program completed successfully");
        }
    }
}
