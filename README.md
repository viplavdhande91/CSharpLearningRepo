### Creating Your own Asynchronous method

- Do not write **async void** combination for simple asynchronous method . (Allowed in cases of Event handlers async method)
```csharp
private async void Getstocks(){
    
}

```
- the Correct way is to go with "async Task" This will automatically have a Task returned without explicitly having to return anything.Compiler does that for Developer automatically .The Task is generated and automatically returned to caller method.


```csharp
private async Task Getstocks(){

}

```
- Never block and asynchromous operation by calling ```Result``` or ```Wait()``` . It could lead to deadlock .

- Use async and await all the way up the chain
### Exceptions Handling

- Never Handle expections using async void . The Exception occurs and cannot be able to handle .
 - Solution : Use **async Task** only

```csharp

namespace HelloWorld
{
    public class Class1
    {

        public static void demo()
        {
            getJsonData();
        }

        public static async void getJsonData()
        {
            List<int> arr = new List<int>() { 10, 22, 33, 44, 55 };
            try
            {

                for (int i = 0;i < 10;i++) { 

                    Console.WriteLine(arr[i]);
                }

            }
            catch (Exception ex)
            {
                int x = 5;
                throw ;
            }
        }
    }

}


       /*
       
       Exception will occur and code will break
       
       */ 
```