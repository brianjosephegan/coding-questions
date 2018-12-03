using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace FindMidpoint
{
    /// <summary>
    /// Class to find midpoint of a linked list.
    /// </summary>
    public class MidpointFinder
    {
        /// <summary>
        /// Find the node at the center of the specified linked list and returns its data.
        /// </summary>
        /// <param name="list">List to find midpoint of.</param>
        /// <returns>Data held by node at the center.</returns>
        public object Find(LinkedList list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "list cannot be null");
            }

            return list.FindMidpoint();
        }
    }
}
