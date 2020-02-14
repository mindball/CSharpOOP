using System;
using System.Collections.Generic;
using System.Text;

namespace Lectures
{
    using Lectures.ObserverDesignPattern;
    class Person
    {
        private string firstName;
        private string lastName;
        private string statusOne;
        private string statusTwo;
        private string firstNameEventWitArg;
        private string lastNameEventWitArg;
        private string firstNameEventByCSharpStandart;
        private string lastNameEventByCSharpStandart;

        //Observer design pattern
        private string lastNameWithObserverDesingPattern;
        private string firsNameWithObserverDesingPattern;
        private ICollection<IPersonObserver> observers =
            new List<IPersonObserver>();

        //public subscribe        
        public Action<string> OnPropertyChangeg;
        //Тук не става ясно кое каквое : какъв е първия аргумент (string), какъв е втория (object) и т.н.,
        //на клиента които се е закачил за този клас и чака събитие, не му е ясно, разбира се може да ги поясним с:
        /// <summary>
        ///         string e полето което ще променяме, object е старата стойност, object e новата
        ///         
        /// </summary>
        public Action<string, object, object> OnPropertyChangedWithInfo;

        //по прилежно написано като пропърти:
        public Action<string, object, object> OnPropertyChangedWithEvents { get; set; }

        public Action<object, string, object, object> OnStatusesChangedWithEvents { get; set; }

        public Action<object, PersonPropertyEventData> OnPropertyChangedWithArgs { get; set; }

        //event - както трябва да се спазват конвенцията (но може и ние да си пишем)
        public event EventHandler<PersonPropertyEventArgs> OnPropertyChangedByStandart;

        //Empty Args
        //Доста често се използва този стил за зачистване на обект например: Имаме игра
            //шутер с много играчи ако случайно играча е убит вдигаме event (не ни трябват неговите аргументи)
            //и го зачистваме от gamepad-a (от полето на играта);
        public event EventHandler OnGreatingWithoutArgs;

        public string FirstName
        {
            get => this.firstName;
            set
            {
                OnPropertyChangedWithInfo?.Invoke(nameof(FirstName), this.firstName, value);
                this.firstName = value;
                OnPropertyChangeg?.Invoke(nameof(firstName));
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                //null check ?
                OnPropertyChangedWithInfo?.Invoke(nameof(LastName), this.lastName, value);
                this.lastName = value;
            }
        }

        public string StatusOne
        {
            get => this.statusOne;
            set
            {
                this.OnStatusesChangedWithEvents?.Invoke(this, nameof(StatusOne), this.statusOne, value);
                this.statusOne = value;
            }
        }

        public string StatusTwo
        {
            get => this.statusTwo;
            set
            {
                this.OnStatusesChangedWithEvents?.Invoke(this, nameof(StatusTwo), this.statusTwo, value);
                this.statusTwo = value;
            }
        }

        public string FirstNameEventWithArg
        {
            get => this.firstNameEventWitArg;
            set
            {
                this.OnPropertyChangedWithArgs?.Invoke(this, new PersonPropertyEventData()
                {
                    Property = nameof(FirstNameEventWithArg),
                    OldValue = FirstNameEventWithArg,
                    NewValue = value
                });
                this.firstNameEventWitArg = value;
            }
        }
        public string LastNameEventWithArg
        {
            get => this.lastNameEventWitArg;
            set
            {
                this.OnPropertyChangedWithArgs?.Invoke(this, new PersonPropertyEventData()
                {
                    Property = nameof(LastNameEventWithArg),
                    OldValue = LastNameEventWithArg,
                    NewValue = value
                });
                this.lastNameEventWitArg = value;
            }
        }

        private string FirstNameEventByCSharpStandart
        {
            get => this.firstNameEventByCSharpStandart;
            set
            {
                this.OnPropertyChangedByStandart?.Invoke(this, new PersonPropertyEventArgs()
                {
                    Property = nameof(FirstNameEventByCSharpStandart),
                    OldValue = this.firstNameEventByCSharpStandart,
                    NewValue = value
                });
                this.firstNameEventByCSharpStandart = value;
            }
        }

        public string LastnameEventByCSharpStandart
        {
            get => this.lastNameEventByCSharpStandart;
            set
            {
                this.OnPropertyChangedByStandart?.Invoke(this, new PersonPropertyEventArgs()
                {
                    Property = nameof(FirstNameEventWithArg),
                    OldValue = FirstNameEventWithArg,
                    NewValue = value
                });

                this.lastNameEventByCSharpStandart = value;
            }
        }

        //Observer Design Pattern

        public string FirsNameWithObserverDesingPattern
        {
            get => this.firsNameWithObserverDesingPattern;
            set
            {
                this.NotifyObserver(nameof(FirsNameWithObserverDesingPattern));
                this.firsNameWithObserverDesingPattern = value;
            }
        }
        public string LastNameWithObserverDesingPattern
        {
            get => this.lastNameWithObserverDesingPattern;
            set
            {
                this.NotifyObserver(nameof(LastNameWithObserverDesingPattern));
                this.lastNameWithObserverDesingPattern = value;
            }
        }

        public string SayHello()
        {
            this.OnGreatingWithoutArgs?.Invoke(this, EventArgs.Empty);
            return $"{this.FirstName} {this.LastName}";
        }

        //Observer design pattern
        public void AddObserver(IPersonObserver observer)
        {
            this.observers.Add(observer);
        }

        //Observer design pattern
        private void NotifyObserver(string property)
        {
            foreach (var observer in this.observers)
            {
                observer.Handle(property);
            }
        }
    }
}
