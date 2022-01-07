using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//E:\Study material\networklag.txt

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* FileStream f = new FileStream("E:\\Study material\\networklag.txt", FileMode.OpenOrCreate);
              *
              StreamReader s = new StreamReader(f);
              string line = "";
              while ((line = s.ReadLine()) != null)
              {
                  string[] values = line.Split();
                  if (line != "")
                  {
                      if (values.Length > 1)
                      {
                          string date = values[1].Split(' ')[0];


                      }
                      Console.WriteLine(values[1] + "\t \t ");
                      Console.ReadKey();
                  }
              }
          }

      }
  }*/

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("E:/Study material/networklog.txt"))
                {
                    string line =sr.ReadLine();
                    string[] values = line.Split(':');

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                        if (line != "")
                        {
                            if (values.Length > 1)
                            {
                                string date = values[1].Split(' ')[0];


                            }
                            Console.Write(values + "\t \t ");
                            //
                            //Console.ReadKey();

                        }
                    }
                }
            }

            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
