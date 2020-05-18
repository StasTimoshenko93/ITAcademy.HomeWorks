using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Check_In
{
    class passport
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }

        public DateTime BirthDay { get; set; }

       public passport(int id, string fullname, string sex, DateTime birthday)
        {
            Id = id;
            FullName = fullname;
            Sex = sex;
            BirthDay = birthday;
        }
    }
}
