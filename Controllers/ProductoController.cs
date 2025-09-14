using Microsoft.AspNetCore.Mvc;
using MiPrimeraApp.Models;
using MiPrimeraApp.Data;
using System.Linq;

namespace MiPrimeraApp.Controllers;

public class ProductoController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductoController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Lista()
    {
        var Lista = new List<Producto>{
            new () { Id = 1, Nombre = "Laptop", Precio = 2500 },
            new () { Id = 2, Nombre = "Mouse", Precio = 50},
            new () { Id = 3, Nombre = "Teclado", Precio = 120}
         };
        return View(Lista);
    }
    //READ: Lista de productos
    public IActionResult Index()
    {
        var productos = _context.Productos.ToList();
        return View(productos);
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
        _context.Productos.Add(producto);
        _context.SaveChanges();
        Console.WriteLine($"Producto:{producto.Nombre}, Precio:{producto.Precio}");
        return RedirectToAction("Index");
    }
    public IActionResult Editar(Producto producto)
    { 
        if (!ModelState.IsValid)
        {
            //Si hay errores vuelve a mostrar el formulario
            return View(producto);
        }
        // Aqui normalmente lo guardariamos en la base de datos
        // por ahora lo mostramos en consola
        _context.Productos.Update(producto);
        _context.SaveChanges();
        Console.WriteLine($"Producto:{producto.Nombre}, Precio:{producto.Precio}");
        return RedirectToAction("Index");
    }
    public IActionResult Eliminar(int id)
    {
        var producto = _context.Productos.Find(id);
        if (producto == null)
        {
            return NotFound();
        }
        _context.Productos.Remove(producto);
        _context.SaveChanges();
        return RedirectToAction("Index");        
    }
}