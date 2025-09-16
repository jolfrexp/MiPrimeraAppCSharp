
namespace MiPrimeraApp.Models;

public class Etiqueta
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    //Relacion muchos a muchos con Producto
    public List<ProductoEtiqueta> ProductoEtiquetas { get; set; } = new();

}