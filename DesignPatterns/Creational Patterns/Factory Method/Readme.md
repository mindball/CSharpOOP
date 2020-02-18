# Factory Method Pattern
```
Define an interface for creating an object, but let subclasses decide which class
to instantiate. Factory Method lets a class defer instantiation to subclasses.
Factory Method lets a class defer instantiation to subclasses.
```

![Factory Method Pattern](https://dzone.com/storage/temp/11098148-factory-pattern-diagram.png)

## When to use a Factory Method
### A class can't anticipate which class objects it must create
### A class uses its subclasses to specify which objects it create
### You need to localize the knowledge of which class gets created

```
It is generally considered a bad idea for base classes to know implementation details
of their derived types. It is in situations like this is when you should use
the Abstract Factory pattern.
```
