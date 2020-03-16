# Memento pattern
```
For non-programmers, a “memento” is something that helps you remember the past.

In programming, the Memento Design Pattern lets you save an object’s values, 
at a specific time, so you can recall them later. The “memento” is sometimes 
also called a “snapshot” – a picture of an object’s property values, at a certain time.
```

![Memento pattern](https://reactiveprogramming.io/public/books/patterns/img/patterns-articles/memento-diagram.png)
## Why you’d want to use it
```
The most common use for this pattern is when you want the user to be able 
to edit an object’s value, but give them the option to “undo” their changes – 
and revert to the original values.

This is also used in state machines – when an object goes through several 
state changes.  When you use it this way, you could save a list of memento 
objects – one for each state change. Then, you can look at the history of the 
object, and (if needed) revert back several levels. For this situation, 
think of a shipment that goes from Ordered, to Packing, to Ready for Shipment, 
to Shipped, to Delivered
```