namespace ExercisesWorkForce.Models
{
    public class StandardEmployee : Employee
    {
        private const int MaxHoursPerWeek = 40;

        public StandardEmployee(string name)
            : base(name, MaxHoursPerWeek) { }



    }
}
