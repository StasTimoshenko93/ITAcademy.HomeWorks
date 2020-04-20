using System;

namespace HW.X
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            Motorcycle suzuki = new Motorcycle(12, "Suzuki", "s4", new DateTime(2015,7,12), 100);
            Motorcycle bmw = new Motorcycle(16, "BMW", "b1", new DateTime(2010,7,12), 250);
            Motorcycle bmwx1 = new Motorcycle(22, "BMW", "b2", new DateTime(2020,1,1), 320);
            Motorcycle bmwx2 = new Motorcycle(15, "BMW", "b3", new DateTime(2015,7,12), 250);
            repo.Insert(suzuki);
            repo.Insert(bmw);
            repo.Insert(bmwx1);
            repo.Insert(bmwx2);
            
            Console.WriteLine(bmw.Odometr);

            Console.WriteLine(repo.GetById(15).Name);
            foreach (var item in repo.GetAll())
            {
                Console.WriteLine(item.Name);
            }            
        }
    }
}
