using UserManagementApi.Models;

namespace UserManagementApi.Services;

public class InMemoryUserRepository : IUserRepository
{
    private readonly List<User> _users = new();

    public InMemoryUserRepository()
    {
        _users.Add(new User { Name = "Alice", Email = "alice@example.com", Age = 25 });
        _users.Add(new User { Name = "Bob", Email = "bob@example.com", Age = 31 });
    }

    public IEnumerable<User> GetAll() => _users;

    public User? GetById(Guid id) => _users.FirstOrDefault(u => u.Id == id);

    public User Create(User user)
    {
        user.Id = Guid.NewGuid();
        _users.Add(user);
        return user;
    }

    public bool Update(Guid id, User user)
    {
        var existing = GetById(id);
        if (existing is null) return false;

        existing.Name = user.Name;
        existing.Email = user.Email;
        existing.Age = user.Age;
        return true;
    }

    public bool Delete(Guid id)
    {
        var existing = GetById(id);
        if (existing is null) return false;

        _users.Remove(existing);
        return true;
    }
}
