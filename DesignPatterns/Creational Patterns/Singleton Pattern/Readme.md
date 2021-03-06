﻿# Singleton Pattern


## Introduction
```
	The singleton pattern is one of the best-known patterns in software engineering.
	Essentially, a singleton is a class which only allows a single instance of itself
	to be created, and usually gives simple access to that instance. Most commonly,
	singletons don't allow any parameters to be specified when creating the instance
	- as otherwise a second request for an instance but with a different parameter could
	be problematic! (If the same instance should be accessed for all requests with 
	the same parameter, the factory pattern is more appropriate.) This article deals only
	with the situation where no parameters are required. Typically a requirement of singletons
	is that they are created lazily - i.e. that the instance isn't created until it is first needed.
```

### There are various different ways of implementing the singleton pattern in C#. All these implementations share four common characteristics, however:
```
	* A single constructor, which is private and parameterless. 
		This prevents other classes from instantiating it (which would be a violation of the pattern).
		Note that it also prevents subclassing - if a singleton can be subclassed once, it can be
		subclassed twice, and if each of those subclasses can create an instance, the pattern is violated.
		The factory pattern can be used if you need a single instance of a base type, but the exact 
		type isn't known until runtime.
	* The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may
		help the JIT to optimise things more.
	* A static variable which holds a reference to the single created instance, if any.
	* A public static means of getting the reference to the single created instance, creating one if necessary.
```

## Authors

* **John Skeet** - *C# in Depth* - [Link](https://csharpindepth.com/)

