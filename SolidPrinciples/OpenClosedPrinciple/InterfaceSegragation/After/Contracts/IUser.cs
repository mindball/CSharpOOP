namespace InterfaceSegragation.After
{
    public interface IUser
    {
        string Email { get; }

        string PasswordHash { get; }
    }
}
