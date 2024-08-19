### IProgress Interface

- IProgress<T> can be used to report progress of **some procedure** to **another procedure**. This example shows how you can create a basic method that reports its progress.

### Benefit
-  Long-running operations are typically set up as asynchronous methods to prevent the application from blocking these long processes. In this scenario, it is helpful to have a mechanism to report the progress back to the user, to give them an expectation of the running time. The IProgress interface can be used for that purpose.

### Note:

- Using IProgress
It's important to note that the **System.Progress<T>** class does not have the **Report()** method available on it. This method was implemented explicitly from the IProgress<T> interface, and therefore must be called on a Progress<T> when it's cast to an IProgress<T>.

```csharp
var p1 = new Progress<int>();
p1.Report(1); //compiler error, Progress does not contain method 'Report'

IProgress<int> p2 = new Progress<int>();
p2.Report(2); //works

var p3 = new Progress<int>();
((IProgress<int>)p3).Report(3); //works
```