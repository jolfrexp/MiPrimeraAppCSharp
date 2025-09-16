using System.ComponentModel.DataAnnotations;

namespace MiPrimeraApp.Models;

public class Producto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El Nombre es obligatorio")]
    [StringLength(50, ErrorMessage = "EL nombre no puede contener mas de 50 caracteres")]
    public string Nombre { get; set; } = string.Empty;
    [Range(1, 1000000, ErrorMessage = "EL precio debe ser entre 1 y 1.000.000")]
    public decimal Precio { get; set; }

    //Pk
    [Required(ErrorMessage = "La categoria es requerida")]
    public int CategoriaId { get; set; }

    public Categoria? Categoria { get; set; }

    //Relacion muchos a muchos
    public List<ProductoEtiqueta> ProductoEtiquetas { get; set; } = new();
    
}