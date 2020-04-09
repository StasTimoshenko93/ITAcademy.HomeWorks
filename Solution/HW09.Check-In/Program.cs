using System;

namespace HW09.Check_In
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager Elena = new Manager("Елена");
            User Stas = new User("Станислав");
            Elena.EventGreeting += Greeting;
            Elena.Greeting();
            Stas.GiveName();
            Elena.Registration(Stas);
            Stas.Ticketcheck();
            Elena.GetTicket(Stas);
           
        }
        public static void Greeting(object sender, EventManager e)
        {
            Console.WriteLine(e.msg);
        }
    }
}
