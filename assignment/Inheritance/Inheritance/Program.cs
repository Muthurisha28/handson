using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop();
            l.showResult("Lenovo", "$1000", "i3", "2Gb", "500GB");
            
            Console.ReadKey();


        }
    }
}
