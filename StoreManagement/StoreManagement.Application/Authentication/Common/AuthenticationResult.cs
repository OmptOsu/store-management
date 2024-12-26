using StoreManagement.Domain.Entities;

namespace StoreManagement.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);
