
# C# StringBuilder

## What is StringBuilder?

**StringBuilder** is a class in C# used to work with strings when you need to perform repeated modifications like appending, inserting, removing, or replacing characters without creating multiple immutable string instances.

```csharp
using System.Text;

StringBuilder sb = new StringBuilder("Hello");
sb.Append(" World");
Console.WriteLine(sb.ToString()); // Output: Hello World
```

## Why Use StringBuilder?

- Strings in C# are immutable; every modification creates a new string in memory.
- **StringBuilder** is more efficient for frequent string manipulations, especially inside loops.

## Common Methods

| Method          | Description                           |
|-----------------|---------------------------------------|
| `Append()`      | Adds a string to the end              |
| `Insert()`      | Inserts a string at a specific index  |
| `Remove()`      | Removes characters from a string      |
| `Replace()`     | Replaces characters in the string     |
| `ToString()`    | Converts the StringBuilder to string  |
| `Clear()`       | Removes all characters                |

## Example

```csharp
StringBuilder sb = new StringBuilder();
sb.Append("C# ");
sb.Append("StringBuilder ");
sb.Append("Example");
Console.WriteLine(sb); // Output: C# StringBuilder Example
```

## When to Use

- When concatenating strings inside loops
- When performance matters due to large string operations
