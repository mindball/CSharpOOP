# Adapter pattern
```
The Adapter design pattern attempts to reconcile the differences 
between two otherwise-incompatible interfaces.

This pattern is especially useful when attempting to adapt to an 
interface which cannot be refactored (e.g. when the interface is 
controlled by a web service or API).
```
![Adapter pattern](https://media.geeksforgeeks.org/wp-content/uploads/classDiagram.jpg)


## Summary
```
The pattern is extremely useful when you're trying to adapt old or legacy systems
to new designs, so if you're ever in that situation the Adapter pattern might 
be the best fit for your project
```
```
We should use the Adapter class whenever we want to work with the existing class 
but its interface is not compatible with the rest of our code. Basically, the 
Adapter pattern is a middle-layer which serves as a translator between the code 
implemented in our project and some third party class or any other class with a 
different interface.
```
```
Furthermore, we should use the Adapter when we want to reuse existing classes 
from our project but they lack a common functionality. By using the Adapter pattern
in this case, we don’t need to extend each class separately and create a redundant code.
```