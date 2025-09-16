using Microsoft.EntityFrameworkCore;
using MiPrimeraApp.Models;

namespace MiPrimeraApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Etiqueta> Etiquetas { get; set; }
    public DbSet<ProductoEtiqueta> ProductoEtiquetas { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //Configurar clave compuesta para la tabla intermedia
        modelBuilder.Entity<ProductoEtiqueta>().HasKey(pe => new { pe.ProductoId, pe.EtiquetaId });
    }
}