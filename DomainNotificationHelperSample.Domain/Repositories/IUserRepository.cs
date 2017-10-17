using DomainNotificationHelperSample.Domain.Entities;

namespace DomainNotificationHelperSample.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
    }
}
