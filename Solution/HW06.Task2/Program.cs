using System;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputArray = new int[5];

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                Console.WriteLine("Input a number to Array");
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Inputed Array\n{ string.Join(", ", inputArray)}");
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input an index");
            int index = Convert.ToInt32(Console.ReadLine());
            AddNewNum(inputArray, num, index);
            Console.WriteLine($"Inputed Array\n{ string.Join(", ", inputArray)}");
        }

        static int[] AddNewNum(int[] array, int num, int index)
        {

            for (int i = array.Length - 2; i >= index - 1; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = num;
            return array;
        }
    }
}
