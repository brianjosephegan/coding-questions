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
    public class Tree
    {
        /// <summary>
        /// Root node.
        /// </summary>
        public Node Root { get; set; }

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
        public object[] BreadthFirstTraverse()
        {
            List<object> results = new List<object>();
            List<Node> toVisit = new List<Node>();
            toVisit.Add(Root);

            while (toVisit.Count > 0)
            {
                Node node = toVisit[0];
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
        public object[] DepthFirstTraverse()
        {
            List<object> results = new List<object>();
            List<Node> toVisit = new List<Node>();
            toVisit.Add(Root);

            while (toVisit.Count > 0)
            {
                Node node = toVisit[0];
                toVisit.RemoveAt(0);

                results.Add(node.Data);
                toVisit.InsertRange(0, node.Children);
            }

            return results.ToArray();
        }

        /// <summary>
        /// Class to implement tree node.
        /// </summary>
        public class Node
        {
            /// <summary>
            /// Data of the node.
            /// </summary>
            public object Data { get; private set; }

            /// <summary>
            /// Children of the node.
            /// </summary>
            public List<Node> Children { get; private set; }

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="data">Data to hold.</param>
            public Node(object data)
            {
                Data = data;
                Children = new List<Node>();
            }

            /// <summary>
            /// Adds a new node to the list of child nodes using the specified data.
            /// </summary>
            /// <param name="data">Data to add.</param>
            public void Add(object data)
            {
                Children.Add(new Node(data));
            }

            /// <summary>
            /// Removes any nodes from the list of child nodes whose data matches the specified data.
            /// </summary>
            /// <param name="data">Data to remove.</param>
            public void Remove(object data)
            {
                Children.RemoveAll(n => n.Data.Equals(data));
            }
        }
    }
}
