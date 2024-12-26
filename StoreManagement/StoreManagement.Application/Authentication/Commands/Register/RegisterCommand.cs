using ErrorOr;
using MediatR;
using StoreManagement.Application.Authentication.Common;

namespace StoreManagement.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
