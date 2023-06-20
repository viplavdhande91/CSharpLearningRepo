### Definition
- The Observer design pattern defines a **one-to-many dependency between objects** so that when **one object changes state**, all its dependents are notified and updated automatically.

### When to use it?
- Changes in the state of an object need **to be notified to a set of dependent objects**, not all of them.

 - The Sending object who is sending the notification **does not need to know about the receivers objects.**

### Typical Use Cases:
- A mailing list where every time an event happens (i.e. a new product, a gathering, etc.) **a message needs to send to the users who subscribed to the list.**

- The Company needs to notify all its employees of any decision they make. Here, the **Company is the Subject**, and the **Employees are the Observers**. Any change in the policy of the company and the company need to notify all its employees or you can say, Observers. This is a simple real-world example of the Observer Design Pattern.

### How Does the Observer Design Pattern Work?
The observer design pattern is having two main components. They are as follows

- **Subject:** They are also called Publishers. When a change occurs to a subject it should notify all its Subscribers/Observers.
- **Observers:** They are also called subscribers. They simply listen to the changes in the subjects.
   Another name of the Observer is the Listener.