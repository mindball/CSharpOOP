# Facade Pattern
![Facade Pattern UML](https://upload.wikimedia.org/wikipedia/en/5/57/Example_of_Facade_design_pattern_in_UML.png)
```
WIKI: facade is an object that serves as a front-facing interface masking
more complex underlying or structural code.
Wrap a complicated subsystem with a simpler interface.
```

## When to use:
### To make a complex subsystem easier to use
### The dependencies on a subsystem should be minimized.
### Use the Facade pattern when you need to have a limited but straightforward interface to a complex subsystem.
```
Often, subsystems get more complex over time. Even applying design patterns
typically leads to creating more classes. A subsystem may become more flexible
and easier to reuse in various contexts, but the amount of configuration and
boilerplate code it demands from a client grows ever larger. The Facade attempts
to fix this problem by providing a shortcut to the most-used features of the 
subsystem which fit most client requirements.
```
### Use the Facade when you want to structure a subsystem into layers.
```
Create facades to define entry points to each level of a subsystem. You can
reduce coupling between multiple subsystems by requiring them to communicate
only through facades.
```