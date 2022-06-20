using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Domain.Enities
{
    public class BookType
    {
        public int BookId { get; set; }
        public Book Book { get; set; } 
        public int TypeId { get; set; }
        public Type Type { get; set; } 
    }
}
