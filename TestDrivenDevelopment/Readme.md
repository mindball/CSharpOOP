# Test Driven Development

## Why TDD?

### TDD helps find design issues early

```
 TDD ни дава възможност още в раннен етап да откриваме проблеми още преди да сме започнали да пишем по проекта.
 Например проблеми свързвани с класовете как си комуникираt. Затова е хубаво да се използват Design Patterns!
```

### Tests will be more comprehensive than if they are written after the code

```
	Когато пишем код, които да удовлетвори тест, това ни позволява да се концентрираме върху имплементацията на този етап
	знаейки че имаме тестове които да ни валидират тази имплментация. Ако използваме Code First ние вече сме обременени от написания
	код, нашия мозък си мисли за този код, знаем как е имплементиран, и след това пишем unit тестовете. Психическита нагласа е да 
	да имплементираме такива тестове, които да минават  успешно през нашият код и не се замисляме за възможните потенциални 
	грешки. Пишейки първо тестовете ние можем добре да си отговорим за страничните случай, интересните сценарии и т.н. без да сме
	зависими (обременени) от написания код.
```

## Moq - mocking

### Mock objects simulate behavior of real objects
```
	- The object supplies non-deterministic results - Time
	- It has states that are difficult to create or reproduce - Network
	- It is slow - Database
```

### Moq provides us with an easy way of creating mock objects
```
	Simple to use
	Strongly typed
	Minimalistic
```