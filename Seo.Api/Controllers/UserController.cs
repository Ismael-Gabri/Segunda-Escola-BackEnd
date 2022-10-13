using Microsoft.AspNetCore.Mvc;
using Seo.Domain.Entities;
using Seo.Domain.WebContext.Commands;
using Seo.Domain.WebContext.Handlers;
using Seo.Domain.WebContext.Repos;

namespace Seo.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        [HttpGet("")]
        public User Create([FromRoute] Guid id, [FromServices] IUserRepository repo)
        {
            return repo.GetUserInformation(id);
        }

        [HttpPost("")]
        public GenericCommandResult Create([FromBody] CreateUserCommand command, [FromServices] UserHandler handler)
        {
            command.FirstName = "Ismael";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
