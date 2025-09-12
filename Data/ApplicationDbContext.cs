using Microsoft.EntityFrameworkCore;
using MiPrimeraApp.Models;

namespace MiPrimeraApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Producto> Productos{get; set;}
}