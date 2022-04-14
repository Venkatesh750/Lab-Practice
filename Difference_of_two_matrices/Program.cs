using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff_two_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to read elements in two matrices
               and find the difference of two matrices. */
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] arr3 = new int[50, 50];
            
            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Input elements in the first matrix : ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }
            
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
            Console.Write("\nThe Subtraction of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }

            Console.ReadKey();
        }
    }
}
