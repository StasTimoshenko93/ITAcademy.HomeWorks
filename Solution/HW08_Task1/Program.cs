using System;

namespace HW08_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четверостишие:");
            string poem = Console.ReadLine();

            if (poem =="")
            {
                poem = "И труд нелеп, и бестолкова праздность;И с плеч долой всё та же голова;Когда приходит бешеная ясность;Насилуя притихшие слова";
            }

            string[] poeminarray = poem.ToLower().Split(";");

            for (int i = 0; i < poeminarray.Length; i++)
            {
                  poeminarray[i]=poeminarray[i].Replace("о", "а");
            }

            foreach (var item in poeminarray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
