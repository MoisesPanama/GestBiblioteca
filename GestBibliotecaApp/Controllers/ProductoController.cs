using Microsoft.AspNetCore.Mvc;
using GestBibliotecaApp.Models;

namespace GestBibliotecaApp.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> _productos = new List<Producto>();

        // GET: /Producto
        public IActionResult Index()
        {
            return View(_productos);
        }

        // GET: /Producto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Producto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                producto.Id = _productos.Count + 1;
                _productos.Add(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // GET: /Producto/Delete/5 (solo confirmacion, nunca borra)
        public IActionResult Delete(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: /Producto/Delete/5 (borra real, protegido con CSRF)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
            return RedirectToAction("Index");
        }
    }
}