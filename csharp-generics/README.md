## Tasks

| Task | File | Description |
|------|------|-------------|
| 0. Queue | [0-queue/queue.cs](0-queue/queue.cs) | Create a class `Queue<T>` with a `CheckType()` method that returns the queue's type. |
| 1. Enqueue | [1-enqueue/queue.cs](1-enqueue/queue.cs) | Add a nested `Node` class, `head`/`tail`/`count`, an `Enqueue()` method that adds a node to the end, and `Count()`. |
| 2. Dequeue | [2-dequeue/queue.cs](2-dequeue/queue.cs) | Add `Dequeue()`, which removes the first node and returns its value, or prints `Queue is empty` and returns `default(T)`. |
| 3. Peek | [3-peek/queue.cs](3-peek/queue.cs) | Add `Peek()`, which returns the first node's value without removing it, or prints `Queue is empty` and returns `default(T)`. |
| 4. Print | [4-print/queue.cs](4-print/queue.cs) | Add `Print()`, which prints each value from head to tail, or `Queue is empty`. |

## Documentation

- All public types and members are documented with XML `<summary>` tags.
- Private members are documented with regular comments (no XML tags).

## Environment

- All files will be compiled on Ubuntu 14.04 LTS using `dotnet` (`Windows .Net 7.0 SDK`)
- Each task has its own folder and `.csproj` file

## Author

Gisele Mwizera
