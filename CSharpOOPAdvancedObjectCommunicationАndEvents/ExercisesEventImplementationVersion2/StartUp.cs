namespace ExercisesEventImplementationVersion2
{
    using ExercisesEventImplementationVersion2.Contracts;
    using System;

    class StartUp
    {
         
        static void Main(string[] args)
        {

            string inputName = Console.ReadLine();
            INameChangeable dispatcher = new Dispatcher(null);
            INameChangeHandler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatherNameChange;

            while (!inputName.Equals("End"))
            {
                dispatcher.Name = inputName;
                inputName = Console.ReadLine();
            }
        }
    }
}
