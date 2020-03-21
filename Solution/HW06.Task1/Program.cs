using System;

namespace HW06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[5];
            int[] inputArray = new int[5];
            int[] sumArray = new int[5];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = new Random().Next(1, 5);
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine("Input a number");
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = randomArray[i] + inputArray[i];
            }

            Console.WriteLine($"Random Array\n{ string.Join(", ", randomArray)}");
            Console.WriteLine($"inputed Array \n{string.Join(", ", inputArray)}");
            Console.WriteLine($"Sum of Array \n{string.Join(", ", sumArray)}");
        }
    }
}
