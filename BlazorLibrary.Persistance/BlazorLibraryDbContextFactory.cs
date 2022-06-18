
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Persistance
{
    public class BlazorLibraryDbContextFactory : DesignTimeDbContextFactoryBase<BlazorLibraryDbContext>
    {
        protected override BlazorLibraryDbContext CreateNewInstance(DbContextOptions<BlazorLibraryDbContext> options)
        {
            return new BlazorLibraryDbContext(options);
        }
    }
}
