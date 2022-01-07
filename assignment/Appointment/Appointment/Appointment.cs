using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment
{
     class Appointment
    {
      
       
        public static void  Schedule(List<String> l1, string dateTime)
        {
            l1.Add(dateTime);
            string[] Date = dateTime.Split(" ");
            string[] date = Date[0].Split("/");
            string[] time = Date[1].Split(":");
            return date[2]+","+date[0]","+date[1]+","+time[0]":" + time[1] + ":" + time[2];


        }
        public static bool  Haspassed(List<string> li,string dateTime)
        {
            bool Haspassed=true;
            

           
            foreach (var i in li)
            {
                Haspassed = false;
            }


            return Haspassed;
              
        }
         public static bool IsAfternoonAppointment(string dateAndTime)
        {
           
            
            bool b1=false;
            string[] dateTimeArray = dateAndTime.Split("");
            string[] time = dateTimeArray[1].Split(":");

            if ((hours >= 12) & (hours < 18))
            {
                b1= true;
            }
            
            return b1;
               
        }
        public static void  Appointmentdescription (string dateandTime)
        {
            //DateTime dt5 = new DateTime(2015, 12, 29, 5, 10, 20);
            Console.WriteLine(" you have a appointment on " + dateandTime);
              
            



        }
             
           
    }
}
