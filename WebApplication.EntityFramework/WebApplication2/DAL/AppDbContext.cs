using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Catigorie>? Catigories { get; set; } 
        public DbSet<Dress>? Dresses { get; set; } 
        public DbSet<Featured>? Featureds { get; set; } 
        public DbSet<Slider>? Sliders { get; set; } 
        public DbSet<Vendor>? Vendors { get; set; } 
    }
}
