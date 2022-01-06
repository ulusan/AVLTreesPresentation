using System;
using System.Collections.Generic;
using System.Text;

namespace AVL_Trees
{
    public class DeleteTree : Rotation
    {
        //BTS What Does Mean ?
        //In computer science, an AVL tree(named after inventors Adelson-Velsky and Landis) is a self-balancing binary search tree(BST).
        //It was the first such data structure to be invented.
      
        Node root;

        //After we find the node (called Z), we have to introduce the new candidate to be its replacement in the tree.
        //If Z is a leaf, the candidate is empty. If Z has only one child, this child is the candidate, but if Z has two children, the process is a bit more complicated.
        //Assume the right child of Z called Y.First, we find the leftmost node of the Y and call it X.
        //Then, we set the new value of Z equal to X ‘s value and continue to delete X from Y.Finally, we call the rebalance method at the end to keep the BST an AVL Tree.
        public void Delete(int target)
        {//and here
            root = Delete(root, target);
        }
        private Node Delete(Node current, int target)
        {
            Node parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (target < current.data)
                {
                    current.left = Delete(current.left, target);
                    if (balance_factor(current) == -2)//here
                    {
                        if (balance_factor(current.right) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (target > current.data)
                {
                    current.right = Delete(current.right, target);
                    if (balance_factor(current) == 2)
                    {
                        if (balance_factor(current.left) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.right != null)
                    {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.data = parent.data;
                        current.right = Delete(current.right, parent.data);
                        if (balance_factor(current) == 2)//rebalancing
                        {
                            if (balance_factor(current.left) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }
        
    }
}
