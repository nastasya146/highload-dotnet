using Highload.SocialNetwork.Domain;

namespace Highload.SocialNetwork.Contracts;

public interface IUserRepository
{
    Task AddUser(User user, string password, CancellationToken cancellationToken);
    
    Task<User> GetUser(Guid userId, CancellationToken cancellationToken);
    
    Task<string> GetPassword(Guid userId, CancellationToken cancellationToken);
}