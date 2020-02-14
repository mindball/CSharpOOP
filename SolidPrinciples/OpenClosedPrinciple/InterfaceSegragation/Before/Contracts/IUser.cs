namespace InterfaceSegragation.Before
{
    public interface IUser
    {
        string Email { get; }

        string PasswordHash { get; }
    }
}
