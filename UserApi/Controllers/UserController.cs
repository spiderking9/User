using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Commands;
using UserAPI.Commands.Dto;
using UserAPI.Queries;
using UserDomain.AggregateModels;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _mediator.Send(new GetUsersQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewUser(AddUserDto user)
        {
            var result = await _mediator.Send(new AddUser(user));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserDto user)
        {
            var result = await _mediator.Send(new UpdateUser(user));
            return Ok(result);
        }
    }
}