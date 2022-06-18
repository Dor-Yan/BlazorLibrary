using BlazorLibrary.Application.Common.Interfaces;
using BlazorLibrary.Domain.Enities;
using BlazorLibrary.Shared.Books.Queries.AllBooksQuery;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Application.Books.Queries
{
    public class AllBooksQuery : IRequest<List<BookForListVm>>
    {
    }

    public class AllBooksQueryHandler : IRequestHandler<AllBooksQuery, List<BookForListVm>>
    {
        public readonly IBlazorLibraryDbContext _context;

        public AllBooksQueryHandler(IBlazorLibraryDbContext context)
        {
            _context = context;
        }
        public async Task<List<BookForListVm>> Handle(AllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _context.Books.ToListAsync();
            return MapBooksToVm(books);
        }

        private List<BookForListVm> MapBooksToVm(List<Book> books)
        {
            var result = new List<BookForListVm>();
            foreach (var book in books)
            {
                var bookVm = new BookForListVm()
                {
                 Title = book.Title,
                 Description = book.Description,
                 Publisher = book.Publisher,
                 NumberOfPages = book.NumberOfPages,
                 ISBN = book.ISBN,
                 Available = book.Available,
                 Id = book.Id,
                };
                result.Add(bookVm);
            }
            return result;
        }
    }
}
