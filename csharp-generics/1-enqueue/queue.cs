using System;

/// <summary>
/// Represents a generic queue implemented with a singly linked list.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a single node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public T value = default(T);

        /// <summary>
        /// The next node in the queue.
        /// </summary>
        public Node next = null;

        /// <summary>
        /// Initializes a new node with the given value.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// The first node in the queue.
    /// </summary>
    public Node head;

    /// <summary>
    /// The last node in the queue.
    /// </summary>
    public Node tail;

    /// <summary>
    /// The number of nodes in the queue.
    /// </summary>
    public int count;

    /// <summary>
    /// Creates a new node with the given value and adds it to the end of the queue.
    /// </summary>
    /// <param name="value">The value to add.</param>
    public void Enqueue(T value)
    {
        Node node = new Node(value);

        if (head == null)
            head = node;
        else
            tail.next = node;

        tail = node;
        count++;
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes in the queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Returns the type of elements stored in the queue.
    /// </summary>
    /// <returns>The <see cref="Type"/> of <typeparamref name="T"/>.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
