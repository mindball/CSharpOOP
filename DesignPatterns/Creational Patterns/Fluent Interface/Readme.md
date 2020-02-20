# Fluent interface
```
fluent interface is a method for designing object-oriented APIs that 
relies extensively on method chaining
```

## Implementation
```
A fluent interface is normally implemented by using method chaining to implement method cascading 
(in languages that do not natively support cascading), concretely by having each method return this (self).
Stated more abstractly, a fluent interface relays the instruction context of a subsequent call in
 method chaining, where generally the context is

* Defined through the return value of a called method
* Self-referential, where the new context is equivalent to the last context
* Terminated through the return of a void context

Note that a "fluent interface" means more than just method cascading via chaining; it 
entails designing an interface that reads like a DSL, using other techniques like 
"nested functions and object scoping"
```

## When to use
### During UNIT testing
### When you want your code to be readable