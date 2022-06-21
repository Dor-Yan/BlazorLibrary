using BlazorLibrary.Application.Users.Queries;
using BlazorLibrary.Shared.Users.Queries.AllUsersQuery;
using Microsoft.AspNetCore.Mvc;

namespace BlazorLibrary.Server.Controllers
{
    [Route("api/users")]
    public class UsersController : BaseController
    {
        [HttpGet]

        public async Task<ActionResult<List<UserForListVm>>> GetAsync()
        {
            var vm = await Mediator.Send(new AllUsersQuery());
            return vm;
        }
    }
}
