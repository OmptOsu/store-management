using Mapster;
using StoreManagement.Application.Authentication.Commands.Register;
using StoreManagement.Application.Authentication.Common;
using StoreManagement.Application.Authentication.Queries.Login;
using StoreManagement.Contracts.Authentication;

namespace StoreManagement.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}
