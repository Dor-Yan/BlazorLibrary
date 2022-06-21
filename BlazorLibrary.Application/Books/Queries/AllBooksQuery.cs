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
            var books = await _context.Books.Include(b=>b.Type).Include(w=>w.Writer).ToListAsync();
            return MapBooksToVm(books);
        }


        private List<BookForListVm> MapBooksToVm(List<Book> books)
        {
            var result = new List<BookForListVm>();
            
            foreach (var book in books)
            {
                var bookVm = new BookForListVm()
               
                {
                    Id = book.Id,
                    Title = book.Title,
                 Description = book.Description,
                 Publisher = book.Publisher,
                 NumberOfPages = book.NumberOfPages,
                 ISBN = book.ISBN,
                 Available = book.Available,
                 StatusId = book.StatusId,
                 Picture = book.Picture,
                 CreateDate = book.Created,
                BookType = book.Type.Name,
                WriterName = book.Writer.Name,
                };
                result.Add(bookVm);
            }
            return result;
            
        }
    }
}
