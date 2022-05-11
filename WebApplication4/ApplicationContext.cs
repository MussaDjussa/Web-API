using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public ApplicationContext(DbContextOptions dbContext) : base(dbContext)
        {

        }
    }
}
