using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ConsumeEventSync
    {

        public void GetAllEventData() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44343/api/EventTBs"); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }


        public void GetAllEventData_ByEventID(string EventID) //Get All Events Records By ID  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44343/api/EventTBs/" + EventID); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }

        public void PostEvent_data() //Adding Event  
        {
            using (var client = new WebClient())
            {
                EventTB objtb = new EventTB(); //Setting parameter to post  
                Console.WriteLine("Please Enter the Event ID Number");
                objtb.EventID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter the Event Name");
                objtb.EventName = Console.ReadLine();

                Console.WriteLine("Please Enter the Event Starting Date");
                objtb.EventStartsDate = Convert.ToDateTime( Console.ReadLine());

                Console.WriteLine("Please Enter the Event Ending Date");
                objtb.EventEndsDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Please Enter the Event Location ");
                objtb.EventLocation = Console.ReadLine();

                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("https://localhost:44343/api/EventTBs", JsonConvert.SerializeObject(objtb));
                Console.WriteLine(result);
            }
        }

        public void PutEvent_data(int EventID) //Update Event  
        {
            using (var client = new WebClient())
            {
                
                EventTB objtb = new EventTB();
                objtb.EventID = 3;
                objtb.EventName = "Late-Night Music Rocks"; //Value to Update  
                objtb.EventStartsDate = DateTime.Now;
                objtb.EventEndsDate = DateTime.Now;
                objtb.EventLocation = "Mumbai";
                var result = client.UploadString("https://localhost:44343/api/EventTBs/" + EventID, "PUT", JsonConvert.SerializeObject(objtb));
                Console.WriteLine(result);
            }
        }
        public void DeleteEvent_data(int EventID) //Update Event  
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("https://localhost:44343/api/EventTBs/" + EventID, "Delete", "");
                Console.WriteLine(result);
            }
        }
    }
}