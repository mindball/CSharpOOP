using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesEventImplementationVersion2.Contracts
{
    public interface INameChangeHandler
    {
        void OnDispatherNameChange(object sender, NameChangeEventArgs args);
    }
}
