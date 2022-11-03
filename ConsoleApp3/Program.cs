using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Program
    {
        static void Main(string[] args)
        {
            ConsumeEventSync objsync = new ConsumeEventSync();
             objsync.PostEvent_data();
            //objsync.GetAllEventData(); 
            //objsync.GetAllEventData_ByEventID("3");
            // objsync.DeleteEvent_data(3);



        }
    }
}
