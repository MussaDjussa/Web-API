using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }



        public ApplicationContext(DbContextOptions dbContext) : base(dbContext)
        {

        }


    }
}
