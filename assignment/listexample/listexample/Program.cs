using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listexample
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
              Console.WriteLine("Sample input  1 2 3 4");
              Console.Write("Output        ");
              foreach (var i in mylist)
              {
                  Console.Write(i.ToString() + " ");
              }
              Console.ReadKey();
          }


              /*  List<int> list1 = new List<int>();
                list1.Add(1);
                list1.Add(2);
                list1.Add(3);
                list1.Add(4);
                Console.WriteLine("list before execution");
                foreach (var ar in list1)
                    Console.Write(ar); */
            /* public static List<int> test(List<int> nums)
             {
                 IEnumerable<int> doubled = nums.Select(x => (x+2)*5);
                 return doubled.ToList<int>();
             }

         }

     }  */

            /*List<int> list2 = new List<int>();
            list2.ForEach(i => list1.Add((+2)*5));
            foreach (var ar1 in list2)
                Console.Write(ar1); */



            /* List<string> mylist = test(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
             foreach (var i in mylist)
             {
                 Console.Write(i.ToString() + " ");
             }
             Console.ReadKey();
         }
         public static List<string> test(List<string> str)
         {
             return str.Select(x => x.Replace("a", "")).ToList();
         }
     }
 }
 */

          
                List<string> mylist = test(new List<string>(new string[] { "1", "2", "3", "4" }));
            Console.WriteLine("Sample input  1 2 3 4");
            Console.Write("Output        ");
                foreach (var i in mylist)
                {
                    Console.Write(i.ToString() + " ");
                }
            Console.ReadKey();

            }
            public static List<string> test(List<string> nums_str)
            {
                IEnumerable<string> s = nums_str.Select(x => x = x + x + x + x);
                return s.ToList();
            }
        }
    }







       