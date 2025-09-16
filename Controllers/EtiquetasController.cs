using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiPrimeraApp.Data;
using MiPrimeraApp.Models;

namespace MiPrimeraApp.Controllers;

public class EtiquetasController : Controller
{
    private readonly ApplicationDbContext _context;

    public EtiquetasController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var etiquetas = _context.Etiquetas.ToList();
        return View(etiquetas);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Etiqueta etiqueta)
    {
        if (ModelState.IsValid)
        {
            _context.Add(etiqueta);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(etiqueta);
    }
    public IActionResult Edit(int Id)
    {
        var etiqueta = _context.Etiquetas.Find(Id);
        if (etiqueta == null) return NotFound();
        return View(etiqueta);
    }
    [HttpPost]
    public IActionResult Edit(int Id, Etiqueta etiqueta)
    {
        if (Id != etiqueta.Id) return NotFound();
        if (ModelState.IsValid)
        {
            _context.Update(etiqueta);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(etiqueta);
    }
    public IActionResult Delete(int Id)
    {
        var etiqueta = _context.Etiquetas.Find(Id);
        if (etiqueta == null) return NotFound();
        return View(etiqueta);
    }
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int Id)
    {
        var etiqueta = _context.Etiquetas.Find(Id);
        if (etiqueta != null)
        {
            _context.Etiquetas.Remove(etiqueta);
            _context.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }

}