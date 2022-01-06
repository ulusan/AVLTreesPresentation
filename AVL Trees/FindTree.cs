using System;
using System.Collections.Generic;
using System.Text;

namespace AVL_Trees
{
    public class FindTree :Rotation
    {
        Node root;
        //Searching for a node in an AVL Tree is the same as with any BST.
        //Start from the root of the tree and compare the key with the value of the node.
        //If the key equals the value, return the node.If the key is greater, search from the right child, otherwise continue the search from the left child.
        //The time complexity of the search is a function of the height.We can assume that time complexity in the worst case is O(log(N)).
        //Let's see the sample code:
        public void Find(int key)
        {
            if (Find(key, root).data == key)
            {
                Console.WriteLine("{0} was found!", key);
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        }
        private Node Find(int target, Node current)
        {

            if (target < current.data)
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.left);
            }
            else
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.right);
            }

        }
    }
}
