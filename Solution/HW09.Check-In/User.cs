using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Check_In
{
    class User
    {
        public string Name { get; set; }
        public int Age { get { return DateTime.Now.Year - passport.BirthDay.Year; } }
        public Ticket ticket { get; set; } = new Ticket();
        public Bag bag { get; set; } = new Bag();
        public passport passport { get; set; } = new passport(12124122, "Станислав Тимошенко", "муж", new DateTime(1993, 10, 11));

        public User(string name)
        {
            Name = name;
        }
        public void GiveName()
        {
            Console.WriteLine(passport.FullName);
        }
        public void Ticketcheck()
        {
            if (ticket.IsTicket)
            {
                Console.WriteLine($"Мой паспорт:\nId: {passport.Id}\nПолное имя: {passport.FullName}\nПол: {passport.Sex}\nДень Рождения: {passport.BirthDay}");
                Console.WriteLine($"мой билет: {ticket.Id}");
            }
            else 
            {
                Console.WriteLine("У меня нет билета.");
            }
        }

        public void Arested()
        {
            Console.WriteLine("Это не мое. (начать убегать)");
        }
        public void ItsOk()
        {
            Console.WriteLine("Хорошо, спасибо!");
        }

    }
    class Ticket
    {
        public bool IsTicket { get; } = true;
        public string Id { get; set; } = "12345432134";
        public Ticket()
        {
        }
        public Ticket (bool isticket)
        {
            IsTicket = isticket;
        }
    }
        
    class Bag
    {
       public string[] mybag =new string[] { "Майка", "Трусы", "штаны"};
        
        public Bag() { }
    }
}
