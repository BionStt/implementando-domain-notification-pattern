using DomainNotificationHelperSample.Domain.Entities;
using DomainNotificationHelperSample.Domain.Repositories;
using DomainNotificationSample.Data.Context;

namespace DomainNotificationSample.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DnDataContext _context;

        public UserRepository(DnDataContext context)
        {
            _context = context;
        }
        public void Save(User user)
        {
            _context.Users.Add(user);
        }
    }
}
