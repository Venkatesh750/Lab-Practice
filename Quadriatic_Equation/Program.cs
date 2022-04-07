using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadriatic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* C# program to find the root of a quadratic equation
                    ax * 2 + bx + c = 0 */

            // intializing variable a,b and c as integer
            int a, b, c;

            //initializing variable d,x1 and x2 as double
            double d, x1, x2;

            //getting value of a,b and c from user
            Console.Write("Enter the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of c : ");
            c = Convert.ToInt32(Console.ReadLine());

            //perform the equation bxb -4xaxc
            d = b * b - 4 * a * c;

            //condition for check the roots
            if (d == 0)
            {
                //if condition is true then it will perform this statement
                Console.Write("Both roots are equal\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Root1 = {0}\n", x1);
                Console.Write("Root2 = {0}\n", x2);
            }
            else if (d > 0)
            {
                //statement for printing both roots are real
                Console.Write("Both roots are real and diff-2\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("Root1= {0}\n", x1);
                Console.Write("Root2= {0}\n", x2);
            }
            else
            {
                //print the roots are imaginary
                Console.Write("Roots are imaginary \n");
            }

            Console.ReadKey();
        }
    }
}
