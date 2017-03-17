using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void printEven(int str, int ctr)
        {
            if (str > ctr )
                return;
            
            if (str % 2 == 0)
            {
                Console.WriteLine(" {0} ", str);
            }
                printEven(str + 1, ctr);
                      
            
        }
        static void Main()
        {
            Console.Write("\n\n Recursion : Print the first n natural number :\n");
            Console.Write("---------------------------------------------------\n");
            Console.Write(" Enter the first number");
            int ctr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The following is the list of even numbers:");
            // Call recursive method with two parameters.	
            printEven(str, ctr);
            Console.Write("\n\n");
        }
    }
}
