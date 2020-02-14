using System.Collections.Generic;

namespace ExercisesWorkForce.Contracts
{
    public delegate void JobDoneHandlerEvent();
    public interface IJob
    {
        IReadOnlyCollection<IEmployee> Employees { get; }

        event JobDoneHandlerEvent JobDOne;
        string Name { get; }
        int JobDoneByHours { get; }

        void Status();

        void AddEmploye(IEmployee employee);

        void Update();
       
    }
}
