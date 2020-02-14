# Exception and Error handling

##	Good practice
	* For security reason do not show exceptions:
		Показваме информация, която не трябва да се вижда. (нашия код, strack-trace, заявки и т.н.). Това е вътрешна 
		информация, с която може да се компрометира нашата програма, сайт.
	* При публичните методи добра практика е да има exception handling,	докато при private ние имаме
		контрол какво ще се случва вътре.
	* Ако можем да финализирам дадената работа, задача или да върнем някаква стойност с даденият метод го правим - не можем ли
		хвърляме exception.(никога да не връщаме междинна или частична стойност!!!).
	* Правилото за йерархична структура на exception-ните е винаги първо да е най-конкретния exception
		и ако не можем да обработим конкретния, поставяме по-общ и т.н. до последния, които трябва да е базовия Exception
	* Глобалния Exception да се избягват (но всяко правило си има изкл.)
	* Use finally when releasing resources (outside resource)
	* В try-catch блока вкарваме кода, който искаме да проверяваме да контролираме например неща, които не зависят от нас:
		- работа с файлове и различни други външи ресурси.		
	* ArgumentException - добре е да показваме името на аргумент, който е предизвикал грешките (nameof(argument))
	* Each catch block should handle only these exceptions which itexpects
		 - If a method is not competent to handle an exception, it should leave it unhandled
		 - Handling all exceptions disregarding their type is a popular bad practice (anti-pattern)!
	* When raising an exception, always pass to the constructor a GOOD EXPLANATION MESSAGE
	* Exception can decrease the application performance
	* Не ги използвайте когато:
		- да контролирате поведението на програмата
		- да връща информация
	* In custom exceptions, provide additional properties as needed (For example, the FileNotFoundException provides the FileName property.)
		 

## Handle common conditions without throwing exceptions:
### Example
```
	bool IsValid(DateTime datetime)
	{
		//ако не e валидна датата не хвърляме exception
		if(datetime is null)
		{
				throw new ArgumentNullException();			 
		}

		if (datetime is wrong)
			return false;

		return true;
	}
```
```	
 If you try to close a connection that is already closed, you'll get an InvalidOperationException.
 You can avoid that by using an if statement to check the connection state before trying to close it.

	if (conn.State != ConnectionState.Closed)
	{
		conn.Close();
	}

If you don't check connection state before closing, you can catch the InvalidOperationException exception.
	try
	{
	    conn.Close();
	}
	catch (InvalidOperationException ex)
	{
	    Console.WriteLine(ex.GetType().FullName);
	    Console.WriteLine(ex.Message);
	}

```

##	Types of Exceptions
### System.ArgumentException:
```
	//Добър пример за проверка за грешка
	public string GeenerateEgn(DateTime dateOfBird, bool isMale, string placeOfbirth)
	{
		if(dateOfBird < 1900)
		{
			throw new ArgumentOutOfRangeException(nameof(dateOfBird), "Cannot generate EGN before 1900");
		}

		if(placeOfbirth is null)
		{
			throw new ArgumentNullException();
		}

		if(placeOfbirth is not in database)
		{
			throw new ArgumentException("place of birth not valid", nameof(placeOfBierd))
		}
		return "";
	}
```

### NotSupportedException

### NotImplementedException
```
 Възникват ако не сме спазили Open/Closed или Interface segregation принципа.
 Не би трябвало да има такива exception-ни в кода ни.
```
##	Exception Stack
```
	throw vs "throw ex" - занулаване на стека(скриване на излишната информация)
	inner exception - може да съдържа допълнителни данни, също и да не губиш информация от зануляването на stack

```