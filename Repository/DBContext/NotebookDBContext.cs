using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.DBContext
{
    public class NotebookDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=NotebookDB;Trusted_Connection=True;");
        }

    }
}
