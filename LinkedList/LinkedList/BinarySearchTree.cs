using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int key;
            public Node left, right;
            public Node(int key)
            {
                this.key=key;
                left=right=null;
            }
        }
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void insert(int key)
        {
            root = insertRec(root, key);
        }

        /* A recursive function to insert a new key in BST */
        public Node insertRec(Node root, int key)
        {

            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (key < root.key)
                root.left = insertRec(root.left, key);               
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            /* return the (unchanged) node pointer */
            return root;
        }

        // This method mainly calls InorderRec() 
        public void inorder()
        {
            inorderRec(root);
        }

        // A utility function to do inorder traversal of BST 
        public void inorderRec(Node root) { 
        if (root != null) { 
            inorderRec(root.left); 
            Console.Write(root.key); 
            inorderRec(root.right); 
        } 
    }

        public void traversal(Node root)
        {
            if (root != null)
            {
                traversal(root.left);
                Console.Write(root.key);
                traversal(root.right);
            }
        }
        //determine the height of a binary tree.
        public int height(Node node)
        {
            if (node == null)
            { return 0; }
            else {
                //recursive call to the function
                int lDepth = height(node.left);
                int rDepth = height(node.right);

                if (lDepth > rDepth) { return (lDepth + 1); }
                else{return rDepth+1;}
            }
        }

    }
}
