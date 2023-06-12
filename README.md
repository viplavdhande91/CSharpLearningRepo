"# C-Learning" 

## LINQ  Reference

### Single :
- **Description** : Returns the only element from a collection **or** the only element that satisfies a condition. 
  - **Exception**:  If Single() found no elements or more than one elements in the collection then throws InvalidOperationException.

- Example: 
 
 ```
    var result = selectedBooks.Single(45.5);

 ```


### SingleOrDefault :
- **Description** :  returns a default value of a specified generic type, instead of throwing an exception if no element found for the specified condition.. 
  - **Exception**:  it will thrown InvalidOperationException if it found more than one element for the specified condition in the collection.

- Example: 
 
 ```
    var result = selectedBooks.SingleOrDefault(45.5);

```

### First :
- **Description** :  Returns the first element of a collection, or the first element that satisfies a condition.



### FirstOrDefault :
- **Description** :  Returns the first element of a collection, or the first element that satisfies a condition. Otherwise , Returns a default value of first index.


### FirstOrDefault :
- **Description** :  Returns the first element of a collection, or the first element that satisfies a condition. Otherwise , Returns a default value of first index.

### Max :

```
        var studentWithLongName = studentList.Max();

```