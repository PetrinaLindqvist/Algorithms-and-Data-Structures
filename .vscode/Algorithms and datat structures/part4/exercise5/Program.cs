using System;
using System.Collections.Generic;

namespace part4
{
    class Program
    {
        static void Main(string[] args)
        {
    
            //Ex 4
            /*Order o = new Order();
            int[] a = {4,2,1,3,5};
            int[] b = {2,4,3,1,5};
            int[] c = o.Create(a,b);
            Console.WriteLine(String.Join(" ", c)); // 2 3 5 1 4*/

            //Ex 5
            BinarySearchTree bs = new BinarySearchTree();
            bs.Add(5); // Becomes your root
            bs.Add(4); // Goes to the left
            bs.Add(6); // Goes to the right
            Console.WriteLine(bs.Height()); // 1
            bs.Add(3);
            bs.Add(1);
            bs.Add(7);
            Console.WriteLine(bs.Height()); // 3
        }
    }
}