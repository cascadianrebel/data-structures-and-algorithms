# Stack and Queue

Implementing a Stack and a Queue. 

## Content 
*Stack*
- a stack is manipulated from the top down. First node in is the last node out(FILO). Think of it like a literal stack of items. Items cannot be removed from the stack until the items on top are first removed. 
- New items (nodes) are added to the stack using the Push method. When a node is pushed to the stack it is now on top of the stack. 
- Removing Items (nodes) is accomplished with the Pop method. The top node is removed when the Pop method is executed.



1. O(1) - .Push(Node node) - Add a node to the stack
2. O(1) - .Pop() - removes and returns the top node of the stack
3. O(1) - .Peek() -returns the top node of the stack

![Stack Example Code](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/StackCode.PNG)

*Queue*
- a queue is manipulated from front to back. The first node in the queue is the first node removed (FIFO). It is like a line of people. The front of the line (queue) gets to go first. 
- the Enqueue method is used to add a person (node) to the line (queue). The person gets in the rear of the line just as the node gets added to the end of the queue. 
- the Dequeue Method removes the person at the front of the line, the new front of the line is the next person behind. 

1. O(1) - .Enqueue(Node node) - Add a node to the queue
2. O(1) - .Dequeue() - removes and returns the front node of the queue
3. O(1) - .Peek() -returns the front node of the queue

![Queue Example Code](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/QueueCode.PNG)

## Visual Demo
*Stack*

![Push](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/PushStack.PNG)
![Peek](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/StackPeek.PNG)
![Pop](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/PopStack.PNG)


*Queue*

![Enqueue](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/Enqueue.PNG)
![Peek](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/QueuePeek.PNG)
![Dequeue](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/DataStructures/Assets/Dequeue.PNG)



## Author
Anthony Green

