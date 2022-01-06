using System;
using System.Collections.Generic;
using System.Text;

namespace AVL_Trees
{
    public class AddTree : Rotation
    {
        //Insertion in AVL tree is performed in the same way as it is performed in a binary search tree.
        //The new node is added into AVL tree as the leaf node. However, it may lead to violation in the AVL tree property and therefore the tree may need balancing.
        //The tree can be balanced by applying rotations.
        Node root;
        public void Add(int data)
        {
            Node newItem = new Node(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
        }
        //When implementing a recursive function it is much easier to write as a stand-alone function as opposed to a method of a class.
        //This is because a stand-alone method may be called on nothing while a method must always have a non-null self reference.
        private Node RecursiveInsert(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.data < current.data)
            {
                current.left = RecursiveInsert(current.left, n);
                current = balance_tree(current);
            }
            else if (n.data > current.data)
            {
                current.right = RecursiveInsert(current.right, n);
                current = balance_tree(current);
            }
            return current;
        }
        private Node balance_tree(Node current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
    }
}
