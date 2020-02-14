namespace ExplicitInterfaces.Contracts
{
    public interface IPerson
    {
        string Name { get; }

        string Country { get; }

        int Age { get; }     

        string GetName();
    }
}
