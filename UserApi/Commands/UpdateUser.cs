using MediatR;
using UserAPI.Commands.Dto;
using UserDomain.Repositories;

namespace UserAPI.Commands
{
    public class UpdateUser : IRequest<bool>
    {
        public UpdateUser(UserDto user)
        {
            User = user;
        }

        public UserDto User { get; set; }
    }

    public class UpdateUserHandler : IRequestHandler<UpdateUser, bool>
    {
        private readonly IUserRepository _userRep;

        public UpdateUserHandler(IUserRepository userRep)
        {
            _userRep = userRep;
        }

        public async Task<bool> Handle(UpdateUser request, CancellationToken cancellationToken)
        {
            var user = await _userRep.GetAsync(request.User.Id, cancellationToken);
            if (user == null) return false;

            user.Update(request.User.Name, request.User.Email, request.User.Phone);

            return await _userRep.SaveChangesAsync(cancellationToken);
        }
    }
}