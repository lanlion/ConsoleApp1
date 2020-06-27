using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    public class randombox
    {
        Random r = new Random();
        public void Compute()
        {
            var count = 0;
            for (int i = 0; i <= 10000000; i++)
            {
                if (IsHit())
                {
                    count++;
                }
            }
            var result = count / 1000000.00;
        }
        public bool IsHit()
        {
      
            var boxarray = new byte[12];
          
            for (int i = 0; i < 10; i++)
            {
               
                var num = r.Next(0,12);
                boxarray[num] = 1;
            }
           
          return boxarray.Where(box => box == 1).Count()==2;
        }
    }
}
