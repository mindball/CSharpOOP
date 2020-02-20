# Builder Pattern
```
Builder pattern builds a complex object by using a step by step approach. 
Builder interface defines the steps to build the final object. This builder
is independent of the objects creation process. A class that is known as Director,
controls the object creation process.
```
![Builder Pattern](https://www.codeproject.com/KB/recipes/1156619/Fig01-BuilderClasses.png)

## When to use it
```
This pattern can be used where we need to do a lot of work to build similar kind of complex
 objects in step by step fashion. In another way we can say that this pattern is useful 
 where we need to create a complex object by assembling small objects (which are parts of
 a complex object) using a certain procedure or algorith
```
### Class with a large number of parameters in its constructors.
### Class has several different constructors, most of them with many parameters.
### The class does not have complex constructors, but has many properties that need to be set, before you can use some of its functions

## Disadvantages
```
It does create more code (and could introduce more complexity) in the DTO(data transfer object)
than if you hadfor example contructor arguments and/or setters/getters.
```