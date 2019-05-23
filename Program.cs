using System;
using Linked;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Example");

            // Create a new Linked List
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.addNode(3);
            linkedList.addNode(6);
            linkedList.addNode(9);

        }
    }
}
