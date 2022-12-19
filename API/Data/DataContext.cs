
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //DbSet = table in DB>> got into the type<AppUser> and thats our table
        public DbSet<AppUser> Users { get; set; }
    }
}