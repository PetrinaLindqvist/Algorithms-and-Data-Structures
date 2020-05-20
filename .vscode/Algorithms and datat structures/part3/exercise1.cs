using System;
using System.Text;

namespace part3
{
    
    public class Counter
    {
        public void Hello(int n)
        {
            if (n == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n-1);
            }
        
        }
    }

}