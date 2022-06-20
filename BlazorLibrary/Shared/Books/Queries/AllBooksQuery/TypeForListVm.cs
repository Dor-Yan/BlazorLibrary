using BlazorLibrary.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Shared.Books.Queries.AllBooksQuery
{
    public class TypeForListVm
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public TypeForListVm(Domain.Enities.Type bookType)
        {
            Id = bookType.Id;
            TypeName = bookType.Name;
        }
    }
}
