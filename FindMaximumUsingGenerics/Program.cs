using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FindMaximumGenerics Program");
            Console.WriteLine("Enter the first Number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            FindMaximum.FindMaxValue(first, second, third);
           
            Console.ReadLine();
        }
       
    }
}
