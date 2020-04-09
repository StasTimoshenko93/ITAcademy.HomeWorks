using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Check_In
{
    class Manager
    {
       public string Name { get; set; }
       public  string Rank { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
       public  Manager(string name, string rank)
        {
            Name = name;
            Rank = rank;

        }
        public event EventHandler<EventManager> EventGreeting;
       
        public void Greeting()
        {
            TimeSpan ttimeNow = DateTime.Now.TimeOfDay;
            int timeNow = ttimeNow.Hours;
            if (timeNow >= 9 && timeNow < 12)
            {
                EventGreeting?.Invoke(this, new EventManager("Доброе утро"));
            }
            else if (timeNow >= 12 && timeNow < 15)
            {
                EventGreeting?.Invoke(this, new EventManager("Добрый день"));
            }
            else if (timeNow >= 15 && timeNow < 22)
            {
                EventGreeting?.Invoke(this, new EventManager("Добрый вечер"));
            }
            else
            {
                EventGreeting?.Invoke(this, new EventManager("Доброй ночи"));
            }
            Console.WriteLine($"Меня зовут {Name}");
            Console.WriteLine("Представьтесь, пожалуйста.");
        }
        public void Registration(User obj)
        {
            Console.WriteLine($"{obj.Name}, Пройдите на регистрацию");
            Console.WriteLine($"Для дальнейшей регистрации, мне нужен ваш билет и паспорт");
        }

        public void GetTicket(User obj)
        {
            if (obj.ticket.IsTicket)
            {
                Console.WriteLine("Все в порядке, пройдите на досмотр");
            }
            else
            {
                obj.ticket = new Ticket();
                Random rnd = new Random();
                obj.ticket.Id = rnd.Next(100000000, 999999999).ToString();
                Console.WriteLine($"вот ваш билет {obj.ticket.Id}") ;
            } 
        }
    }
}
