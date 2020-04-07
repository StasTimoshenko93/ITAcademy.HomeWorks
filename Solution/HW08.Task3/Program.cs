using System;
using System.Text;

namespace HW08.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder givenstring = new StringBuilder("1a!2.3!!.. 4.!.? 6 7!..?");

            int i = 0;
            while (!givenstring[i].Equals('?'))
            {
                i++;
            }
            givenstring.Replace("!", string.Empty, 0, i);

            int i2 = 0;
            while (!givenstring[i2].Equals('?'))
            {
                i2++;
            }
            givenstring.Replace(".", string.Empty, 0, i2);

            int i3 = 0;
            while (!givenstring[i3].Equals('?'))
            {
                i3++;
            }
            givenstring.Replace(' ', '_', i3, givenstring.Length - i3);

            Console.WriteLine($"Done task 3: {givenstring}");
        }
    }
}
