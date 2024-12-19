using StoreManagement.Domain.Entities;

namespace StoreManagement.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user); 
}
