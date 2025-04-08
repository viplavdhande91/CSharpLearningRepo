# C# Abstraction

## What is Abstraction?

**Abstraction** is the concept of hiding implementation details and showing only essential features of an object. It helps in reducing complexity and increasing code readability.

## Abstract Classes and Methods

- An **abstract class** is a class that cannot be instantiated directly. It is meant to be inherited by other classes.
- An **abstract method** has no body and must be implemented by a derived class.

```csharp
public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

## Key Points

- Abstract classes cannot be instantiated.
- Abstract methods must be defined in an abstract class.
- Derived classes must implement all abstract methods.
- Abstract classes can contain both abstract and non-abstract members.

## Why and When to Use

- Use abstraction to **enforce a contract** for derived classes.
- Helps **hide internal implementation** details and expose only relevant parts.
- Promotes **security**, **modularity**, and **clean architecture**.

> **Note:** Abstraction can also be achieved using interfaces.
