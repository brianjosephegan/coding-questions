using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    /// <summary>
    /// Class to implement a binary search tree.
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// Insert the specified data into the tree.
        /// </summary>
        /// <param name="data">Data to insert.</param>
        public void Insert(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
            }
            else
            {
                Insert(data, Root);
            }
        }

        /// <summary>
        /// Checks whether the tree contains the specified data.
        /// </summary>
        /// <param name="data">Data to check for.</param>
        /// <returns>True if the tree contains the data; false otherwise.s</returns>
        public bool Contains(int data)
        {
            return Contains(data, Root);
        }

        /// <summary>
        /// Checks whether the tree is a binary search tree.
        /// </summary>
        /// <returns>True if the tree is valid; false otherwise.</returns>
        public bool Validate()
        {
            return Validate(Root, int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Root node of the tree.
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Recursively inserts the specified data starting at the specified node.
        /// </summary>
        /// <param name="data">Data to insert.</param>
        /// <param name="node">Node to use.</param>
        private void Insert(int data, Node node)
        {
            if (data < node.Data && node.Left != null)
            {
                Insert(data, node.Left);
            }
            else if (data < node.Data)
            {
                node.Left = new Node(data);
            }
            else if (data >= node.Data && node.Right != null)
            {
                Insert(data, node.Right);
            }
            else
            {
                node.Right = new Node(data);
            }
        }

        /// <summary>
        /// Recursively checks to see if the specified data is contained in the tree, starting at the specified node.
        /// </summary>
        /// <param name="data">Data to insert.</param>
        /// <param name="node">Node to start at.</param>
        /// <returns>True if the data is contained in the tree; false otherwise.</returns>
        private bool Contains(int data, Node node)
        {
            if (node == null)
            {
                return false;
            }
            else if (data == node.Data)
            {
                return true;
            }
            else if (data < node.Data)
            {
                return Contains(data, node.Left);
            }
            else
            {
                return Contains(data, node.Right);
            }
        }

        /// <summary>
        /// Recursively checks to see if the tree is a valid binary search tree, starting at the specified node.
        /// </summary>
        /// <param name="node">Node to start at.</param>
        /// <param name="min">Minimum valid data.</param>
        /// <param name="max">Maximum valid data.</param>
        /// <returns>True if the tree is a valid binary search tree; false otherwise.</returns>
        private bool Validate(Node node, int min, int max)
        {
            if (node.Data > max)
            {
                return false;
            }

            if (node.Data < min)
            {
                return false;
            }

            if (node.Left != null && !Validate(node.Left, min, node.Data))
            {
                return false;
            }

            if (node.Right != null && !Validate(node.Right, node.Data, max))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Class to implement a tree node.
        /// </summary>
        public class Node
        {
            /// <summary>
            /// Data held by the node.
            /// </summary>
            public int Data { get; private set; }

            /// <summary>
            /// Node to the left.
            /// </summary>
            public Node Left { get; set; }

            /// <summary>
            /// Node to the right.
            /// </summary>
            public Node Right { get; set; }

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="data">Data to hold.</param>
            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }
    }
}
