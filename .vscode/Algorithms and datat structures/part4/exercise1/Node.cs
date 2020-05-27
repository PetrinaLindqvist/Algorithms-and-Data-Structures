using System;
using System.Text;

namespace part4
{
    public class Node
    {
        public int value;
        public Node next {get; set;}
        public Node previous {get; set;}

        public Node(int value, Node next, Node previous)
        {
            this.value = value;
            this.next = next;
            this.previous = previous;
        }
    }
}