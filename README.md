## Partial Classes in C#

### What is a Partial Class?

A **partial class** allows you to split the definition of a class, struct, or interface across multiple files. All parts are combined into a single class at compile time.

```csharp
// File1.cs
public partial class MyClass
{
    public void MethodA() { }
}

// File2.cs
public partial class MyClass
{
    public void MethodB() { }
}
```

## Key Points

- Use the `partial` keyword to split class, struct, or interface definitions across multiple files.
- All parts must be in the same namespace and assembly.
- All parts must have the same accessibility level.
- If one part is marked as `abstract`, `sealed`, or `base`, the entire class adopts that modifier.
- All files must be available at compile time.

## Why Use Partial Classes?

- Enables multiple developers to work on different parts of the same class.
- Helps separate UI code from business logic for better organization.
- Improves maintainability by breaking large classes into smaller, logical parts.
