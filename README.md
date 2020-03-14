# Linked List
> A [singly linked list](https://en.wikipedia.org/wiki/Linked_list) is a data structure that represents a sequence of nodes, where each node in the list points to the next node. A benefit of a linked list is that items can be added and removed from the beggining of the list in constant time (which can be useful for specific applications). However, a linked list does not provide constant time access to a particiular item (index) within the list, like an array does. 

## TO DO

- [x] Write a Node class
- [x] Write a LinkedList class
- [x] Create a method for prepending a node to the linked list
- [X] Create a method for printing the linked list
- [ ] Create a method for appending a node to the the linked list
- [ ] Create a method for deleting a node from the linked list

## Example

```csharp
     // Create a new Linked List
     LinkedList<int> linkedList = new LinkedList<int>();
      
     // Add nodes to the Linked List
     linkedList.addNode(3);
     linkedList.addNode(6);
     linkedList.addNode(9);
     
     // Print the contents of the Linked List
     linkedList.printNodes();

 ```
 
## FAQ
**A linked list exists as a part of the System.Collections.Generic namespace. Why reinvent the wheel?**
Rebuilding an existing solution can provide a deeper understanding of how it works, and it also affords the flexibility of experimenting with how it behaves. 
 
## Clone

- Clone this repo to your local machine using `git@github.com:camchambers/linked-list.git`

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright 2020 © <a href="https://www.camchambers.com" target="_blank">Cam Chambers</a>.
