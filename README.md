## Definition: 
The singleton pattern is a design pattern that **restricts the instantiation** of a class to **one object.**

## What is singleton pattern

- A class Object having **only one instance** and able to perform all task.

- This design pattern is considered as **creational(object creation)** design pattern.

- No constructor **[Parameterized]** parameters are allowed while creating an instance.

- Going with ```Lazy<T>``` guarnatees  thread safe . Using Lazy object is not instantiated unless its **.Value** Property is accessed .


### How to implement singleton design pattern in C#

▸A single constructor, that is **private and parameterless.**

▸All class variables should be **static**.

▸A **public static** means of getting the reference to the single created instance, creating one if necessary.

### Pros and Cons of Singleton Design Pattern

#### Pros
- Singleton design pattern guarantees that only one instance of the class will be available throughout the application context. This ensures that you **do not waste memory for a new object instance** when you don’t need one.

- Singleton design pattern might be handy when dealing with **concurrent access** to resources. 
- Singletons can also provide thready safety.

#### Cons
- Singleton design pattern introduces a global state in the application. **This makes unit testing difficult.** The global state does not align well with unit testing because it increases coupling, and control over more than one unit is needed while writing the unit tests.
- Due to the **resource being locked in a parallel processing environment, multi-threading** in some cases can not be used to its **full potential** with singelton design pattern.
- Singleton design pattern solves less than it causes. This means this pattern has **minimal practical use cases** and, if used otherwise, can generate more problems. Some of these are also direct violations of other design patterns. **(e.g., Single Responsibility Principle)**


##### Use Cases
- Logger
- Managing a database connection pool
- Caching frequently accesed data
