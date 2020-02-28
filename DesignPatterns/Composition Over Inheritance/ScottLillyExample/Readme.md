# What is “prefer composition over inheritance”?
```
Sometimes, a project needs several classes that appear to be similar,
but have different behavior.In object-oriented programming, we will
often handle this with inheritance. We create a base class. Then, 
we create sub-classes that inherit from the base class, and have the
 properties and functions that are unique to the sub-class.
But, that can sometimes lead to messy code.
An alternative is to use “composition”, to have a single class that 
can be “composed” to handle the different behaviors.
```

## Why you would want to use it
```
If you were writing a game, you might have different types of monsters. 
The different types of monsters could be able to do different attacks – 
biting, kicking, or punching.
One way to build this would be to create a base Monster class, and create
sub-classes for BitingMonster, KickingMonster, and PunchingMonster – 
with each sub-class handling the details for the different way of fighting.
But, what do you do if you have a new monster that needs to bite and kick?
Using inheritance, you might create a BitingKickingMonster. That could 
inherit from Monster, BitingMonster, or KickingMonster.
```

## Inheritance versions
```
Let’s pretend you work at a game programming company.
You’re building a new game, and you create a Monster class, with two
properties – HitPoints and AttackDamage. The code might look like this:
[before Inheritance](https://github.com/mindball/CSharpOOP/blob/master/DesignPatterns/Composition%20Over%20Inheritance/ScottLillyExample/Before%20Inheritance/Monster.cs)
```