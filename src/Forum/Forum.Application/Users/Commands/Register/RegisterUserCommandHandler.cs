using Keycloak.AuthServices.Sdk;
using Keycloak.AuthServices.Sdk.Admin;
using Keycloak.AuthServices.Sdk.Admin.Models;
using MediatR;
using Microsoft.Extensions.Options;

namespace Forum.Application.Users.Commands.Register;
public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand>
{
    private readonly IKeycloakUserClient _keycloakUserClient;
    private readonly KeycloakAdminClientOptions _adminClientOptions;

    public RegisterUserCommandHandler(
        IKeycloakUserClient keycloakUserClient,
        IOptions<KeycloakAdminClientOptions> adminClientOptions)
    {
        _keycloakUserClient = keycloakUserClient;
        _adminClientOptions = adminClientOptions.Value;
    }

    public async Task Handle(RegisterUserCommand command, CancellationToken cancellationToken)
    {
        var userRepresentation = new UserRepresentation
        {
            Username = command.Name,
            Email = command.Email,
            FirstName = command.Name,
            LastName = command.Name,
            Credentials = [new CredentialRepresentation {
                Value = command.Password,
            }],
            Enabled = true,
        };


        var response = await _keycloakUserClient.CreateUserWithResponseAsync(_adminClientOptions.Realm, userRepresentation, cancellationToken);

        if (response?.IsSuccessStatusCode != true)
        {
            throw new ArgumentException();
        }
    }
}
