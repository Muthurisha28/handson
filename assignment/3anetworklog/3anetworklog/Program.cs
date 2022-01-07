using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3anetworklog
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"E:\Study material\networklog.txt";
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(file);
            var lineCount = File.ReadAllLines(@"E:\Study material\networklog.txt").Length;
            Console.WriteLine("No of lines ", lineCount);
            int n, m,i,j;
            n = lineCount / 6;
            Console.WriteLine(n);
            m = n - 1;
            var lines = File.ReadAllLines(file);
            for (int i = 0; i < lineCount; i += 1)
            {
                //var fields = lines.ToArray(':');
                Console.WriteLine(sr.ReadLine());
                if (lines.Contains("Id"))

                {

                    int[] Id = lines.Select(d => int.Parse(d)).ToArray();
                
              
            }

                 
                if (lines.Contains("Source"))

                {

                    int[] Source  = lines.Select(d => int.Parse(d)).ToArray();
                }
                if (lines.Contains("Destination"))

                {
                    
                    int[] destination  = lines.Select(d => int.Parse(d)).ToArray();
                }

                if (lines.Contains("Date"))

                {

                    string[] date = lines.Split(":").ToArray(); 
                    string[] datearray = File.ReadLines("c:\\file.txt").ToArray();

                }


                /*public int [] id = new int[];
                public int[] Source = new int[5];

                while (sr.Peek()>0)
                {
                   string readmyline = sr.ReadLine();
                    //string line = streamReaderObject.ReadLine();


                    Console.WriteLine(readmyline);

                }

                Console.ReadKey();
            } */
                Console.ReadKey();
        }
    }
}

       
  


