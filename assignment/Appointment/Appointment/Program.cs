using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Appointment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime dt1 = new DateTime(2015, 12, 29, 5, 10, 20);
               //Console.WriteLine(dt1);
               DateTime dt2 = new DateTime(2015, 12, 30, 5, 10, 20);
               DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
               List<DateTime> li = new List<DateTime>();
               li.Add(dt1);
               li.Add(dt2);
               li.Add(dt3); 

              Appointment.Haspassed(li);
              Appointment.IsAfternoonAppointment();
              Appointment.Appointmentdescription(); */
            List<string> l1 = new List<string>();
            DateTime dt1 = new DateTime(2015, 12, 29, 5, 10, 20);
            l1.Add("7/25/2019   13:45:00");
            Console.WriteLine(" enter your appointment date and time");
            string dateAndTime = Console.ReadLine();
            bool Ticket = Appointment.Haspassed(l1, dateAndTime);
            if(Ticket==true )
            {
                Console.WriteLine("Appointment is scheduled on that date. Please try another date");

            }
            else
            {
                Console.WriteLine("DateAndTime{0}", Appointment.Schedule(l1, dateAndTime));
                Appointment.Appointmentdescription(dateAndTime);
            }
            DateTime dt = new DateTime(2015, 12, 29, 5, 10, 20);
            Appointment.IsAfternoonAppointment(dt);
            Appointment.Appointmentdescription(dateAndTime);





            Console.ReadKey();

        }
    }
}
