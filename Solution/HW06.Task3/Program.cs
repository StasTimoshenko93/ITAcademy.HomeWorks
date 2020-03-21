using System;
using System.Diagnostics;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        { // used self reverse method.
            #region Create Arrays
            int[] randomArray = new int[100000000];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = new Random().Next(1, 5);
            }
            Console.WriteLine($"Random Array\n{ string.Join(", ", randomArray)}");

            // used Reverse() method
            //int[] reverseArray = new int[100000000];
            //for (int i = 0; i < reverseArray.Length; i++)
            //{
            //    reverseArray[i] = new Random().Next(1, 5);
            //}
            //Console.WriteLine($"Reverse Array\n{ string.Join(", ", reverseArray)}");
            #endregion

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Array.Reverse(reverseArray);
            int constNum = randomArray.Length / 2;

            for (int i = 0, j = randomArray.Length - 1; i <= constNum; i++, j--)
            {
                int temp = randomArray[i];
                randomArray[i] = randomArray[j];
                randomArray[j] = temp;
            }
            stopwatch.Stop();
            long milsek = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Random Array\n{string.Join(", ", randomArray)}");
            Console.WriteLine($"My Method take time:{milsek}");
            //Console.WriteLine($"Reverse Array\n{string.Join(", ", reverseArray)}");
            //Console.WriteLine($"Reverse() take time:{milsek}");

        }
    }
}
