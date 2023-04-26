
# C# IEnumerable

## Important points: 


1. Explanation: In C#, IEnumerable is an interface, and it is useful to enable an iteration over non-generic collections, and it is available with System.Collections namespace.






## Why And When To Use Interfaces?

1.   
##### IEnumerable interface also works with database calls expression less efficiently.


2.   
##### IEnumerable interface also works with in-memory collection calls expression more efficiently.


# C# IQueryable

## Important points: 


1. Explanation: In C#, IQueryable inherited from IEnumerable interface.only.It falls under System.LINQ namespace


## Why And When To Use Interfaces?

1.
#####  IQueryable inherited from IEnumerable interface Enumerable ,only, so anything you can do with a IEnumerable, you can also do with an IQueryable also.
2.
##### IEnumerable bring all result from database and  then filter it at code side, which is a network load and performance issue.

3.
##### IQueryable filter the result at database only and IQueryable then get only filtered result, therefore less  Database network load and better performance .
