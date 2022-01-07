using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_28_12
{
    class Program
    {
        static void Main(string[] args)
        {
            reverse p = new reverse();
            Class1 c1 = new Class1();
            
            string str;
            Console.WriteLine(" enter any string");
            str = Console.ReadLine();
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            foreach(var character in str)
            {
                if(character!=' ')
                {
                    if(!charcount.ContainsKey(character))
                    {
                        charcount.Add(character, 1);
                    }
                    else
                    {
                        charcount[character]++;

                    }
                }
            }
            foreach(var character in charcount)
            {
                Console.WriteLine("{0} -{1}", character.Key, character.Value);
            }
           p.strreverse();
            c1.substring1();
            Console.ReadKey();
        }
    }
}
