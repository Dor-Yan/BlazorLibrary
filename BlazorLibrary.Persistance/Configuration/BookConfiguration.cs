using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorLibrary.Domain.Enities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorLibrary.Persistance.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.Publisher).IsRequired().HasMaxLength(30);
            builder.Property(x => x.DateOfEdition).IsRequired();
            builder.Property(x => x.NumberOfPages).IsRequired();
            builder.Property(x => x.ISBN).IsRequired().HasMaxLength(30); ;
            builder.Property(x => x.Available).IsRequired();



        }

    }
}
