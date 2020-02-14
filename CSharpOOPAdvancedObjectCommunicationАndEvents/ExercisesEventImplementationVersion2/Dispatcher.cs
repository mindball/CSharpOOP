
namespace ExercisesEventImplementationVersion2
{
    using System;
    using ExercisesEventImplementationVersion2.Contracts;
    
    public class Dispatcher : INameChangeable
    {
        public event NameChangeEventHandler NameChange;

        private string name;
        public Dispatcher(string name)
        {
            this.name = name;
            //ако извикаме this.Name = name -> ще трябва да минем през set-търа a това не е поведението, което чакаме
            //все още нямаме null защити и т.н.
        }
        public string Name
        {
            get => this.name;
            set
            {
                this.OnNameChange(new NameChangeEventArgs(value));
                this.name = value;
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }
    }
}
