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
properties – HitPoints and AttackDamage.
```
The code might look like this: [before Inheritance](https://github.com/mindball/CSharpOOP/blob/master/DesignPatterns/Composition%20Over%20Inheritance/ScottLillyExample/Before%20Inheritance/Monster.cs)
```
Then, your boss tells you the game needs to have different types of monsters.
One type will attack by biting, the second by kicking, and the third by punching. 
So, you make the Monster class into a base class, and create three new 
sub-classes from it: BitingMonster, KickingMonster, and PunchingMonster.
```
Now, you have these classes:
[Monster.cs](https://github.com/mindball/CSharpOOP/blob/master/DesignPatterns/Composition%20Over%20Inheritance/ScottLillyExample/After%20Inheritance/Monster.cs)
[BitingMonster.cs](https://github.com/mindball/CSharpOOP/blob/master/DesignPatterns/Composition%20Over%20Inheritance/ScottLillyExample/After%20Inheritance/BitingMonster.cs)
[KickingMonster.cs](https://github.com/mindball/CSharpOOP/blob/master/DesignPatterns/Composition%20Over%20Inheritance/ScottLillyExample/After%20Inheritance/KickingMonster.cs)
```
The next day, your boss tells you they need new types of monsters in the game – 
ones that can do different combinations of biting, kicking, and punching. 
Because this is getting complex, you also build a Factory class, to create 
the different types of monster objects.
```
If you continue with making sub-classes, you could end up with this code: see After Inheritance!!!
* BitingKickingMonster.cs
* BitingKickingPunchingMonster.cs
* BitingPunchingMonster.cs
* KickingPunchingMonster.cs
```
Notice that we run into a problem when a new class needs to inherit from more 
than one base class. For example, the BitingKickingMonster inherits from BitingMonster,
and duplicates the KickDamage property – because it could not also inherit from 
KickingMonster.
```
```
If these classes were in a real program, and not a simple demonstration, there 
would probably be much more duplication of properties and functions.
```
```
There is another problem. If we try to determine the “type” of an object, to 
determine what attacks it can perform, we can only check against the single base 
class – not the second class.
```
[UnitTest](https://github.com/mindball/CSharpOOP/blob/master/DesignPatterns/Composition%20Over%20Inheritance/ScottLillyExample/TestMonsterFactory/UnitTest1.cs)
```
After you finish creating all these classes, your boss sends you an email. 
Now, you need to have monsters that can also attack by spitting.
Cobras will bite and spit, camels will kick and spit, etc.
Instead of creating more sub-classes, you decide to try using composition.
```
## Composition version

See: [Composition Before](https://github.com/mindball/CSharpOOP/tree/master/DesignPatterns/Composition%20Over%20Inheritance/ScottLillyExample/Composition_Before)

```
With this Monster class, when we create a new Monster object, we “compose” its 
Attack options by calling the AddAttackType() function – with the AttackType, and 
the amount of damage the monster does with this attack.

I added a few more properties (CanBite, CanKick, and CanPunch), to make it easy 
to know what types of attacks a monster can perform.

This one class also has all the Damage properties in it (BiteDamage, KickDamage, and PunchDamage).
```
**With these six properties, we can compose the Monster object to attack however 
we want – which we do in the MonsterFactory class below.**

### Where I’ve found it useful
```
There are two common situations when you would want to consider using composition, instead of inheritance: when you need to do multiple inheritance, and when your sub-classes start to have their own sub-classes.
```

**You might also combine object composition with the Strategy Design Pattern. 
Instead of composing the object with property values (the attack type and damage), 
you could also compose it by configuring how it will perform its actions.**