
using CQRS_Library.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Library.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       

        public DbSet<Items> DBItems { get; set; }





    }
}
