using Forum.Domain.Entities;

namespace Forum.Application.Common.Intrefaces;
public interface IUserProvider
{
    User? User { get; }
}
