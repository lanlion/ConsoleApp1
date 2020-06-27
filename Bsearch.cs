using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Bsearch
    {
        public int getindex()
        {
            int value = 3;
            var array = new int[] { 2, 1, 6, 3, 5, 4, 8, 7, 9 };
            var list = new List<int>(array);
            list.Sort();
            int low = 0;
            int high = list.Count-1;
         
            while (low<high)
            {
                var mid = (low+high) /2;
                var midvalue = list[mid];
                if (midvalue == value)
                {
                    return mid;
                }
                else if (midvalue >= value)
                {
                    high = mid;
              
              
                }
                else if(midvalue < value)
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}
