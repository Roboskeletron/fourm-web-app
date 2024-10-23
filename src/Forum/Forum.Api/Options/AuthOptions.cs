namespace Forum.Api.Options;
public record AuthOptions
{
    public const string SectionName = "Auth";

    public required string Authority { get; init; }

    public required string Audience { get; init; }

    public bool EnableUnsafeAuth { get; init; } = false;

    public bool ValidateLifetime { get; init; } = true;
}
