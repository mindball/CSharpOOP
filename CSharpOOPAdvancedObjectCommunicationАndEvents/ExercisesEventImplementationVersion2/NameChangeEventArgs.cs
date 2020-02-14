using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesEventImplementationVersion2
{
    public class NameChangeEventArgs : EventArgs
    {
        public NameChangeEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
