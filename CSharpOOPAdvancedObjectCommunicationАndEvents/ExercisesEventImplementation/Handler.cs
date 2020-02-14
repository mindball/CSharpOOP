using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesEventImplementation
{
    public class Handler
    {
       public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"{sender.GetType().Name}'s name changed to {args.Name}");
        }
    }
}
