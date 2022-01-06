using System;

namespace AVL_Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            AVL avl = new AVL();
            //ADD Method
            AddTree tree = new AddTree();
            //Delete Method
            DeleteTree deleteTree = new DeleteTree();
            //Find Method
            FindTree findTree = new FindTree();


            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            //deleteTree.Delete(7);
            avl.DisplayTree();

            
            //findTree.Find(2);
        }
    }
    
}
