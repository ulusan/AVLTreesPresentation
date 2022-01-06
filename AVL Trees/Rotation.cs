using System;
using System.Collections.Generic;
using System.Text;

namespace AVL_Trees
{
    public class Rotation
    {
        

        //In right rotations, every node moves one position to right from the current position.
        public Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }

        //In left rotations, every node moves one position to left from the current position.
        public Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        //Left-right rotations are a combination of a single left rotation followed by a single right rotation
        //First, every node moves one position to the left, then one position to the right from the current position.
        public Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        //Right-left rotations are a combination of a single right rotation followed by a single left rotation.
        //First, every node moves one position to the right then, then one position to the left from the current position.
        public Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }

        //The balance factor of a node is the height of its right subtree minus
        //the height of its left subtree and a node with a balance factor 1, 0, or -1 is considered balanced.
        public int balance_factor(Node current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        // A utility function to get the height of the tree  int height (Node N) 
        public int getHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        //A helper function to get up to two integers.
        public int max(int l, int r)
        {
            return l > r ? l : r;
        }
        

    }
}
