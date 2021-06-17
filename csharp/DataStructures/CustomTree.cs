using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.DataStructures
{
    class CustomBinaryTree
    {
        private class Node
        {
            public int value;
            public Node left, right;

            public Node(int val) {
                value = val;
                left = right = null;
            }
        }

        private Node root;

        public CustomBinaryTree(int key) {
            root = new Node(key);
        }

        public CustomBinaryTree()
        {
            root = null;
        }

        public void insert(int element)
        {
            
            if(root == null)
            {
                root = new Node(element);
            } 
            else
            {
                Node newNode = new Node(element);

                Queue<Node> traversalQueue = new Queue<Node>();
                traversalQueue.Enqueue(root);

                Node treeNode;
                while(traversalQueue.Count != 0)
                {
                    treeNode = traversalQueue.Dequeue();

                    if (treeNode.left == null)
                    {
                        treeNode.left = newNode;
                        break;
                    }
                    else
                        traversalQueue.Enqueue(treeNode.left);

                    if (treeNode.right == null)
                    {
                        treeNode.right = newNode;
                        break;
                    }
                    else
                        traversalQueue.Enqueue(treeNode.right);
                }
            }
        }

        // delete from tree
        public void remove(string element)
        {
            // search for matching node

            // remove that node

        }

        // Should prune then rebalance tree
        public void PruneTreeAtNode()
        {

        }

        // After grafting, should balance tree
        public void GraftTree(int element)
        {

        }

        public void PrintInOrder()
        {
            if (root == null)
                Console.Write("Tree is empty");
                return;
            InOrder(root);
        }

        private void InOrder(Node node)
        {
            if (node == null)
                return;

            InOrder(node.left);
            Console.Write(node.value + " ");
            InOrder(node.right);
        }

        private void RebalanceTree()
        {

        }

        private Node BreadthFirstSearch()
        {
            return null;
        }

        private Node DepthFirstSearch()
        {
            return null;
        }
    }
}
