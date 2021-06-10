using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.DataStructures
{
    class CustomTree
    {
        private class Node
        {
            public string value { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }

            public Node() {
                value = "";
                left = null;
                right = null;
            }
        }

        public CustomTree() {
            Node root = new Node();
        }

        // add to tree

        // delete from tree

        // pruning and grafting maybe

        // breadth first search

        // depth first search
    }
}
