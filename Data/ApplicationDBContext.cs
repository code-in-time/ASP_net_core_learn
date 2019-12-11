using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Course
{
    /// <summary>
    /// The database representational model for our application
    /// </summary>
    public class ApplicationDBContext: DbContext
    {
        public DbSet<DbSettingsModel> Settings { get; set; }

        public ApplicationDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
