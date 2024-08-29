using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationCar.Models.Cars.Toyota;

namespace WebApplicationCar.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<ColorModel> Colors { get; set; }
    
    public DbSet<ToyotaModel> ToyotaModels { get; set; }
    
    public DbSet<ConfigurationModel> Configurations { get; set; }
    
    public DbSet<ConfigurationColorsModel> ConfigurationColors { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}