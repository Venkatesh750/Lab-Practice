using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Min_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to input elements in an array from user,
               find maximum and minimum element in array. */

            Console.WriteLine("Enter the elements : ");
            int[] arr = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.Write("Elements are : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write(" "+arr[i]);

            }
            Console.Write("\n");

            int max, min;
            max = arr[0];
            min = arr[0];
            for (i = 0; i < 5; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element is {0}",max);
            Console.WriteLine("Minimum element is {0}", min);

            Console.ReadKey();
        }
    }
}
