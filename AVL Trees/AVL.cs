using System;
using System.Collections.Generic;
using System.Text;

namespace AVL_Trees
{
    public class AVL : Rotation
    {
        Node root;
        //Returns true if binary tree with root as root is height-balanced
        public Node balance_tree(Node current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current); //for height of left subtree
                }
                else
                {
                    current = RotateLR(current); // for height of right subtree
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);  //for the height of the left subtree
                }
                else
                {
                    current = RotateRR(current); //for the height of the right subtree
                }
            }
            return current;
        }

        public void DisplayTree()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root);
            Console.WriteLine();
        }


        private void InOrderDisplayTree(Node current)
        {
            if (current != null)
            {
                InOrderDisplayTree(current.left);
                Console.Write("({0}) ", current.data);
                InOrderDisplayTree(current.right);
            }
        }
        





        //ROTATION 

    }
}
