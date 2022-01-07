using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
  
 class LaptopBase
    {
        public string Name;
        public string Price;
        public string Processor;
        public string Ram;

        public string harddrive;

    }
    class Laptop : LaptopBase
    {
        public void showResult(string Name, string Price, string Ram, string Processor, string harddrive)
        {


            Console.WriteLine("\n Laptop specificatons");
            Console.WriteLine("NAME:\t " + Name);
            Console.WriteLine("PRICE:\t" + Price);
            Console.WriteLine("RAM:\t" + Ram);
            Console.WriteLine("PROCESSOR:\t" + Processor);
            Console.WriteLine("HDD:\t " + harddrive);
        }

        } 
    }

  








    






