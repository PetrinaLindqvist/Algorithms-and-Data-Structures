using System;
using System.Text;
namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex.1

            /*Compare compare = new Compare();

            string input10 = compare.CreateInput(10);
            string input100 = compare.CreateInput(100);
            string input1000 = compare.CreateInput(1000);
            string input10000 = compare.CreateInput(10000);

            compare.CaseA(input10000);
            compare.CaseB(input10000);*/

            //Ex.2
            LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5

        }

    }
}