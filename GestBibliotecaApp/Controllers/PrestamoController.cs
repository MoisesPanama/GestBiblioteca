// GestBiblioteca - Modulo de Prestamos
using Microsoft.AspNetCore.Mvc;
using GestBibliotecaApp.Models;

namespace GestBibliotecaApp.Controllers
{
    public class PrestamoController : Controller
    {
        private static List<Prestamo> _prestamos = new List<Prestamo>();

        // GET: /Prestamo
        public IActionResult Index()
        {
            return View(_prestamos);
        }

        // GET: /Prestamo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Prestamo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                prestamo.Id = _prestamos.Count + 1;
                _prestamos.Add(prestamo);
                return RedirectToAction("Index");
            }
            return View(prestamo);
        }

        // GET: /Prestamo/Delete/5  (solo muestra confirmacion, nunca borra)
        public IActionResult Delete(int id)
        {
            var prestamo = _prestamos.FirstOrDefault(p => p.Id == id);
            if (prestamo == null)
            {
                return NotFound();
            }
            return View(prestamo);
        }

        // POST: /Prestamo/Delete/5  (borra real, protegido con CSRF)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var prestamo = _prestamos.FirstOrDefault(p => p.Id == id);
            if (prestamo != null)
            {
                _prestamos.Remove(prestamo);
            }
            return RedirectToAction("Index");
        }
    }
}