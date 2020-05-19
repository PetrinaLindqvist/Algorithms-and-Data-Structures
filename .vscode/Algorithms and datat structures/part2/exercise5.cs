using System;

namespace part2
{
    public class Split
    {
        public int Calculate(int[] t)
        {
          int leftSum = 0;
        
          for (int i = 0; i < t.Length; i++)
          {
              leftSum += t[i];
                 
               int rightSum = 0;    
               for (int j = i + 1; j < t.Length; j++) 
               
                 rightSum += t[j];

              if(leftSum == rightSum)
              return i +1;  
          }
          
          return -1;
        
        }

    }

}