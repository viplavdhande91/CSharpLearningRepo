
## 🔗 Links
[Asynchronous Disposable in C# 8.0](https://dotnettutorials.net/lesson/asynchronous-disposable-in-csharp-8/)





### Notes
- Another important recommendation from Microsoft is that we should need to implement both the **IDisposable** and **IAsyncDisposable** interfaces in the class since not every consumer might be able to properly handle the new style yet. 
   - For example, a lot of older Inversion of Control frameworks are not capable of handling asynchronous disposals yet. Doing so ensures that you can properly cascade clean-up calls. Let us see an example, that implements both interfaces and demonstrates the proper guidance for clean-up. We are using the same **Sample** class.

-  we are using the **Stream** class which provides both synchronous as well as asynchronous disposal.