using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VirtualUsedCarsShowroom.Data
{
    public class CarsShowroomDbContext : IdentityDbContext
    {
        public CarsShowroomDbContext(DbContextOptions<CarsShowroomDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<TestDrive> TestDrives { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
