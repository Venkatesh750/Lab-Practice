using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            /* C# program to demonstrate the String.Substring Method (int startIndex, int length) */
            string value;
            Console.Write("Enter the value for string : ");
            value = Console.ReadLine();
            Console.WriteLine("\nSub String for {0} is {1}", value, value.Substring(0, 3));

            Console.ReadLine();
        }
    }
}
