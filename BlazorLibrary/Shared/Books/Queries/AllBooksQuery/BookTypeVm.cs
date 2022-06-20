using BlazorLibrary.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Shared.Books.Queries.AllBooksQuery
{
    public class BookTypeVm
    {
        public int bookId { get; set; }
        public int typeId { get; set; }

        public BookTypeVm(BookType bookType)
        {
            bookId = bookType.BookId;
            typeId = bookType.TypeId;
        }

        public BookTypeVm()
        {

        }
    }
}
