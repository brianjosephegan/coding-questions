using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /// <summary>
    /// Class to implement a tree.
    /// </summary>
    public class Tree<T>
    {
        /// <summary>
        /// Root node.
        /// </summary>
        public Node<T> Root { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Tree()
        {
            Root = null;
        }

        /// <summary>
        /// Returns array of nodes in breadth first order.
        /// </summary>
        /// <returns>Array of nodes in breadth first order.</returns>
        public T[] BreadthFirstTraverse()
        {
            List<T> results = new List<T>();
            List<Node<T>> toVisit = new List<Node<T>>();
            toVisit.Add(Root);

            while (toVisit.Count > 0)
            {
                Node<T> node = toVisit[0];
                toVisit.RemoveAt(0);

                results.Add(node.Data);
                toVisit.AddRange(node.Children);
            }

            return results.ToArray();
        }

        /// <summary>
        /// Returns array of nodes in depth first order.
        /// </summary>
        /// <returns>Array of nodes in depth first order.</returns>
        public T[] DepthFirstTraverse()
        {
            List<T> results = new List<T>();
            List<Node<T>> toVisit = new List<Node<T>>();
            toVisit.Add(Root);

            while (toVisit.Count > 0)
            {
                Node<T> node = toVisit[0];
                toVisit.RemoveAt(0);

                results.Add(node.Data);
                toVisit.InsertRange(0, node.Children);
            }

            return results.ToArray();
        }

        /// <summary>
        /// Class to implement tree node.
        /// </summary>
        /// <typeparam name="T">Type of data node stores.</typeparam>
        public class Node<T>
        {
            /// <summary>
            /// Data of the node.
            /// </summary>
            public T Data { get; private set; }

            /// <summary>
            /// Children of the node.
            /// </summary>
            public List<Node<T>> Children { get; private set; }

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="data">Data to hold.</param>
            public Node(T data)
            {
                Data = data;
                Children = new List<Node<T>>();
            }

            /// <summary>
            /// Adds a new node to the list of child nodes using the specified data.
            /// </summary>
            /// <param name="data">Data to add.</param>
            public void Add(T data)
            {
                Children.Add(new Node<T>(data));
            }

            /// <summary>
            /// Removes any nodes from the list of child nodes whose data matches the specified data.
            /// </summary>
            /// <param name="data">Data to remove.</param>
            public void Remove(T data)
            {
                Children.RemoveAll(n => n.Data.Equals(data));
            }
        }
    }
}
