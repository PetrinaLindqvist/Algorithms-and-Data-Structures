using System;
using System.Text.RegularExpressions;

namespace part1
{
  public class Substrings
  {
    public int Calculate(string a, string b)
    {     
        int first = a.Length;         
        int second = b.Length;         
        int res = 0; 
   
        /* A loop to slide pat[] one by one */
        for (int i = 0; i <= second - first; i++) 
        { 
            /* For current index i, check for  
        pattern match */
            int j;             
            for (j = 0; j < first; j++) 
            { 
                if (b[i + j] != a[j]) 
                { 
                    break; 
                } 
            } 
   
            // if pat[0...M-1] = txt[i, i+1, ...i+M-1]  
            if (j == first) 
            {                 
                res++;                 
                j = 0;                 
            }             
        }         
        return res;       
      
      
    }
  }
}