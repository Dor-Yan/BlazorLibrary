using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorLibrary.Domain.Enities;
using BlazorLibrary.Domain.Common;
using System.Threading;
using System.Reflection;
using BlazorLibrary.Application.Common.Interfaces;
using Type = BlazorLibrary.Domain.Enities.Type;

namespace BlazorLibrary.Persistance
{
    public class BlazorLibraryDbContext : DbContext, IBlazorLibraryDbContext
    {
        public BlazorLibraryDbContext(DbContextOptions<BlazorLibraryDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookType { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Writer> Writers { get; set; }
        

        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelbuilder.Entity<BookType>()
                 .HasKey(it => new { it.BookId, it.TypeId });

            modelbuilder.Entity<BookType>()
                .HasOne<Book>(it => it.Book)
                .WithMany(i => i.BookTypes)
                .HasForeignKey(it => it.BookId)
                .OnDelete(DeleteBehavior.NoAction);

            modelbuilder.Entity<BookType>()
                .HasOne<Type>(it => it.Type)
                .WithMany(i => i.BookTypes)
                .HasForeignKey(it => it.TypeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "";
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.InactivatedBy = "";
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
