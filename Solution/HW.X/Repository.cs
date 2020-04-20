using System;
using System.Collections.Generic;
using System.Text;

namespace HW.X
{
    class Repository : IRepository
    {
        public Repository()
        {
            Data.Motorcycles = new List<Motorcycle>();
        }
        public void Delete(int Id)
        {
            Motorcycle moto = Data.Motorcycles.Find(item => item.Id == Id);
            if (moto != null)
            {
                Data.Motorcycles.Remove(moto);
            }
        }

        public Motorcycle GetById(int Id)
        {
            Motorcycle moto = Data.Motorcycles.Find(item => item.Id == Id);
            return moto;
        }

        public void Insert(Motorcycle moto)
        {
            Data.Motorcycles.Add(moto);
        }

        public void Update(Motorcycle moto)
        {
            moto.Odometr += 30;   
        }

        public IEnumerable<Motorcycle> GetAll()
        {
            return Data.Motorcycles;
        }
    }
}
