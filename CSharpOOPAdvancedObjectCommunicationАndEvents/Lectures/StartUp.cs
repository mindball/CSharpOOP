namespace Lectures
{
    using System;
    using Lectures.ObserverDesignPattern;
    class StartUp
    {
        public delegate void WorkPerformedHandler(int hours, WorkType type);
        public delegate void FunctionInFunction(string str);

        static void Main(string[] args)
        {

            //Разлика между delegate, Func<T>, Action<T>
            // Action is a delegate (pointer) to a method, that takes zero, 
            //      one or more input parameters, but does not return anything.
            // Func is a delegate (pointer) to a method, that takes zero,
            //      one or more input parameters, and returns a value(or reference).
            // Predicate is a special kind of Func often used for comparisons.
            // By default the access to the events is synchronized (thread-safe) това означава че докато,
            //  едната ф-я не приключи другата не се вкл. 
            //Types of declaration on delegate
            //Type 1
            WorkPerformedHandler dele = new WorkPerformedHandler(WorkPerformed);

            //Type2
            WorkPerformedHandler dele2 = WorkPerformed;

            //Type3
            //Anonymous method
            WorkPerformedHandler dele3 = delegate (int hours, WorkType type)
            {
                System.Console.WriteLine("WorkPerformed for " + hours + " hours");
                System.Console.WriteLine("On: " + type);
            };

            //Type4 - lamba expression
            WorkPerformedHandler dele4 = (hours, type) =>
            {
                Console.WriteLine("WorkPerformed for " + hours + " hours");
                Console.WriteLine("On: " + type);
            };

            dele(5, WorkType.Meetings);
            dele2(1, WorkType.Exam);
            dele3(5, WorkType.Sport);
            dele4(5, WorkType.Meetings);

            Console.WriteLine();

            //Invocation list
            WorkPerformedHandler dele5 = (hours, type) =>
            {
                Console.WriteLine("On: " + type);
            };

            dele += dele5;
            dele(10, WorkType.Exam);
            //or dele = + dele2 + dele3 and so on..
            //Always run sequentially

            //Example
            DelegateExample example = new DelegateExample();
            string str = "test test test";
            DelegateExample.UppercaseDelegate newFunction = (stra) =>
            {
                stra.ToUpper();
                return stra;
            };

            Console.WriteLine(newFunction("bebebebebebebebe"));

            example.WriteOutput(str, new DelegateExample.UppercaseDelegate(example.UppercaseFirst));
            example.WriteOutput(str, new DelegateExample.UppercaseDelegate(example.UppercaseLast));
            example.WriteOutput(str, new DelegateExample.UppercaseDelegate(example.UppercaseAll));

            //Function in function(функция като параметър на друга ф-я)
            FunctionInFunctionMethod(DoSomethingInFunction, "FIF");

            //callbacks invocations
            Console.WriteLine();
            Console.WriteLine("//////////////////////  callbacks  ///////////////////////");
            CallBack test = new CallBack();
            test.DoWord(5, x => Console.WriteLine(x + 5));
            test.DoWord(5, x => Console.WriteLine(x + 100));

            int result = 0;
            test.DoWord(5, x =>
            {
                result = x + 200;
            });
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine("//////////////////////  Events  ///////////////////////");


            //Events
            EventExample eventExample = new EventExample(7, WorkType.Sport);

            //OnPropertyChange - доста използвано!
            Console.WriteLine();
            Console.WriteLine("//////////////////////  OnPropertyChange  ///////////////////////");
            var person = new Person()
            {
                FirstName = "pesho",
                LastName = "peshov"
            };

            person.OnPropertyChangeg += property =>
            {
                Console.WriteLine($"{property} has changeg");
            };

            //person.OnPropertyChangeg += property =>
            //{
            //    throw new ArgumentException("You cannont edit that");
            //};

            person.FirstName = "ChangeName";

            person.OnPropertyChangedWithInfo += (property, lastValue, newValue) =>
            {
                Console.WriteLine($"Person property changed. {property} changed withh '{lastValue}' with new name: {newValue}");
            };

            //Тук не става ясно кое каквое : какъв е първия аргумент (string), какъв е втория (object) и т.н.,
            //на клиента които се е закачил за този клас и чака събитие, не му е ясно, разбира се може да ги поясним.
            //но ако имамем повече от 10 аргумента така че не е удобен начин затова идват events!!!
            person.LastName = "NovoPoslednoIme";

            person.OnPropertyChangedWithEvents += (property, lastValue, newValue) =>
            {
                //human e obect от тип Person
                Console.WriteLine($"property changed. {property} changed withh '{lastValue}' with new name: {newValue}");
            };

            var personTwo = new Person()
            {
                StatusOne = "abra",
                StatusTwo = "kidabra"
            };

            personTwo.OnStatusesChangedWithEvents += (personObj, property, lastValue, newValue) =>
            {
                Console.WriteLine($"{personObj.GetType().Name} " +
                    $"{property} " +
                    $"{lastValue} " +
                    $"{newValue}");
            };

            personTwo.StatusOne = "boom";
            personTwo.StatusTwo = "waaon";

            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine("//////////////// Events with arguments ////////////////////");

            var personWithEventsArgs = new Person()
            {
                FirstNameEventWithArg = "nameOne",
                LastNameEventWithArg = "nameTwo"
            };

            personWithEventsArgs.OnPropertyChangedWithArgs = (personObj, personObjArgs) =>
            {
                Console.WriteLine($"{personObj.GetType().Name}");
                Console.WriteLine($"{personObjArgs.Property}");
                Console.WriteLine($"{personObjArgs.OldValue}");
                Console.WriteLine($"{personObjArgs.NewValue}");
            };

            personWithEventsArgs.FirstNameEventWithArg = "change nameOne";
            personWithEventsArgs.LastNameEventWithArg = "change nameTwo";

            //До сега не сме използвали event но всичко досега е pipeline (обяснението) какво точно
            //стои зад event-tite.

            //with Empty Args
            var personWithEventsWithoutArg = new Person()
            {
                FirstName = "Args1",
                LastName = "Args2"
            };

            personWithEventsWithoutArg.OnGreatingWithoutArgs += PersonWithEventsWithoutArgOnGreatingWithoutArgs;
            Console.WriteLine(personWithEventsWithoutArg.SayHello());

            //Observer design pattern.
            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine("//////////////// Observer design pattern ////////////////////");
            Person personObserver = new Person()
            {
                //тук инициализираме и може би не ни трябва notify но след като променим полето
                FirsNameWithObserverDesingPattern = "ObserverOne",
                LastNameWithObserverDesingPattern = "ObserverTwo"
            };

            personObserver.AddObserver(new ConsoleWriteLinePersonObserver());
            //може да създаваме и дрги оbserver-ри;

            personObserver.FirsNameWithObserverDesingPattern = "ObserverOneChanged";
            personObserver.LastNameWithObserverDesingPattern = "ObserverTwoChanged";




    }

        private static void PersonWithEventsWithoutArgOnGreatingWithoutArgs(object sender, EventArgs e)
        {
            //Доста често се използва този стил за зачистване на обект например: Имаме игра
            //шутер с много играчи ако случайно играча е убит вдигаме event (не ни трябват неговите аргументи)
            //и го зачистваме от gamepad-a (от полето на играта);
            var person = (Person)sender;            
            Console.WriteLine(person.GetType().Name);
        }

        public static void WorkPerformed(int hours, WorkType type)
        {
            System.Console.WriteLine("WorkPerformed for " + hours + " hours");
            System.Console.WriteLine("On: " + type);
        }

        public static void DoSomethingInFunction(string str)
        {
            Console.WriteLine(str);
        }

        public static void FunctionInFunctionMethod(FunctionInFunction fif,
            string str)
        {
            fif(str);
        }
    }
}

