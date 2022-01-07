using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Class1
    {
        public void convert(int i)
        {
            //int f1;
            String s1;
           // f1 = Convert.ToInt32(Console.ReadLine());
            s1 = Convert.ToString(i);
            Console.WriteLine(s1);

        }
        public void convert(double j)
        {
           // Double f2;

            String s;
            //f2 = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToString(j);
            Console.WriteLine(s);
        }
    }
}

