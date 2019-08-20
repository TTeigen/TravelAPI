using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelAPIContext : IdentityDbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;userid=root;password=epicodus;port=3306;database=TravelAPI;");

        public TravelAPIContext(DbContextOptions options) : base(options)
        {

        }
        public TravelAPIContext()
        {

        }
    }
}