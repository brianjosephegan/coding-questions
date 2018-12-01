using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;

namespace QueueWeave
{
    /// <summary>
    /// Class to weave two queues together.
    /// </summary>
    public class QueueWeaver
    {
        /// <summary>
        /// Weaves the two specified queues together.
        /// </summary>
        /// <param name="one">First queue to weave.</param>
        /// <param name="two">Second queue to weave.</param>
        /// <returns>Queue consisting of elements interleaved from the two specified queues.</returns>
        public Queue Weave(Queue one, Queue two)
        {
            if (one == null)
            {
                throw new ArgumentNullException(nameof(one), "one cannot be null");
            }

            if (two == null)
            {
                throw new ArgumentNullException(nameof(two), "two cannot be null");
            }

            Queue result = new Queue();
            bool oneEmpty = false;
            bool twoEmpty = false;
            while (!oneEmpty || !twoEmpty)
            {
                try
                {
                    if (!oneEmpty)
                    {
                        result.Add(one.Remove());
                    }
                }
                catch (InvalidOperationException)
                {
                    oneEmpty = true;
                }

                try
                {
                    if (!twoEmpty)
                    {
                        result.Add(two.Remove());
                    }
                }
                catch (InvalidOperationException)
                {
                    twoEmpty = true;
                }
            }

            return result;
        }
    }
}
