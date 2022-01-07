using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parttime
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course("course", 10, 100);
            
            var partCourse = new PartTimeCourse("partCourse", 10, 100);
            
            var onsiteCourse = new OnsiteCourse("onsiteCourse", 10, 100);


            course.Print();
            Console.WriteLine("\n");
            partCourse.Print();
            Console.WriteLine("\n");
            onsiteCourse.Print();
            Console.ReadKey();
        }
    }
}
