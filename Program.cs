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
            linkedList.PrependNode(9);
            linkedList.PrependNode(7);
            linkedList.PrependNode(5);
            linkedList.PrependNode(3);
            linkedList.PrependNode(1);

            // Print the total number of nodes in the linked list
            Console.WriteLine("Node count: " + linkedList.NodeCount + Environment.NewLine);

            // Print the contents of the Linked List
            Console.WriteLine("Printing nodes:");
            linkedList.PrintNodes();
        }
    }
}
