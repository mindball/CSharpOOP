# Unit Tests

## AAA Testing Pattern

### Arrange
```
The Arrange section of a unit test initializes objects and sets the
value of the data that is passed to the test case
```
### Act
```
The Act section invokes the test case with the arranged parameters
```
### Assert
```
The Assert section verifies the test case behaves as expected
```
## Good Practice

### Method name
	* Should use business domain terminology
	* Should use descriptive and readable
	
```
	Именоването на методите да са описателни, независмо от дължината им
```
```
Example:
	Ако тестваме банкови операции:
	DepositAAddMoneyToBalance() {}
	DepositNegativeShouldNotAddMoney() {}
```

### Asserts
```
	- Може да си добавяме Custom message към asserts и трябва да е описателно, за да може
		да ни улеснява в диагностирането на проблема.
	- В тест метода е добре да има само един assert!	
```

### Condition
```
	Assert.That(bool condition);
```
### Comparison
```
	Assert.That(actual, Is.EqualTo(expected));
```
### Exception
```
	Assert.That(() => { code }, Throws.ExpectedException)
```
### String Assert
```
	Assert.That(string actual,
		Does.Contain(string expected));
```
### Collection Assert
```
	Assert.That(IEnumerable expected,
		Has.Member(object actual));
```

### Don't repeat yourself
	* SetUp
	* TearDown

### One UnitTest, test one thing

### Summary
```
	Избирайте, по описателните методи от тестинг framework-a, тоест
	тези, които връщат по детайлни данни, когато теста не приминава.
```
```
	Аргументи в методите не може да има, само когато изолзваме 'Testcase' атрибута
```
```
	UnitTest ме предпвазва от refactoring-нето, след като вече сме написали тестовете.
```
```
	Тестването се използва, най много след рефакториране на кода, тоест когато развиваме кода, да правим
	промени по кога, когато fix-ваме бъгове. Точно тук UnitTesting ни спасява тук да не счупим работещ код.	
```	
```
	Тестването еволюра, заедно с кода. Тестовете изостават и не могат да хващат проблемите. Добра практика, отново
	да се преразгледа Рисковия сценарий. Не само девелоперите трябва да си оправят кода, но и QA трябва да си преразгледа
	тестовете.
```	