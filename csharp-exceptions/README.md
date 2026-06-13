# C# - Exceptions

This project covers exceptions and exception handling in C#.

## Learning Objectives

- What are exceptions and when to use them
- What is the purpose of catching exceptions
- How to handle exceptions
- How to use `try`, `catch`, `finally`
- How to raise built-in exceptions
- When to implement clean-up actions after exceptions

## Tasks

| Task | File | Description |
|------|------|-------------|
| 0. Safe list printing | [0-safe_list_print](0-safe_list_print/) | Prints `n` elements of a list, returning the number actually printed, using `try`/`catch`. |
| 1. Integer division | [1-divide_print](1-divide_print/) | Divides two integers and prints the result in a `finally` block, handling division by zero. |
| 2. Divide lists | [2-divide_lists](2-divide_lists/) | Divides two lists element by element, handling division by zero and out-of-range indices. |
| 3. Throw exception | [3-throw_exception](3-throw_exception/) | A method that throws an `Exception`. |
| 4. Throw exception with message | [4-throw_exception_msg](4-throw_exception_msg/) | A method that throws an `Exception` carrying a custom message. |

## Requirements

- All files compiled on Ubuntu 14.04 LTS using `dotnet`
- Each task has its own folder and `.csproj` file
- Namespaces are omitted in this project
