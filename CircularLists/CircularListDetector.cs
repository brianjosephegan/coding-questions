using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace CircularLists
{
    public class CircularListDetector
    {
        /// <summary>
        /// Detects whether the specified linked list is a circular linked list.
        /// </summary>
        /// <param name="list">Linked list to do detectio on.</param>
        /// <returns>True if the list is circulr; false otherwise.</returns>
        public bool Detect(LinkedList list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "list cannot be null");
            }

            return list.IsCircular();
        }
    }
}
