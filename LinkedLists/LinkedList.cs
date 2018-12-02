using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /// <summary>
    /// Class to implement a linked list.
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public LinkedList()
        {
            this.head = null;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="head">First node of the linked list.</param>
        public LinkedList(Node head)
        {
            this.head = head;
        }

        /// <summary>
        /// Inserts the specified item at the front of the linked list.
        /// </summary>
        /// <param name="item">Item to insert.</param>
        public void InsertFirst(object item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item cannot be null");
            }

            head = new Node(head, item);
        }

        /// <summary>
        /// Gets the item at the front of the linked list.
        /// </summary>
        /// <returns>Item at the front of the linked list.</returns>
        public object GetFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }

            return head.Data;
        }

        /// <summary>
        /// Gets the number of items in the linked list.
        /// </summary>
        /// <returns>Number of items in the linked list.</returns>
        public int Size()
        {
            int result = 0;
            Node current = head;
            while (current != null)
            {
                result++;
                current = current.Next;
            }
            return result;
        }

        /// <summary>
        /// Gets the item at the back of the linked list.
        /// </summary>
        /// <returns>Item at the back of the linked list.</returns>
        public object GetLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Data;
        }

        /// <summary>
        /// Removes all items from the linked list.
        /// </summary>
        public void Clear()
        {
            head = null;
        }

        /// <summary>
        /// Removes the item at the front of the linked list.
        /// </summary>
        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }

            head = head.Next;
        }

        /// <summary>
        /// Removes the item at the back of the linked list.
        /// </summary>
        public void RemoveLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }

            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head.Next;
                Node previous = head;
                while (current.Next != null)
                {
                    previous = current;
                    current = current.Next;
                }

                previous.Next = null;
            }

        }

        /// <summary>
        /// Inserts the specified item at the back of the linked list.
        /// </summary>
        /// <param name="item">Item to insert.</param>
        public void InsertLast(object item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item cannot be null");
            }

            if (head == null)
            {
                head = new Node(null, item);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new Node(null, item);
            }
        }

        /// <summary>
        /// Removes the item at the specified index in the linked list.
        /// </summary>
        /// <param name="index">Index of item to remove.</param>
        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("index cannot be negative", nameof(index));
            }

            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }

            if (index == 0)
            {
                RemoveFirst();
            }
            else
            {
                Node current = head;
                Node previous = null;
                while (index > 0)
                {
                    if (current == null)
                    {
                        throw new InvalidOperationException("Index is outside of LinkedList");
                    }

                    previous = current;
                    current = current.Next;
                    index--;
                }

                previous.Next = current.Next;
            }
        }

        /// <summary>
        /// Gets the item at the specified index in the linked list.
        /// </summary>
        /// <param name="index">Index of item to get.</param>
        /// <returns>Item at the specified index.</returns>
        public object GetAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("index cannot be negative", nameof(index));
            }

            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }

            Node current = head;

            while (index > 0)
            {
                if (current == null)
                {
                    throw new InvalidOperationException("Index is outside of LinkedList");
                }

                current = current.Next;
                index--;
            }

            return current.Data;
        }

        /// <summary>
        /// Inserts the specified item at the specified index in the linked list.
        /// </summary>
        /// <param name="item">Item to insert.</param>
        /// <param name="index">Index to insert item at.</param>
        public void InsertAt(object item, int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("index cannot be negative", nameof(index));
            }

            if (index == 0)
            {
                Node newNode = new Node(head, item);
                head = newNode;
            }
            else
            {
                Node current = head;
                Node previous = null;
                while (index > 0)
                {
                    if (current == null)
                    {
                        throw new InvalidOperationException("Index is outside of LinkedList");
                    }

                    previous = current;
                    current = current.Next;
                    index--;
                }

                Node newNode = new Node(current, item);
                previous.Next = newNode;
            }
        }

        /// <summary>
        /// Applies the specified function to each item in the linked list.
        /// </summary>
        /// <param name="method">Function to apply.</param>
        public void ForEach(Func<object, object> method)
        {
            if (method == null)
            {
                throw new ArgumentNullException(nameof(method), "method cannot be null");
            }

            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty");
            }
            else
            {
                Node current = head;
                while (current != null)
                {
                    current.Data = method(current.Data);
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Head of the linked list.
        /// </summary>
        private Node head;

        /// <summary>
        /// Class to implement linked list node.
        /// </summary>
        public class Node
        {
            /// <summary>
            /// Next node in the list.
            /// </summary>
            public Node Next { get; set; }

            /// <summary>
            /// Data of the node.
            /// </summary>
            public object Data { get; set; }

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="data">Data of the node.</param>
            public Node(object data)
            {
                Next = null;
                Data = data;
            }

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="next">Next node in the list.</param>
            /// <param name="data">Data of the node.</param>
            public Node(Node next, object data)
            {
                Next = next;
                Data = data;
            }
        }
    }
}
