using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            int n = 3;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                ar.Add(new Person()
                {
                    Name = name,
                Age = age



            });
        }
        foreach(Person p in ar)
            {
            Console.WriteLine(p.Print());
            
            }
            Console.ReadKey();

        }
    }
}
