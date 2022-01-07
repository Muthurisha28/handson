using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] arr3 = new int[50, 50];
            int i, j, n;
            Console.WriteLine(" Enter the rank of the matrix");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("array 1{0} {1} ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                    {
                        Console.WriteLine(" the ist array{0}\t " + arr1[i, j]);

                    }

                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.WriteLine("array 1{0} {1} ", i, j);
                            arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("\n");
                            for (j = 0; j < n; j++)
                            {
                                Console.WriteLine(" the 2nd  array {0} \t" + arr2[i, j]);

                            }
                            for (i = 0; i < n; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    arr3[i, j] = arr1[i, j] - arr2[i, j];

                                }
                                for (i = 0; i < n; i++)
                                {
                                    Console.Write("\n");
                                    for (j = 0; j < n; j++)
                                    {
                                        Console.WriteLine(" the final   array {0} \t" + arr3[i, j]);

                                    }



                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
*/

            /*     int m, n, i, j;
                 Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
                 m = Convert.ToInt16(Console.ReadLine());
                 n = Convert.ToInt16(Console.ReadLine());
                 int[,] A = new int[10, 10];
                 Console.Write("\nEnter The First Matrix : ");
                 for (i = 0; i < m; i++)
                 {
                     for (j = 0; j < n; j++)
                     {
                         A[i, j] = Convert.ToInt16(Console.ReadLine());
                     }
                 }

                 int[,] B = new int[10, 10];
                 Console.Write("\nEnter The Second Matrix:");
                 for (i = 0; i < m; i++)
                 {
                     for (j = 0; j < n; j++)
                     {
                         B[i, j] = Convert.ToInt16(Console.ReadLine());
                     }
                 }
                 Console.Clear();
                 Console.WriteLine("\nMatrix A : ");
                 for (i = 0; i < m; i++)
                 {
                     for (j = 0; j < n; j++)
                     {
                         Console.Write(A[i, j] + "\t");

                     }
                     Console.WriteLine();
                 }
                 Console.WriteLine("\nMatrix B: ");
                 for (i = 0; i < m; i++)
                 {
                     for (j = 0; j < n; j++)
                     {
                         Console.Write(B[i, j] + "\t");

                     }
                     Console.WriteLine();
                 }
                 int[,] C = new int[10, 10];
                 for (i = 0; i < m; i++)
                 {
                     for (j = 0; j < n; j++)
                     {
                         C[i, j] = A[i, j] - B[i, j];
                     }
                 }
                 Console.Write("\nDifference Matrix :");
                 for (i = 0; i < m; i++)
                 {
                     for (j = 0; j < n; j++)
                     {
                         Console.Write(C[i, j] + "\t");

                     }
                     Console.WriteLine();
                 } 
                 Console.Read(); */


            Class1 c1 = new Class1("muthu","risha");
            c1.display();
            Console.ReadKey();


        }
    }
}