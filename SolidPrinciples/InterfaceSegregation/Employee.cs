namespace InterfaceSegregation
{
    public class Employee : Worker, ISleeper
    {
        public Employee(string id) 
            : base(id)
        {

        }

        public override void Sleep()
        {
            //Sleep;
        }
    }
}
