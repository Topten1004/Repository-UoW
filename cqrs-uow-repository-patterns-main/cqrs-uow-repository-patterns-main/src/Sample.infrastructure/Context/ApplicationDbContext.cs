using Microsoft.EntityFrameworkCore;
using Sample.Domain.Entities;

namespace Sample.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}