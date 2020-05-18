using System;

namespace part2
{
    public class Changes
    {
        public int Calculate(int[] t)
        {
          int changes = 0;
          for (int i = 1; i < t.Length -1; i++)
          {
              if (t[i] == t[i -1]) 
              {
                changes++;
                t[i] = t[i -1] + t[i+1] +1;
              }
            
          }
            return changes;
        
        }
    }

}