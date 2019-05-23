namespace Linked
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

        // Create a node at the beggining of our list with t as our data value
        public void addNode(T t)
        {
            Node newNode = new Node();
            newNode.Next = head;
            newNode.Data = t;
            head = newNode;
        }

        // Our linked list is initially empty
        private Node head = null;


    }

}