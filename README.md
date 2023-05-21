
# Exception
## Important points: 

1. Exception is a Runtime Error and the reason could be either because of some software error or limitations of hardware
2.  In .Net, every exception is an object of type **System.Exception** or any of its sub class.
3. Exception is an **object** because it can encapsulate all the data required for properly handling an exception in catch block.
4. Whenever the integrity of an object is violated, exception is thrown. 
5. Exception handling is done by providing **try -- catch** blocks. 
6. For one try we can have multiple catch blocks and each catch block can be used as an exception handler for a particular type of exception
7. A try block can have any number of catch blocks but only one catch block is executed if an exception is thrown i.e. the first matching catch block is executed.
8. For a given try, the catch block of parent class must be always after the catch block of child class.
9. If an exception is thrown and is unhandled in an inner block then it is automatically thrown to its outer block. 
10. If an exception is thrown in the called method and if it unhandled in the called method then the exception is automatically thrown to its calling method.
11. If the exception occurs in Main function and is unhandled then **CLR** handles it and the program is terminated.

## throw vs throw ex: 

1. **throw preserves the stack trace**.It is **good** practice to use throw.
2. throw ex preserves the stack trace.


##  Notes: 

1. Innerexception is used to get track of exception happened inside.
#####  e.g If f1() calls f2(); f2() calls f3(). And somehow exception occurs at f3() .Now If control returns to f3() -> f2() ->f1().In this journey we **should preserve exception at f3()**.Hence innerException Property is used.
