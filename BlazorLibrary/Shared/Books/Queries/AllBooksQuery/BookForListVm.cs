using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Shared.Books.Queries.AllBooksQuery
{
    public class BookForListVm
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime DateOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public bool Available { get; set; }
        public DateTime? CreateDate { get; set; }
        public int StatusId { get; set; }
        public int Id { get; set; }
    }
}
