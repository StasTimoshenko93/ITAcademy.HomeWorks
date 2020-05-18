using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Check_In
{
   public class EventManager:EventArgs
    {
        public readonly string msg;
        public EventManager(string message)
        {
            msg = message;
        }
    }
}
