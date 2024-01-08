using UserDomain.AggregateModels;

namespace UserDomain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> AddAsync(User user, CancellationToken token = default);

        Task<User?> GetAsync(long id, CancellationToken token = default);

        Task<bool> SaveChangesAsync(CancellationToken token = default);

        Task<List<User>> GetUsersAsync(CancellationToken token = default);
    }
}