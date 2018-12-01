using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    /// <summary>
    /// Class to implement a stack.
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Stack()
        {
            top = -1;
            items = new object[2];
        }

        /// <summary>
        /// Pushes the specified item on to the top of the stack.
        /// </summary>
        /// <param name="item">Item to push.</param>
        public void Push(object item)
        {
            if (top + 1 == items.Length)
            {
                object[] newItems = new object[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }

            items[++top] = item;
        }

        /// <summary>
        /// Removes the item at the top of the stack.
        /// </summary>
        /// <returns>Item at the top of the stack.</returns>
        public object Pop()
        {
            if (top < 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[top--];
        }

        /// <summary>
        /// Peeks the item at the top of the stack.
        /// </summary>
        /// <returns>Item at the top of the stack.</returns>
        public object Peek()
        {
            if (top < 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[top];
        }

        /// <summary>
        /// Number of items in the stack.
        /// </summary>
        private int top;

        /// <summary>
        /// Array to store the items in the stack.
        /// </summary>
        private object[] items;
    }
}
