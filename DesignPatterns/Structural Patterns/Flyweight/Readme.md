# Flyweight Design pattern
```
Flyweight is a structural design pattern and is used to reduce the number of objects 
created, to decrease memory and resource usage. As a result, it increases performance.
```
![Flyweight](https://www.researchgate.net/profile/Andres_Pablo_Flores/publication/277288211/figure/fig5/AS:669501678972943@1536633047663/Flyweight-Pattern-Structure-jects-to-have-ConcreteFlyweight-objects-as-children-at-some.png)
```
Flyweight pattern tries to reuse already existing similar kind objects by storing
them and creates a new object when no matching object is found.
```

### The flyweight pattern uses the concepts of intrinsic and extrinsic data.
![Flyweight](https://www.oreilly.com/library/view/learning-javascript-design/9781449334840/httpatomoreillycomsourceoreillyimages1547819.png)
*Intrinsic data*
```
Intrinsic data is held in the properties of the shared flyweight objects. 
This information is stateless and generally remains unchanged, if any change 
occurs it would be reflected among all of the objects that reference the flyweight.
```

*Extrinsic data*
```
is computed on the fly means at runtime and it is held outside of a flyweight
object. Hence it can be stateful.
```
## When to use it?
### Flyweight is used when there is a need to create a large number of objects of almost similar nature and storage cost is high.
### A few shared objects can replace many unshared ones.
### Most of the state can be kept on disk or calculated at runtime.