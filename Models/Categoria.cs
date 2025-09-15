using System.ComponentModel.DataAnnotations;

namespace MiPrimeraApp.Models;

public class Categoria
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;
    public List<Producto> Productos { get; set; } = new();
}