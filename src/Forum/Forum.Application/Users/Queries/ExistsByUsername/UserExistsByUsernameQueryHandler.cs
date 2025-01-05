using Keycloak.AuthServices.Sdk;
using Keycloak.AuthServices.Sdk.Admin;
using Keycloak.AuthServices.Sdk.Admin.Requests.Users;
using MediatR;
using Microsoft.Extensions.Options;

namespace Forum.Application.Users.Queries.ExistsByUsername;
public class UserExistsByUsernameQueryHandler : IRequestHandler<UserExistsByUsernameQuery, bool>
{
    private readonly IKeycloakUserClient _keycloakUserClient;
    private readonly KeycloakAdminClientOptions _adminClientOptions;

    public UserExistsByUsernameQueryHandler(
        IKeycloakUserClient keycloakUserClient,
        IOptions<KeycloakAdminClientOptions> adminClientOptions)
    {
        _keycloakUserClient = keycloakUserClient;
        _adminClientOptions = adminClientOptions.Value;
    }

    public async Task<bool> Handle(UserExistsByUsernameQuery request, CancellationToken cancellationToken)
    {
        var parameters = new GetUsersRequestParameters
        {
            Username = request.Username,
            Exact = true
        };

        var users = await _keycloakUserClient.GetUsersAsync(_adminClientOptions.Realm, parameters, cancellationToken);

        return users.Any();
    }
}
