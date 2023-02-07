using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class FindMaximum
    {
       public int first, second, third;
      public static void FindMaxValue(int first,int second,int third)
      {
            if(first.CompareTo(second) >=0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", first);
            }
            else if(second.CompareTo(first) >=0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", second);
            }
            else
            {
                Console.WriteLine("{0} is greater", third);
            }
       }

    }

}
            
