# Builder Pattern
```
Builder pattern builds a complex object by using a step by step approach. 
Builder interface defines the steps to build the final object. This builder
 is independent of the objects creation process. A class that is known as Director,
 controls the object creation process.
```
![Builder Pattern](https://www.codeproject.com/KB/recipes/1156619/Fig01-BuilderClasses.png)

## When to use it
### Class with a large number of parameters in its constructors.
### Class has several different constructors, most of them with many parameters.
### the class does not have complex constructors, but has many properties that need to be set, before you can use some of its functions