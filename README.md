
# C# Encapsualation

## Important points: 


1. Explanation: In the above program the class DemoEncap is encapsulated as the variables are declared as private. To access these private variables we are using the Name  accessors which contain the get and set method to retrieve and set the values of private fields. Accessors/Properties are defined as public so that they can access in other class. 




## Why And When To Use Interfaces?

1. #### Data Hiding:  
##### The user will have no idea about the inner implementation of the class. It will not be visible to the user that how the class is stored values in the variables. He only knows that we are passing the values to accessors and variables are getting initialized to that value.



2. #### Increased Flexibility:
##### We can make the variables of the class as read-only or write-only depending on our requirement. If we wish to make the variables as read-only then we have to only use Get Accessor in the code. If we wish to make the variables as write-only then we have to only use Set Accessor.
3. #### Reusability: 
##### Encapsulation also improves the re-usability and easy to change with new requirements.

4. #### Testing code is easy:
##### Encapsulated code is easy to test for unit testing.
## Access Modifiers related to Encapsulation



| Modifier | Description     | 
| :-------- | :------- | 
| `public` | `The code is accessible for all classes` | 
| `private` | `The code is only accessible within the same class` | 
| `protected` | `The code is accessible within the same class, or in a class that is inherited from that class.` | 
| `internal` | `The code is only accessible within its own assembly, but not from another assembly.` | 


#### Notes: 
1. ##### There's also two combinations: protected internal and private protected.


## Why Access Modifiers?


1. #### Control The Visibility:  
##### To control the visibility of class members (the security level of each individual class and class member).




2. #### To achieve "Encapsulation:  
#####  which is the process of making sure that "sensitive" data is hidden from users. This is done by declaring fields as private.


3. #### Note:  
#####  By default, all members of a class are private if you don't specify an access modifier:




