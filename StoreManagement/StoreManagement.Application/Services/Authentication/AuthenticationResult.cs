using StoreManagement.Domain.Entities;

namespace StoreManagement.Application.Services.Authentication;

public record AuthenticationResult(
      User User,
      string Token
    );
