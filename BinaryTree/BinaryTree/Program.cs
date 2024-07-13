using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int Data;
        public Node left, right;
        public Node(int data)
        { this.Data = data;
            left = right = null;
        }
    }
    public class BinaryTree
    {
        Node root;

        void printPostOrder(Node node)
        {
            if (node == null)
                return;
            printPostOrder(node.left);
            printPostOrder(node.right);
            Console.WriteLine(node.Data);
        }

        void printLevelOrder(Node root)
        {
            int h = maxDept(root)+1;
            for (int i = 1; i <= h; i++)
            {
                printCurrentLevel(root, i);


            }
        }

        void printCurrentLevel(Node root, int level)
        {
            if (root == null)
                return;
            if(level == 1)
                Console.WriteLine(root.Data + "");
            else if (level >1)
            {
                printCurrentLevel(root.left, level - 1);
                printCurrentLevel(root.right, level - 1);
            }

        }

        int maxDept(Node node)
        {
            if (node.left == null && node.right == null)
                return 0;
            else
                if (node.left == null)
                    { return maxDept(node.right) + 1; }
                else
                    return maxDept(node.left) + 1;
                 
            //if (node == null)
            //    return -1;
            //int lDepth=maxDept(node.left);
            //int rDepth=maxDept(node.right);
            //if (lDepth > rDepth)
            //    return lDepth + 1;
            //else
            //    return rDepth + 1;
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.left.left.right = new Node(6);
            tree.root.left.left.left = null;
            tree.root.right.left = new Node(7);
            Console.WriteLine("Height of the tree is {0}", tree.maxDept(tree.root));
            Console.WriteLine(" Level order traversal of binary tree is ");
            tree.printLevelOrder(tree.root);
            Console.WriteLine("Post Order traversal is ");
            tree.printPostOrder(tree.root);
            Console.ReadLine();

        }
    }
    public class Program
    {
       
    }
}
