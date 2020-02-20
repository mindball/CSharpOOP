# Object pool
```
Представлява набор от инициализирани и готови за употреба обекти. 
Когато приложната програма има нужда от даден обект, той се взима от запаса. 
Когато обектът вече не е нужен, той не се унищожава, а се връща обратно в запаса.
След като клиента поиска даден обект от Object pool и приложи някакви операции, 
връща го обратно на Object pool. Object pool може да го нулира както автоматично така и ръчно.
```

![Object pool](https://i1.wp.com/i.imgur.com/Bm0dEk3.png?resize=718%2C327&quality=100&ssl=1)

## When to use
### When it is necessary to work with a large number of objects
```
These objects are particularly expensive to instantiate and each object
is only needed for a short period of time, the performance of an entire
application may be adversely affected. An object pool design pattern may
be deemed desirable in cases such as these.
```
### When objects may be reused
```
The object pool design pattern creates a set of objects that may be 
reused. When a new object is needed, it is requested from the pool.
If a previously prepared object is available it is returned immediately,
avoiding the instantiation cost. If no objects are present in the pool,
a new item is created and returned. When the object has been used and is
no longer needed, it is returned to the pool, allowing it to be used again
in the future without repeating the computationally expensive instantiation process.
It is important to note that once an object has been used and returned,
existing references will become invalid.
```
### When there are several clients need the same resources at different times.
