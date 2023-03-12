using CarModelProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CarModelProject.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Marka> Markas { get; set; }
        public DbSet<CarModel> CarModels { get; set; }

        public DbSet<Car> Cars { get; set; }




    }
}
