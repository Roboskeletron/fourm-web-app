namespace Forum.Application.Common.Exceptions;
public class NotFoundException : Exception
{
    public string EntityName { get; init; }

    public object Id { get; init; }

    public NotFoundException(string entityName, object id)
    {
        EntityName = entityName;
        Id = id;
    }
}
