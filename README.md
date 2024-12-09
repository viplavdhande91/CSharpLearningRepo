## Notes
 

### ConcurrentBag<T> from System.Collections.Concurrent

- `ConcurrentBag<T>` is designed to handle situations where **multiple threads need to add and remove items concurrently** from collection without needing explicit synchronization mechanisms. It is particularly useful when order is not important, and efficient concurrent access is required.

#### Key Features

- **Thread-Safe Operations:** Internally synchronized to support safe concurrent modifications from multiple threads.

---