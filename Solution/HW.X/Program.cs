using System;

namespace HW.X
{
    class Program
    {
        static void Main(string[] args)
        {
            logger.InitLogger();
            logger.Log.Info("App Start. Create repository");
            Repository repo = new Repository();
            logger.Log.Info("Added new Motorcycle");
            Motorcycle suzuki = new Motorcycle(12, "Suzuki", "s4", new DateTime(2015,7,12), 100);
            Motorcycle bmw = new Motorcycle(16, "BMWz1", "b1", new DateTime(2010,7,12), 250);
            Motorcycle bmwx1 = new Motorcycle(22, "BMWz2", "b2", new DateTime(2020,1,1), 320);
            Motorcycle bmwx2 = new Motorcycle(15, "BMWz3", "b3", new DateTime(2015,7,12), 250);
            repo.Insert(suzuki);
            repo.Insert(bmw);
            repo.Insert(bmwx1);
            repo.Insert(bmwx2);

            try
            {
                logger.Log.Info("show all name moto.");

                foreach (var item in repo.GetAll())
                {
                    Console.WriteLine(item.Name);
                }

                logger.Log.Info("Deleted moto by index: 22.");
                repo.Delete(22);
                logger.Log.Info("Update motorcycle bmw");
                Console.WriteLine($"before update {bmw.Odometr}");
                repo.Update(bmw);
                Console.WriteLine($"after update {bmw.Odometr}");

                foreach (var item in repo.GetAll())
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine($"get by id : {repo.GetById(16).Name}");
            }

            catch(Exception ex) 
            {
                logger.Log.Error($"Warning : {ex}");
            }

            finally
            {
                logger.Log.Info("End");
                Console.WriteLine("End");
            }
        }
    }
}
