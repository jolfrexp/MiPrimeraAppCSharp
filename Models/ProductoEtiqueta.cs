namespace MiPrimeraApp.Models;

public class ProductoEtiqueta
{
    public int ProductoId { get; set; }
    public Producto? Producto { get; set; }

    public int EtiquetaId { get; set; }
    public Etiqueta? Etiqueta { get; set; }
}