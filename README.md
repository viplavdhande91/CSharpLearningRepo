
# Partial Classes in c#
## Important points: 


1. When you want to chop the functionality of the class, method, interface, or structure into multiple files, then you should use partial keyword and all the files are mandatory to be available at compile time for creating the final file.

2. The partial modifier can only present instantly before the keywords like struct, class, and interface.


3. Every part of the partial class definition should be in the same assembly and namespace, but you can use a different source file name.

4. Every part of the partial class definition should have the same accessibility as private, protected, etc.
5. If any part of the partial class is declared as an abstract, sealed, or base, then the whole class is declared of the same type.

# Why use Partial Classes?



1. multiple developers can work simultaneously in the same class in different files.


2. you can split the UI of the design code and the business logic code to read and understand the code.


3.You can also maintain your application in an efficient manner by compressing large classes into small ones.
 

