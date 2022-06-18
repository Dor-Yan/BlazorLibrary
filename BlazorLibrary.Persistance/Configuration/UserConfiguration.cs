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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.EmailAdress).IsRequired();
        }
    }
}
