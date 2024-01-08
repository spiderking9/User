using MediatR;
using UserDomain.AggregateModels;
using UserDomain.Repositories;

namespace UserAPI.Queries
{
    public class GetUsersQuery : IRequest<List<User>>
    {
    }

    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<User>>
    {
        private readonly IUserRepository _userRep;

        public GetUsersQueryHandler(IUserRepository userRep)
        {
            _userRep = userRep;
        }

        public Task<List<User>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
        {
            return _userRep.GetUsersAsync(cancellationToken);
        }
    }
}
