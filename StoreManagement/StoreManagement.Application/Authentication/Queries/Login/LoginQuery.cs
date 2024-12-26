using ErrorOr;
using MediatR;
using StoreManagement.Application.Authentication.Common;

namespace StoreManagement.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email, 
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;