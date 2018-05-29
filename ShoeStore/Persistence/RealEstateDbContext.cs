using Microsoft.EntityFrameworkCore;
using RealEstate.Core.Models;

namespace RealEstate.Persistence
{
    public class RealEstateDbContext : DbContext
    {
        public DbSet<County> Counties { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HouseType> HouseType { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options) 
            : base(options)
        {   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<House>().OwnsOne(typeof(Address), "Address");
        }
    }
}