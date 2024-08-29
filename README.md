
# **Facade Design Pattern Notes**

## **Introduction**
The **Facade Design Pattern** is one of the structural design patterns, providing a **simplified interface** to a complex subsystem. 

## **Purpose**
The primary purpose of the Facade pattern is to:
- Simplify interactions with complex subsystems. e.g Customer accessing BankSystems
- Decouple the client code from the subsystem's implementation.
- Handles instatntiation and redirection of taks to the approporiate class within the      subsystem. 
- **Example:**  In Hotels Waiter is a facade who interacts with a customer


## **Participants**
- **Client:** Uses the Facade to interact with the subsystem. 
   - e.g Customer of Bank
- **Facade:** Provides the client with a simple interface. 
  - e.g BankService Class
- **Subsystem Classes:** Perform the complex operations behind the scenes. 
  -  e.g IAccounts 


 
## **Benefits**
- **Reduces Complexity:** Provides a simple interface to a complex system.
- **Decouples Client from Subsystems:** Changes in the subsystem do not affect the client.
- **Improves Code Readability:** Makes the system easier to understand and maintain.

## **Drawbacks**
- **Over-Simplification:** May hide important functionalities or details of the subsystem.
- **Additional Layer:** Introduces an extra layer that might not be necessary in simpler systems.

