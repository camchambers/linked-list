using Linked;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create a new Linked List
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add nodes to the Linked List
            linkedList.addNode(3);
            linkedList.addNode(6);
            linkedList.addNode(9);

            // Print the contents of the Linked List
            linkedList.printNodes();

        }
    }
}
