using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Users> Users { get; set; }

        public DbSet<AddRate> AddRates { get; set; }

        public DbSet<AddRate_CatAddRate> Rate_CatAddRates { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryAddRate> CategoryAddRates { get; set; }

        public DbSet<Computer> Computers { get; set; }

        public DbSet<FormCheck> FormChecks { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<GameComputer> GameComputers { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Rate> Rates { get; set; }

        public DbSet<TypeDiscount> TypeDiscounts { get; set; }

        public DbSet<TypePay> TypePays { get; set; }




        public ApplicationContext(DbContextOptions dbContext) : base(dbContext)
        {

        }


    }
}
