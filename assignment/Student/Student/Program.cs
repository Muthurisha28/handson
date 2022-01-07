using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
           Studentdetails s= new Studentdetails(33, "risha ", "c#");
           
            s.Payment(1500);
            s.Print();
            Console.WriteLine(s.DueAmount);
            Console.ReadKey();

            }
               
        }
    }

