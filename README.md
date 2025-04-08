## Sealed Methods in C#

### What is a Sealed Method?

A **sealed method** in C# is an overridden method that cannot be further overridden in any derived class. It is declared using the `sealed` keyword along with the `override` keyword.

```csharp
public class BaseClass
{
    public virtual void Display() { }
}

public class DerivedClass : BaseClass
{
    public sealed override void Display() { }
}
```

## Key Points

- A sealed method must be an override of a base class method.
- It prevents further overriding in subclasses.
- Declared using both `sealed` and `override` keywords.
- Cannot be applied to methods that are not overrides.
- Sealing is not applicable to method hiding (`new` keyword).
