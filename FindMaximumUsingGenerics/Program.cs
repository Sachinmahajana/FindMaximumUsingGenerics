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
            float first = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            float second = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third Number: ");
            float third =(float) Convert.ToDouble(Console.ReadLine());

            double s1=  FindMaximum.FindDoubleMaxValue(first,second,third);
            Console.WriteLine("Max value=" + s1);
            Console.ReadLine();
        }
        
    }
}
