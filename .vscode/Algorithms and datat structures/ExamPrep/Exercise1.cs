using System;

namespace ExamPrep
{
  public class Numbers
  {
    public int Steps(int x)
    {
     
    int sum = 0;
    int count = 0;
    int i = 1;

    while (sum < x) 
    { 
        sum += i; 
        i++;
        count++; 
    } 
    return count; 
 
    }
  }
}