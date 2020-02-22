# Lazy initialization pattern
```
Целта на късната инициализация е да се отложи във времето създаването на обект, 
изчисляването на стойност или на някакъв друг отнемащ ресурси процес, до момента
 в който не ни е нужен за първи път. 

```

### Good example
```
Is to not create a database connection up front, but only just before you need 
to get data from the database.The key reason for doing this is that (often) you
can avoid creating the object completely if you never need it.
```

```
The advantages from an application perspective of lazy initialization are that 
users don't have to pay the initialization time for features they will not use.
Suppose you were to initialize every component of your application up front. 
This could create a potentially long start time - users would have to wait dozens
of seconds or minutes before your application is ready to use. They're waiting 
on and paying for initialization of features they may never use or not use right away.
```