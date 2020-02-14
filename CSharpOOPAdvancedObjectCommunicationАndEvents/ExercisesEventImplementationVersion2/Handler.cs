namespace ExercisesEventImplementationVersion2
{
    using System;
    using Contracts;
    class Handler : INameChangeHandler
    {
        public void OnDispatherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"{sender.GetType().Name}'s name changed to {args.Name}");
        }
    }
}
