using Microsoft.EntityFrameworkCore;
using UserDomain.AggregateModels;
using UserDomain.Repositories;

namespace UserData.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected UserContext _context;
        public DbSet<User> EntitySet => _context.Users;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(User user, CancellationToken token = default)
        {
            await EntitySet.AddAsync(user, token);

            return (await _context.SaveChangesAsync(token)) > 0;
        }

        public async Task<bool> SaveChangesAsync(CancellationToken token = default)
        {
            return (await _context.SaveChangesAsync(token)) > 0;
        }

        public Task<User?> GetAsync(long id, CancellationToken token = default)
        {
            return EntitySet.FirstOrDefaultAsync(u => u.Id == id, token);
        }

        public Task<List<User>> GetUsersAsync(CancellationToken token = default)
        {
            return EntitySet.ToListAsync(token);
        }
    }
}