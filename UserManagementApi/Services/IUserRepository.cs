using UserManagementApi.Models;

namespace UserManagementApi.Services;

public interface IUserRepository
{
    IEnumerable<User> GetAll();
    User? GetById(Guid id);
    User Create(User user);
    bool Update(Guid id, User user);
    bool Delete(Guid id);
}
