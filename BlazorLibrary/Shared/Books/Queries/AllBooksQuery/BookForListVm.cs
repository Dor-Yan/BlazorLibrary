using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorLibrary.Domain;


namespace BlazorLibrary.Shared.Books.Queries.AllBooksQuery
{
    public class BookForListVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime DateOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public bool Available { get; set; }
        public DateTime? CreateDate { get; set; }
        public int StatusId { get; set; }
        public List<BookTypeVm> BookTypes { get; set; }
        public string WriterName { get; set; }

    }
}
