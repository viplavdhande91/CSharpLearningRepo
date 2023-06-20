#### Subject
- This is an **interface** having members that will be implemented by RealSubject and Proxy class.

#### RealSubject
- This is a **class** which we want to use more efficiently by using proxy class.

#### Proxy
- This is a class which **holds the instance of RealSubject** class and can access RealSubject class members as required.

### When to use it?
- Objects need to be created on demand means when their operations are requested.

- **Access control** for the original object is required.

- Allow **accessing a remote object** by using a local object.

    ![Proxy Pattern](https://github.com/viplavdhande91/C-sharp-Learning/blob/proxy-design-pattern/proxy.png?raw=true)

