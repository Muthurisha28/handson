using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_28_12
{
    class Class1
    {
        string value, substring;
        int j, i;
        string[] a = new string[5];
       public  void substring1()
        {
            Console.WriteLine("Enter the String : ");
            value = Console.ReadLine();
            Console.WriteLine("All Possible Substrings of the Given String are :");
            for (i = 1; i <= value.Length; i++)
            {
                for (j = 0; j <= value.Length - i; j++)
                {
                    substring = value.Substring(j, i);
                    a[j] = substring;
                    Console.WriteLine(a[j]);
                }
            }
        }


    }

    }



