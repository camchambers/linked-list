using System;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Linked List
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add nodes to the Linked List
            linkedList.AddNode(1);
            linkedList.AddNode(3);
            linkedList.AddNode(5);
            linkedList.AddNode(7);
            linkedList.AddNode(9);

            // Print the contents of the Linked List
            linkedList.PrintNodes();

        }
    }
}
