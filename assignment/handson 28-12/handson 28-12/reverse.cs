using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_28_12
{
    class reverse
    {
        public void strreverse()
        {
            Console.WriteLine("Input a string to reverse");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            int length = input.Length-1;
            while(length>=0)
            {
                reverse = reverse + input[length];
                length--;

            } 
            /*for(length= input.Length - 1;  length>=0; length--)
            {
                reverse = reverse + input[length];
               // length--;

            } */


            Console.WriteLine("reverse string is{0}", reverse);

        }
    }
}
