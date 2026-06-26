# csharp-tdd

Test-Driven Development exercises in C#. Each task is a solution containing
two projects: a class library that solves the task, and an NUnit test library
that exercises the class library.

## Tasks

| # | Folder      | Description                                     |
|---|-------------|-------------------------------------------------|
| 0 | `0-add`     | `MyMath.Operations.Add(int a, int b)` — sum two integers. |
| 1 | `1-divide`  | `MyMath.Matrix.Divide(int[,] matrix, int num)` — divide every element of a matrix by `num`. |
| 2 | `2-max_int` | `MyMath.Operations.Max(List<int> nums)` — return the largest integer in the list (0 if empty). |
| 3 | `3-palindrome` | `Text.Str.IsPalindrome(string s)` — case-insensitive palindrome check, ignoring spaces and punctuation. |

## Running tests

From inside a task folder (e.g. `0-add`):

```
dotnet test
```
