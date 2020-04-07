using System;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet="";
            for (int i = 122; i >=65; i--)
            {
                char letter = Convert.ToChar(i);
                alphabet += letter.ToString();
            }
            Console.WriteLine(alphabet.Remove(26,6).Insert(26,"   ")) ;

            //Output:
            //zyxwvutsrqponmlkjihgfedcba   ZYXWVUTSRQPONMLKJIHGFEDCBA
        }
    }
}
