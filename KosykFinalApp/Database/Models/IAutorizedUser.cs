namespace KosykFinalApp.Database.Models
{
    public interface IAutorizedUser
    {
        int Id { get; }
        string Name { get; }
        string LastName { get;  }
        Role Role { get; }
    }
}
