using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW09.Check_In
{
    class Manager
    {
        public  bool IsArested { get; set; }
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
                EventGreeting?.Invoke(this, new EventManager("Доброе утро."));
            }
            else if (timeNow >= 12 && timeNow < 15)
            {
                EventGreeting?.Invoke(this, new EventManager("Добрый день."));
            }
            else if (timeNow >= 15 && timeNow < 22)
            {
                EventGreeting?.Invoke(this, new EventManager("Добрый вечер."));
            }
            else
            {
                EventGreeting?.Invoke(this, new EventManager("Доброй ночи."));
            }
            Console.WriteLine($"Меня зовут {Name}");
            Console.WriteLine("Представьтесь, пожалуйста.");
        }
        public void Registration(User obj)
        {
            Console.WriteLine($"{obj.Name}, Пройдите на регистрацию.");
            Console.WriteLine($"Для дальнейшей регистрации, мне нужен ваш билет и паспорт.");
        }

        public void GetTicket(User obj)
        {
            if (obj.ticket.IsTicket)
            {
                Console.WriteLine("Все в порядке, пройдите на досмотр.");
            }
            else
            {
                obj.ticket = new Ticket();
                Random rnd = new Random();
                obj.ticket.Id = rnd.Next(100000000, 999999999).ToString();
                Console.WriteLine($"вот ваш билет {obj.ticket.Id}.") ;
            } 
        }

        public void Security(User obj)
        {
            Console.WriteLine("Досмотр начат, сейчас я проверю Ваш багаж на наличие запрещенных веществ.");
            string[] forbiddenthings = new string[] { "Оружие", "Наркотики", "Лекарства", "Произведения искусства."};
            var result = obj.bag.mybag.Intersect(forbiddenthings);
            if (result.Count() == 0)
            {
                Console.WriteLine("Все в порядке запрещенный веществ не найдено. Вы допущены к полету.");
            }
            else
            {
                IsArested = true;
                Console.WriteLine("Вы арестованы.");
                Console.WriteLine("В вашем багаже найдены запрещенные вещества: ");
                foreach (var item in result)
                {
          
                    Console.WriteLine(item);
                }
            }
        }
    }
}
