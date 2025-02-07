# NullReferenceException in C#

This repository demonstrates a common C# error: the `NullReferenceException`.  The exception is thrown when a program attempts to access a member (property or method) of a null object reference. This is a frequent source of bugs, especially in larger projects.

The `Bug.cs` file contains code that intentionally throws a `NullReferenceException`.  The `BugSolution.cs` file offers a solution to avoid this error.

## How to Reproduce the Bug

1. Clone this repository.
2. Open the `Bug.cs` file.
3. Run the `MyMethod()` function. The program will crash with a `NullReferenceException`.

## Solution

The `BugSolution.cs` file demonstrates how to avoid the `NullReferenceException` by checking for null values before accessing members of an object.

## Additional Resources

- Microsoft documentation on `NullReferenceException`: [https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception?view=net-7.0](https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception?view=net-7.0)