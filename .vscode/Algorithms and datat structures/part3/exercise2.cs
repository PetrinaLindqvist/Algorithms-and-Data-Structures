using System;
using System.Text;

namespace part3
{

    public class SmallestDifference
    {

        public int Calculate(int[] t)
        {
            int diff = int.MaxValue;
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = i + 1; j <t.Length; j++ )
                {
                    if (Math.Abs((t[i] - t[j])) < diff)
                    {
                     diff = Math.Abs((t[i] - t[j]));
                    }
                }
            }
            return diff;

        }

   

    }
}


