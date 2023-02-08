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
      
      public static float FindDoubleMaxValue(float first,float second,float third)
      {
            if(first.CompareTo(second) >=0 && first.CompareTo(third) >= 0)
            {
                //Console.WriteLine("{0} is greater", first);
                return first;
            }
            else if(second.CompareTo(first) >=0 && second.CompareTo(third) >= 0)
            {
                //Console.WriteLine("{0} is greater", second);
                return second;
            }
            else
            {
                //Console.WriteLine("{0} is greater", third)
                return third;
            }
       }

    }

}
            
