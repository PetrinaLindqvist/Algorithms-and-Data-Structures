using System;
using System.Text;
namespace part2
{
  public class Compare
  {
    public int CaseA(string n)
   {
      DateTime start = DateTime.Now;
      int counter = 0;
      for (int i = 0; i <= n.Length - 1; i++)
      {
        for (int j = 1; j <= n.Length - 1; j++) 
        {
            if (n[i].ToString() == "0" && n[j].ToString() == "1")
            {
                counter += 1;
            }
        }
      }
      
      DateTime end = DateTime.Now;
      Console.WriteLine("Time this took: " + end.Subtract(start));
      return counter;
    }

   
   public int CaseB(string n)
   {
      DateTime start1 = DateTime.Now;
      int counter = 0;
      int zeros = 0;
      for (int i = 0; n.Length <= -1; i++)
      {
            if (n[i].ToString() == "0")
            {
            zeros += 1;
            }
            else
            {
            counter += zeros;
            }
      }
        DateTime end1 = DateTime.Now;
        Console.WriteLine("Time this took: " + end1.Subtract(start1));
        return counter;
    }
         
         
   public string CreateInput(int n)
   {
     StringBuilder sb = new StringBuilder();
     Random random = new Random();
     for (int i = 0; i < n; i++)
     {
       sb.Append(random.Next(0, 2).ToString());
     } 
     return sb.ToString();
   }

  }

}