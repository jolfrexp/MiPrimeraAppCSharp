using System.ComponentModel.DataAnnotations;

namespace MiPrimeraApp.Models;

public class Producto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El Nombre es obligatorio")]
    [StringLength(50, ErrorMessage ="EL nombre no puede contener mas de 50 caracteres")]
    public string Nombre { get; set; } = string.Empty;
    [Range(1,100000,ErrorMessage = "EL precio debe ser entre 1 y 100.000")]
    public decimal Precio { get; set; }
    
}