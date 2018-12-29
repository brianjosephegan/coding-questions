using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stacks;

namespace QueueStacks
{
    /// <summary>
    /// Class to implement a queue using stacks.
    /// </summary>
    public class QueueStack
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public QueueStack()
        {
            addingStack = new Stack();
            removingStack = new Stack();
            mode = Mode.Adding;
            count = 0;
        }

        /// <summary>
        /// Adds the specified item to the back of the queue.
        /// </summary>
        /// <param name="item">Item to add.</param>
        public void Add(object item)
        {
            if (mode == Mode.Removing)
            {
                FlipStacks(removingStack, addingStack);
            }

            count++;
            addingStack.Push(item);
        }

        /// <summary>
        /// Peeks the item in the front of the queue.
        /// </summary>
        /// <returns>The item at the front of the queue.</returns>
        public object Peek()
        {
            if (count <= 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            if (mode == Mode.Adding)
            {
                FlipStacks(addingStack, removingStack);
            }

            return removingStack.Peek();
        }

        /// <summary>
        /// Removes the item at the front of the queue.
        /// </summary>
        /// <returns>The item at the front of the queue.</returns>
        public object Remove()
        {
            if (count <= 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            if (mode == Mode.Adding)
            {
                FlipStacks(addingStack, removingStack);
            }

            count--;
            return removingStack.Pop();
        }

        /// <summary>
        /// Adding stack.
        /// </summary>
        private Stack addingStack;

        /// <summary>
        /// Removing stack.
        /// </summary>
        private Stack removingStack;

        /// <summary>
        /// Mode.
        /// </summary>
        private Mode mode;

        /// <summary>
        /// Number of items in the queue.
        /// </summary>
        private int count;

        /// <summary>
        /// Mode
        /// </summary>
        private enum Mode
        {
            /// <summary>
            /// Adding to the queue.
            /// </summary>
            Adding,

            /// <summary>
            /// Removing from the queue.
            /// </summary>
            Removing
        }

        /// <summary>
        /// Flips the specified stacks, moving items from source stack to the destination stack.
        /// </summary>
        /// <param name="source">Source stack.</param>
        /// <param name="destination">Destination stack.</param>
        private void FlipStacks(Stack source, Stack destination)
        {
            try
            {
                while (true)
                {
                    destination.Push(source.Pop());
                }
            }
            catch (InvalidOperationException)
            {

            }
        }
    }
}
