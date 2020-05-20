using System;

namespace part2
{
    public class Split
    {
        public int Calculate(int[] t)
        {
          int sum = 0;
          foreach (int i in t)
          {
              sum += i;
          }
          if (sum % 2 != 0)
          {
            return 0;
          }       
          int half = sum / 2;
          int left = 0;
          int splits = 0;    
          for (int i = 0; i < t.Length -1; i++) 
          {
            if(left == half)
            {
              splits++;
            }
            if (i< t.Length)
            {
              left += t[i];
            }
          }
          return splits;
        
        }

    }

}