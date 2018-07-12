# Find Maximum Value in a Tree
Write a function called find-maximum-value which takes binary tree as its only imput. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.

## Whiteboard
 ![Find Max Whiteboard](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/assets/FindMaxWhiteboard.png)

## Solution Code
```
public static int FindMax(Node root)
        {
            //create queue called breadth
            Queue<Node> breadth = new Queue<Node>();
            //add the root as the first and only node in the queue
            breadth.Enqueue(root);
            //create a max variable that will be updated inside the while loop
            int max = root.Value;
            //while the queue has nodes
            while(breadth.TryPeek(out root))
            {
                //dequeue the front
                Node front = breadth.Dequeue();
                //if the front is larger than the max, reassign max value
                if (front.Value > max)
                {
                    max = front.Value;
                }
                //continue adding nodes to the queue that will eventually move to the front
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            Console.WriteLine($"the max is {max}");
            //return the max value of the node with the highest value
            return max;
        }
```
## Author
Anthony Green 
