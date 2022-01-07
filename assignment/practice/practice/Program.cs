using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*student1 s = new student1();
             s.getdata(45, "risha");
             s.display();*/
            /*Dictionary<int,string> di = new Dictionary<int,string >();
            di.Add(1, "risha");
            di.Add(2, "risha");
            di.Add(3, "risha");
            foreach(KeyValuePair<int,string> kv in di)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            } */
            Hashtable h1 = new Hashtable();
            h1.Add(1, "risha");
            h1.Add("rr", "risha");
            h1.Add(3, "pavi");
            h1.Add("li", "prade");
            h1.Add("odd", "even");

            foreach(object obj in h1.Keys)
            {
                Console.WriteLine(obj);
            }

            foreach (object obj in h1.Values)
            {
                Console.WriteLine(obj);
            }
            foreach (DictionaryEntry di in h1 )
            {
                Console.WriteLine(di.Key+":"+di.Value);
            }

            Console.ReadKey();






        }
    }
}
