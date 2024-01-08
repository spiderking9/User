using MediatR;
using UserAPI.Commands.Dto;
using UserDomain.AggregateModels;
using UserDomain.Repositories;

namespace UserAPI.Commands
{
    public class AddUser : IRequest<bool>
    {
        public AddUser(AddUserDto user)
        {
            User = user;
        }

        public AddUserDto User { get; set; }
    }

    public class AddUserHandler : IRequestHandler<AddUser, bool>
    {
        private readonly IUserRepository _userRep;

        public AddUserHandler(IUserRepository userRep)
        {
            _userRep = userRep;
        }

        public Task<bool> Handle(AddUser request, CancellationToken cancellationToken)
        {
            var user = request.User;
            return _userRep.AddAsync(new User(user.Name,user.Email, user.Phone), cancellationToken);
        }
    }
}