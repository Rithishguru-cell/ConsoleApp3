using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public partial  class EventTB
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> EventStartsDate { get; set; }
        public Nullable<System.DateTime> EventEndsDate { get; set; }
        public string EventLocation { get; set; }


    }
}
