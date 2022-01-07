using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            int n = 3;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
              
            s.Push(new Person()
            {
                Name = name,
                Age = age
            });
        }


            for (int i = 0; i < n; i++)
            {
                Person p =( Person)(s.Pop());
                Console.WriteLine(p.ToString());

            }
            Console.ReadKey();
        }
    }

            public class Person
        {
            public string Name { get; set; }
            public int Age{ get; set; }
            public override string ToString()
            {
                return Name + "-" + Age;
            }
           
    }

}
