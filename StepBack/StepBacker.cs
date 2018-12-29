using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace StepBack
{
    /// <summary>
    /// Class to step back in a linked list.
    /// </summary>
    public class StepBacker
    {
        /// <summary>
        /// Returns the data held by the node n steps back from the end of the specified linked list.
        /// </summary>
        /// <param name="list">Linked list to return data from.</param>
        /// <param name="n">Number of nodes to step back.</param>
        /// <returns>Data held by node n steps back</returns>
        public object StepBack(LinkedList list, int n)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "list cannot be null");
            }

            if (n < 0)
            {
                throw new ArgumentException("n cannot be negative", nameof(n));
            }

            return list.FromLast(n);
        }
    }
}
