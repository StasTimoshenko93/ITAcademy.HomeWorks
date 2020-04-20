using System;
using System.Collections.Generic;
using System.Text;

namespace HW.X
{
    interface IRepository
    {
        IEnumerable<Motorcycle> GetAll();
        Motorcycle GetById(int Id);
        void Insert(Motorcycle moto);
        void Update(Motorcycle moto);
        void Delete(int Id);
    }
}
