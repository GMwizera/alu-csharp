using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of elements stored in the queue.
    /// </summary>
    /// <returns>The <see cref="Type"/> of <typeparamref name="T"/>.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
