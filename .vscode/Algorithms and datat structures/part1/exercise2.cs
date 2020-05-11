using System;
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
        for (int i = 0; i <= first - second; i++) 
        { 
            /* For current index i, check for  
        pattern match */
            int j;       
            for (j = 0; j < second; j++) 
            { 
                 
                if (a[i + j] != b[j]) 
                { 
                    break; 
                } 
            } 
   
            // if pat[0...M-1] = txt[i, i+1, ...i+M-1]  
            if (j == second) 
            {                 
                res++;                 
                j = 0;                 
            }             
        
         
        }         
        return res;  
      
      
    }
  }
}