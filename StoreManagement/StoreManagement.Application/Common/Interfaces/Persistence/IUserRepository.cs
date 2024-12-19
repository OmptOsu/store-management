using StoreManagement.Domain.Entities;

namespace StoreManagement.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);

    void Add(User user);
}
