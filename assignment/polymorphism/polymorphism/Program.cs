using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.convert(7);
            c.convert(400.00);


            Console.ReadKey();


        }
    }
}
