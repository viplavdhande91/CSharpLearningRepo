### Creating Your own Asynchronous method

- Do not write **async void** combination for simple asynchronous method . (Allowed in cases of Event handlers async method)
```csharp
private async void Getstocks(){}
```
- the Correct way is to go with *async Task* This will automatically have a Task returned without explicitly having to return anything. Compiler does that automatically for Developer .The Task is generated and automatically returned to caller method.


```csharp
private async Task Getstocks(){}
```
- Never block and asynchronous operation by calling ```Result``` or ```Wait()``` . It could lead to deadlock .

- Use async and await all the way up the chain.
### Exceptions Handling

- Never Handle expections using **async void** . The Exception occurs and cannot be able to handle .
 - Solution : Use **async Task** only

