using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_element_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to input elements in array
               and print all unique elements in array. */

            int[] arr = new int[50];

            int i, j, k, n, c = 0;

            Console.Write("Input the number of elements : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Elements are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(" "+arr[i]);
            }

            Console.Write("\nThe unique elements are : ");
            for (i = 0; i < n; i++)
            {
                c = 0;
                
                for (j = 0; j < i - 1; j++)
                {
                    
                    if (arr[i] == arr[j])
                    {
                        c++;
                    }
                }
                
                for (k = i + 1; k < n; k++)
                {
                    
                    if (arr[i] == arr[k])
                    {
                        c++;
                    }
                    
                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }
                
                if (c == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
