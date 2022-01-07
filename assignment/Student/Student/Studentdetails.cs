using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Studentdetails
    {
        private int rollno, fee;
        private string name, course;
        public  Studentdetails(int rollno,string name, string course)

        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;



        }
        public void Payment(int amount)
        {
            fee += amount;

        


        }
            public void Print()
        {
            Console.WriteLine("Student name" + name);
            Console.WriteLine(" Roll no" + rollno);
            Console.WriteLine("Course name" + course);
            Console.WriteLine("Fees paid" + fee);


        }
        public int DueAmount
        {
          get
                {
                return Totalfee - fee;

            }

        }

        public int Totalfee
        {
            get
            {
                return course=="c#"?2000:3000;

            }

        }







    }
}
