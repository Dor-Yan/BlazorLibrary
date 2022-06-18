using BlazorLibrary.Application.Books.Queries;
using BlazorLibrary.Shared.Books.Queries.AllBooksQuery;
using Microsoft.AspNetCore.Mvc;

namespace BlazorLibrary.Server.Controllers
{
    [Route("api/books")]
    public class BooksController : BaseController
    {
      [HttpGet]

      public async Task<ActionResult<List<BookForListVm>>> GetAsync()
        {
            var vm = await Mediator.Send(new AllBooksQuery());
            return vm;
        }
    }
}
