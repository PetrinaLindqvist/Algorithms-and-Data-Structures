using System;
using System.Text;
namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
         //Ex.1
         
         Compare compare = new Compare();

         string input10 = compare.CreateInput(10);
         string input100 = compare.CreateInput(100);
         string input1000 = compare.CreateInput(1000);
         string input10000 = compare.CreateInput(10000);
        
         compare.CaseA(input10000);
         compare.CaseB(input10000);
        
        
        
        }

    }
}