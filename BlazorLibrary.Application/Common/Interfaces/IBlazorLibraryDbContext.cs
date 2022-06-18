using BlazorLibrary.Domain.Enities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Application.Common.Interfaces
{
    public interface IBlazorLibraryDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookType { get; set; }
        public DbSet<Domain.Enities.Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Writer> Writers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
