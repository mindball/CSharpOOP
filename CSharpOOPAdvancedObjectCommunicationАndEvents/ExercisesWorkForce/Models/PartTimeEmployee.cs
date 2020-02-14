namespace ExercisesWorkForce.Models
{
    class PartTimeEmployee : Employee
    {
        private const int MaxHoursPerWeek = 20;

        public PartTimeEmployee(string name)
            : base(name, MaxHoursPerWeek) { }



    }
}
