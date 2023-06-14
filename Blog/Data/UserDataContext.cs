using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class UserDataContext : DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
