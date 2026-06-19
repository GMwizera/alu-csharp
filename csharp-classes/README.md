# C# - Classes

This project covers the basics of classes in C#, including defining classes,
fields, properties, constructors, methods, access modifiers, and documenting
code with XML documentation comments.

## Learning Objectives

- Why C# programming is awesome
- What is a class
- What is an object and an instance
- What is the difference between a class and an object or instance
- What is the relationship between classes and objects
- What is encapsulation
- What is a property and how to use them
- What are getters and setters
- How to write XML documentation comments
- What is garbage collection in C#

## Tasks

| Task | File | Description |
|------|------|-------------|
| 0. Braaainsss | [0-enemy/](0-enemy/) | Create an empty public class `Zombie` inside the `Enemies` namespace. |
| 1. Healthy competition | [1-enemy/](1-enemy/) | Add a public `health` field and a public constructor that sets `health` to 0. |
| 2. Health validation | [2-enemy/](2-enemy/) | Add a `Zombie(int value)` constructor that throws `ArgumentException` when `value` is less than 0. |
| 3. Zombie health | [3-enemy/](3-enemy/) | Make `health` private and add a public `GetHealth()` method that returns it. |
| 4. Hello, my name is | [4-enemy/](4-enemy/) | Add a private `name` field (default `(No name)`) and a public `Name` property with get/set. |
| 5. Printing a zombie | [5-enemy/](5-enemy/) | Override `ToString()` to print `Zombie Name: <name> / Total Health: <health>`. |

## Documentation

From this project forward, documenting code is required:

- All public types and members are documented with XML `<summary>` tags.
- Private members are documented with regular comments (no XML tags).
- XML documentation is enabled in each `.csproj` with the `DocumentationFile`
  property, so building generates an `.xml` file that VS Code reads for tooltips.

## Environment

- Compiled on Ubuntu with `dotnet`
- Each task has its own folder and `.csproj` file

## Author

Gisele Mwizera
