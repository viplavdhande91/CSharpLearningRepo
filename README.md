
### 🔗 [Garbage Collection Notes ](https://drive.google.com/drive/folders/1ybJ-9mlHDTTdiTPaucHYSIacIXspViii?usp=sharing)

### Dispose vs Finalize in C#

When working with unmanaged resources in C#, it's important to release them properly to avoid memory leaks. The `.NET` framework provides two mechanisms to do this: `Dispose` and `Finalize`. Below is a detailed comparison and explanation of both.

---

## Dispose Method

- **Purpose**: `Dispose` is a method used to explicitly release unmanaged resources. It is typically called by the consumer of the object.
- **Implementation**: It is implemented through the `IDisposable` interface.
- **Control**: The user has full control over when to release the resources by calling the `Dispose` method.
- **Deterministic**: Yes, it is deterministic as it releases resources immediately when `Dispose` is called.
- **Usage**: Best used for cleaning up unmanaged resources such as file handles, database connections, etc., where immediate resource release is required.
- **Pattern**: Often used in conjunction with the "using" statement, which automatically calls `Dispose` when the block is exited.

## Finalize Method

- **Purpose**: `Finalize` is a method used to release unmanaged resources before an object is garbage collected. It is typically used as a fallback if `Dispose` is not called.
- **Implementation**: `Finalize` is implemented by overriding the `Object.Finalize` method.
- **Control**: The user has no control over when the garbage collector will call `Finalize`.
- **Deterministic**: No, it is non-deterministic since the timing of garbage collection is uncertain.
- **Usage**: Generally used to clean up unmanaged resources if `Dispose` hasn't been called. This is the last resort for resource cleanup.
- **Pattern**: Usually not implemented directly; instead, the `Dispose` pattern includes a `Finalize` method to ensure that resources are cleaned up if `Dispose` is not called.

---

## Comparison Table: Dispose vs Finalize

| Feature          | Dispose                           | Finalize                          |
|------------------|-----------------------------------|-----------------------------------|
| **Purpose**      | Release unmanaged resources       | Release unmanaged resources       |
| **Implementation**| `IDisposable.Dispose` method     | `Object.Finalize` method          |
| **Control**      | Full control (user-defined timing)| No control (GC-defined timing)    |
| **Deterministic**| Yes, immediate release            | No, non-deterministic             |
| **Usage**        | Explicit resource cleanup         | Fallback if `Dispose` is not called|
| **Pattern**      | `using` statement or manual call  | Automatic, part of the `Dispose` pattern |
| **Call Order**   | Called explicitly by user         | Called by Garbage Collector       |
| **Performance**  | More efficient as it avoids GC    | Less efficient, involves GC overhead|
| **Error Handling**| Allows catching exceptions       | Difficult to handle exceptions    |
| **Typical Resources**| File handles, database connections| Any unmanaged resource (as a backup) |

---

## Summary

- **Use `Dispose`**: When you need deterministic resource cleanup, especially for unmanaged resources that must be released promptly.
- **Implement `Finalize`**: Only as a safety net for cases where `Dispose` was not called. Use it as part of the `Dispose` pattern, which ensures that resources are cleaned up even if the object is not explicitly disposed of.

### Example: Dispose Pattern with Finalize

```csharp
public class ResourceHolder : IDisposable
{
    private bool disposed = false; // To detect redundant calls

    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            // Free any other managed objects here.
            //
        }

        // Free any unmanaged objects here.
        //
        disposed = true;
    }

    // Destructor
    ~ResourceHolder()
    {
        Dispose(false);
    }
}
```

This pattern ensures that resources are cleaned up deterministically with `Dispose` and non-deterministically as a fallback with `Finalize`.