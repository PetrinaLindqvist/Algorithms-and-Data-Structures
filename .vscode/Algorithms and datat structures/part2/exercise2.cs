using System;

namespace part2
{
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int rep = 1;
            int lengthOfRep = 1;

            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] == t[i -1])
                {
                    rep++;
                }
                else if (t[i] != t[i -1])
                {
                    rep = 1;
                }
                if (lengthOfRep < rep)
                {
                    lengthOfRep = rep;
                }
            }
            return lengthOfRep;

        }
    }

}