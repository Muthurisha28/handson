using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] arr = new int[10];
             int i;
             Console.Write(" to read and write elements of the array ");
             Console.Write(" Input 10 elements of the array ");
             for (i=0; i<10; i++)
             {
                 Console.Write(" array elements -{0} ", i);
                 arr[i] = Convert.ToInt32(Console.ReadLine());

             }
             Console.Write("Elements in tha array are ");
             for (i = 0; i < 10; i++)
             {
                 Console.Write(" {0} ", arr[i]);
             }
             Console.WriteLine("\n");
             Console.ReadKey();  */

            // To reverse the array 

            /* int i, n;
             int[] arr = new int[100];
             Console.WriteLine(" Enter the no of characters");
             n = Convert.ToInt32(Console.ReadLine());
             for (i=0;  i<n; i++)
             {
                // Console.WriteLine(" array elements:{0}", i);
                 arr[i]= Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("The inputter array ");
             for (i = 0; i < n; i++)
             {
                 Console.WriteLine("{0}", arr[i]);

             }

             Console.WriteLine("Display the array in reverse order ");
             for (i=n-1; i>=0; i--)
             {
                 Console.WriteLine("{0}", arr[i]);
             }  */
            // To find sum of elements in the array 

            int i, n;
            int sum=0;
            int[] arr = new int[100];
            Console.WriteLine(" Enter the no of characters");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0; i<n; i++)
            {
                Console.Write(" array elements -{0}  : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine(" Finding the sum of array elements ");
            for(i=0; i<n; i++)
            {
                sum += arr[i];
           
          
            }
            Console.WriteLine("{0}", sum);


            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
