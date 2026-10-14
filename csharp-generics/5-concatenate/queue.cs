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
    /// Removes the first node in the queue and returns its value.
    /// </summary>
    /// <returns>
    /// The value of the removed node, or the default value of
    /// <typeparamref name="T"/> if the queue is empty.
    /// </returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;

        // The queue is now empty, so tail must not keep pointing at the removed node
        if (head == null)
            tail = null;

        count--;
        return value;
    }

    /// <summary>
    /// Returns the value of the first node in the queue without removing it.
    /// </summary>
    /// <returns>
    /// The value of the first node, or the default value of
    /// <typeparamref name="T"/> if the queue is empty.
    /// </returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    /// <summary>
    /// Prints the value of each node in the queue, starting from the head.
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        for (Node current = head; current != null; current = current.next)
            Console.WriteLine(current.value);
    }

    /// <summary>
    /// Concatenates all values in the queue. Strings are joined with a space,
    /// chars are joined with no separator.
    /// </summary>
    /// <returns>
    /// The concatenated values, or <c>null</c> if the queue is empty or is not
    /// a queue of strings or chars.
    /// </returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        // Words read naturally with spaces between them, letters form one word
        string separator = typeof(T) == typeof(string) ? " " : "";
        string result = "" + head.value;

        for (Node current = head.next; current != null; current = current.next)
            result += separator + current.value;

        return result;
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
