using Keycloak.AuthServices.Sdk;
using Keycloak.AuthServices.Sdk.Admin;
using Keycloak.AuthServices.Sdk.Admin.Requests.Users;
using MediatR;
using Microsoft.Extensions.Options;

namespace Forum.Application.Users.Queries.ExistsByEmail;
public class UserExistsByEmailQueryHandler : IRequestHandler<UserExistsByEmailQuery, bool>
{
    private readonly IKeycloakUserClient _keycloakUserClient;
    private readonly KeycloakAdminClientOptions _adminClientOptions;

    public UserExistsByEmailQueryHandler(
        IKeycloakUserClient keycloakUserClient,
        IOptions<KeycloakAdminClientOptions> adminClientOptions)
    {
        _keycloakUserClient = keycloakUserClient;
        _adminClientOptions = adminClientOptions.Value;
    }

    public async Task<bool> Handle(UserExistsByEmailQuery request, CancellationToken cancellationToken)
    {
        var parameters = new GetUsersRequestParameters
        {
            Email = request.Email,
            Exact = true
        };

        var users = await _keycloakUserClient.GetUsersAsync(_adminClientOptions.Realm, parameters, cancellationToken);

        return users.Any();
    }
}
