using System;

namespace HW05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start game");
            Console.WriteLine("push the button");
            Console.WriteLine("push q to finish game");
            bool flag = true;
            while (flag)
            {
                string pushButton = Console.ReadLine().ToLower();
                switch (pushButton)
                {
                    case "w":
                        Console.WriteLine("go straight");
                        break;
                    case "s":
                        Console.WriteLine("go back");
                        break;
                    case "a":
                        Console.WriteLine("turn left");
                        break;
                    case "d":
                        Console.WriteLine("turn right");
                        break;
                    case "q":
                        Console.WriteLine("Game over");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("do nothing");
                        break;
                }
            }
        }
    }
}    
