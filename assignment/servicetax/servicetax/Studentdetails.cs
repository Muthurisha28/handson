using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicetax
{
    class Studentdetails
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoined { get; set; }
        public double FeePaidSoFar { get; set; }
        public double Servicetax = 12.3;



       
        public double DueAmount
        {
            get
            {
                return TotalFee - FeePaidSoFar;
            }
        }

        
        public double TotalFee
        {

            get
            {
                if (CourseJoined.ToLower() == "c#")
                    return 2000+2000*(Servicetax/100);
                else if (CourseJoined.ToLower() == "asp.net")
                    return 3000+3000*(Servicetax / 100); 
                return 0;
            }
        }

        public Studentdetails(int rollNo, string name, string courseJoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = courseJoined;
            //Servicetax = servicetax;
        }

        
        public void Payment(int amount)
        {
            FeePaidSoFar += amount;
        }

        public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Course Joined: {CourseJoined}");
            Console.WriteLine($"Total Fee: {TotalFee}");
            Console.WriteLine($"Fee Paid So Far: {FeePaidSoFar}");
            Console.WriteLine($"Due Amount: {DueAmount}");
        }
    }
}





