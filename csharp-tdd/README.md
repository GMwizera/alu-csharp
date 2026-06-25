# C# - Test-Driven Development

This project introduces unit testing and the Test-Driven Development (TDD)
approach in C# using NUnit and .NET Core. Each task is a single solution
containing two projects:

- A **class library** that solves the task.
- A **test library** that tests the class library.

## Tasks

| Task | Solution | Namespace | Class | Description |
|------|----------|-----------|-------|-------------|
| 0 | `0-add` | `MyMath` | `Operations` | Adds two integers. |
| 2 | `2-max_int` | `MyMath` | `Operations` | Returns the max integer in a list (0 if empty). |
| 5 | `5-camelcase` | `Text` | `Str` | Counts the words in a camelCase string. |

## Project layout

```
0-add/
    0-add.sln
    MyMath/
        MyMath.cs
        MyMath.csproj
    MyMath.Tests/
        MyMath.Tests.cs
        MyMath.Tests.csproj
```

## Running the tests

From a task's root directory:

```bash
dotnet test
```

## Author

Gisele Mwizera
