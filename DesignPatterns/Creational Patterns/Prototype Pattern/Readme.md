# Prototype

## Factory for cloning new instances from a prototype
```	
Create new objects by copying this prototype
Instead if using the "new" keyword
```

## Options of cloning

### Clone Manually
```
Tedious, but high level of control.
```

### Clone with MemberwiseClone
```
Only creates a shallow copy, i.e. for reference-type fields the original object 
and its clone refer to the same object.
```

### Clone with Reflection
```
Shallow copy by default, can be re-written to do deep copy. Advantage: automated.
Disadvantage: reflection is slow.
It performs recursive bypass of the code, can double the program memory
```
### Clone with Serialization
```
Easy, automated. Give up some control and serialization is slowest of all.	
```
### Clone with IL, Clone with Extension Methods
```
More advanced solutions, not as common.	
```

## Types of cloning
![Image of Yaktocat](http://www.csharp411.com/wp-content/uploads/2008/05/objectclone.jpg)
## Deep cloning 
```
A deep clone copies the referenced objects as well.
```

## Shallow cloning
```
A shallow clone copies the references but not the referenced objects
```

## ICloneable (interface acts as Prototype)
```
	It is hard to use this interface correctly.The main issue is the question
	of shallow and deep copies. ICloneable does not define which kind
	of cloning is done.
```


