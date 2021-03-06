using System;
using System.Collections.Generic;
namespace part4
{
    public class SmallestDistance 
    {
        List<int> numbers = new List<int>();
        public void Add(int x)
        {
            numbers.Add(x);
        }

        public int Calculate()
        {
            numbers.Sort();
            int minDiff = numbers[1] - numbers[0];
            for (int i = 2; i != numbers.Count; i++)
            {
                minDiff = Math.Min(minDiff, numbers[i] - numbers[i -1]);
            }
            return minDiff;
        
        }
    
    
    }
}