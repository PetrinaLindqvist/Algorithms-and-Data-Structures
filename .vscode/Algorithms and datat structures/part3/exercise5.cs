using System;
using System.Text;

namespace part3
{

    public class Inversions
    {
        public int[] Create(int n, int k)
        {
            int [] array =  new int [n];
            for (int i = 0; i < n; i++)
            {
              array[i] = i + 1;
            }  
              int inversions = 0;    
              for( int j = 0; j < t.Length; j++)
              {
                if (t[i] < t[j])
                {
                  inversions ++;
                }
                
              }
            
            return array;
        }
    }
}