using Microsoft.AspNetCore.Mvc;
using MiPrimeraApp.Models;

namespace MiPrimeraApp.Controllers;

public class ProductoController : Controller
{
    public IActionResult Lista()
    {
        var Lista = new List<Producto>{
            new () { Id = 1, Nombre = "Laptop", Precio = 2500 },
            new () { Id = 2, Nombre = "Mouse", Precio = 50},
            new () { Id = 3, Nombre = "Teclado", Precio = 120}
         };
        return View(Lista);
    }
    [HttpGet]
    public IActionResult Crear()
    {

        return View();
    }
    [HttpPost]
    public IActionResult Crear(Producto producto)
    {
        if (!ModelState.IsValid)
        {
            //Si hay errores vuelve a mostrar el formulario
            return View(producto);
        }
        // Aqui normalmente lo guardariamos en la base de datos
        // por ahora lo mostramos en consola
        Console.WriteLine($"Producto:{producto.Nombre}, Precio:{producto.Precio}");
        return RedirectToAction("Confirmacion");
    }
    public IActionResult Confirmacion()
    {
        return View();
    }
}