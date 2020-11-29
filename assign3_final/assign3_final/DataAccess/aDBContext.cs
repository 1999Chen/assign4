using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Models;


namespace assign3_final.DataAccess
{
    public class aDBContext:DbContext
    {
        public DbSet<Adult> Adult { get; set; }
        public DbSet<User>User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:/Users/yu/Desktop/a.db");
        }
    }
}