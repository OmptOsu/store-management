namespace StoreManagement.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(Guid uderId, string firstName, string lastName); 
}
