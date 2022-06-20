using BlazorLibrary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Domain.Enities
{
    public class Book : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime DateOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public bool Available { get; set; }
        public string Picture { get; set; }
        public int TypeId { get; set; }
        public int WriterId { get; set; }

        public virtual Type Type { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<BookType> BookTypes { get; set; }
    }
}
