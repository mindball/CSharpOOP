using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesEventImplementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        private string name;

        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        private void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }

    }
}
