using Microsoft.AspNetCore.Mvc;
using MiPrimeraApp.Models;
namespace MiPrimeraApp.Controllers;

public class HolaController : Controller
{
    public IActionResult Producto()
    {
        //Simulamos datos de ejemplo (normalmente vendrian de una base de datos)
        var Lista = new List<Producto>{
            new () { Id = 1, Nombre = "Laptop", Precio = 2500 },
            new () { Id = 2, Nombre = "Mouse", Precio = 50},
            new () { Id = 3, Nombre = "Teclado", Precio = 120}
         };
        return View(Lista);
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Saludo(String nombre)
    {
        ViewBag.Nombre = nombre;
        return View();
    }
    public IActionResult Lista()
    {
        var nombres = new List<string> { "Ana", "Luis", "Pedro", "Maria" };
        return View(nombres);
    }
}