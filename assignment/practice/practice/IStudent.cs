using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    interface IStudent
    {
        void getdata(int studid , string name);
        void display();

    }


    class student1:IStudent
    {
        public int Studentid;
        public string Name;
public void getdata(int studid, string name)
        {
            this.Studentid = studid;
            this.Name = name;
           /* Console.WriteLine(" enter student id");
           studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter student name");
           name = Console.ReadLine(); */


        }
        public void display()
        {
           

            Console.WriteLine(" student id" + Studentid);
            Console.WriteLine("Name" + Name);

  
        }
         
    }
}
