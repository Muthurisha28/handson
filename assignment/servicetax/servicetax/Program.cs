using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicetax
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentdetails s1 = new Studentdetails(1001, "Risha", "c#" );
            Studentdetails s2 = new Studentdetails(1002, "Riya", "ASP.NET");

           
            s1.Payment(200);
            s2.Payment(100);

            
            s1.Print();

            Console.WriteLine("\n");


            s2.Print();
            Console.ReadKey();
        }
    }
}
