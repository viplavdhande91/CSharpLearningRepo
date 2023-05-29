## Serializations ?

1.  Serialization is the process of **converting** an object into a stream of bytes to store the object or transmit it to memory, a database, or a file.

2.  Its main purpose is to save the state of an object in order to be able to recreate it when needed.

3.  the reverse process is called “De-Serialization”.



## TYPES OF SERIALIZATION
1. Serializing In Binary [**Should never be used as per Microsoft documents which is vulnerable**]
2. Serializing In XML
3. Serializing In JSON

## How serialization works?
1. In C#, the stream may also have information about the object’s type, such as its version, culture, and assembly name.
2. From that stream, the object can be stored in a database, a file, or memory.


## Uses for serialization
1. In C#, Serialization allows the developer to save the state of an object and re-create it as needed, providing storage of objects as well as data exchange.
2. In C#, Through serialization, a developer can perform actions such as:
  - Sending the object to a remote application by using a web service 
  - Passing an object from one domain to another
  - Passing an object through a firewall as a JSON or XML string
  - Maintaining security or user-specific information across applications

## Important Points
1. ~~In C#, If you want to make a class Serializable then you have to use **[Serializable]** attribute on top of your class.[Applicable in cases of Binary Serialization]~~

2. Namespace used for this purpose using System.Xml.Serialization;


## Generics and Collections

 - [Why should avoid using Binary serialization](https://learn.microsoft.com/en-us/dotnet/standard/serialization/binaryformatter-security-guide)
 

 - [Useful Article](https://www.shekhali.com/serialization-and-deserialization-in-csharp/)