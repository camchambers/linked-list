using System;

namespace linked_list
{
    public class LinkedList<T>
    {
        private class Node
        {
            // Each node has a reference to the next node in the list
            public Node Next;

            // Each node has a value of type T
            public T Data;
        }

        // The linked list is initially empty
        private Node head = null;

        public int NodeCount { get; private set; } = 0;

        // Create a node at the beggining of our list with t as our data value
        public void PrependNode(T t)
        {
            Node newNode = new Node
            {
                Next = head,
                Data = t
            };
            head = newNode;
            NodeCount++;
        }

        // Print out all of the nodes in the Linked List
        public void PrintNodes()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
